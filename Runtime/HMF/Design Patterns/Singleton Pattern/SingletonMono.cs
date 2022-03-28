using UnityEngine;

namespace HMF.DesignPatterns.SingletonPattern
{
    // credit : wiki.unity3d.com/index.php?title=Singleton#Generic_Based_Singleton_for_MonoBehaviours
    public class SingletonMono<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static bool _shuttingDown = false;
        private static object _lock = new object();
        private static T _instance;

        public static T Instance
        {
            get
            {
                if (_shuttingDown)
                {
                    Debug.LogWarning($"[Singleton] Instance |{ typeof(T)}| already destroyed. Returning null.");
                    return null;
                }

                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = FindObjectOfType<T>();

                        if (_instance == null)
                        {
                            _instance = new GameObject($"Instance of {typeof(T)}").AddComponent<T>();
                        }
                    }

                    return _instance;
                }
            }
        }

        private void Awake()
        {
            if (_instance != null)
                Destroy(gameObject);
        }

        private void OnApplicationQuit()
        {
            _shuttingDown = true;
        }


        private void OnDestroy()
        {
            _shuttingDown = true;
        }
    }
}

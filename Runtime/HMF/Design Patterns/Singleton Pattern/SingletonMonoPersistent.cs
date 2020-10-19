using UnityEngine;

namespace HMF.HMFUtilities.DesignPatterns.SingletonPattern
{
    // credit : wiki.unity3d.com/index.php?title=Singleton#Generic_Based_Singleton_for_MonoBehaviours
    public class SingletonMonoPersistent<T> : MonoBehaviour where T : MonoBehaviour
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
                            var obj = new GameObject($"Instance of {typeof(T)}").AddComponent<T>();
                            _instance = obj;

                            DontDestroyOnLoad(obj);
                        }
                    }

                    return _instance;
                }
            }
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



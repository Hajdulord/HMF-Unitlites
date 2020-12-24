using System.Collections.Generic;
using UnityEngine;


namespace HMF.HMFUtilities.DesignPatterns.Objectpooling
{
    public abstract class GenericObjectPool<T> : MonoBehaviour where T : Component
    {
        [SerializeField]
        T prefab;

        public static GenericObjectPool<T> Instance { get; private set; }

        private Queue<T> pool = new Queue<T>();

        private void Awake()
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }

        public T Get()
        {
            if (pool.Count == 0)
                AddPool(1);
            return pool.Dequeue();
        }

        public void ReturnToQueue(T objectToReturn)
        {
            objectToReturn.gameObject.SetActive(false);
            pool.Enqueue(objectToReturn);
        }

        public void AddPool(int count)
        {
            var newObject = GameObject.Instantiate(prefab);
            newObject.gameObject.SetActive(false);
            pool.Enqueue(newObject);
        }

    }
}


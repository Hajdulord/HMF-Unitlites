using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HMF.HMFUtilities.DesignPatterns.SingletonPattern;

namespace HMF.HMFUtilities.DesignPatterns.Objectpooling
{
    public class GenericObjectPoolSafeSingleton<T> : SingletonMonoPersistent<GenericObjectPoolSafeSingleton<T>> where T : Component
    {
        [SerializeField]
        T prefab;

        private Queue<T> pool = new Queue<T>();

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
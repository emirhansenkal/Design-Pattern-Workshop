using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoSingleton<ObjectPool>
{
    [Serializable]
    public struct Pool
    {
        public Queue<GameObject> pooledObjects;
        public GameObject objectPrefab;
        public int poolSize;
    }

    //Pool listesi
    [SerializeField] private Pool[] pools = null;

    private void Awake()
    {
        for (int j = 0; j < pools.Length; j++)
        {
            pools[j].pooledObjects = new Queue<GameObject>();

            for (int i = 0; i <  pools[j].poolSize; i++)
            {
                GameObject obj = Instantiate( pools[j].objectPrefab);//Obje oluştur
                obj.SetActive(false);//Objeyi kapat
            
                pools[j].pooledObjects.Enqueue(obj);//Objeyi listeye ekle
            }
        }
    }

    public GameObject GetPooledObject(int objectType, Vector3 position)
    {
        if (objectType >= pools.Length)
        {
            return null;
        }
        //Objeyi sıradan çıkarıyoruz
        GameObject obj =  pools[objectType].pooledObjects.Dequeue();

        //Pozisyonunu değiştirip aktif hale getiriyoruz.
        obj.transform.position = position;
        obj.SetActive(true);
        
        //Objeyi yeniden sıraya sokuyoruz.
        pools[objectType].pooledObjects.Enqueue(obj);
        
        return obj;
    }
}
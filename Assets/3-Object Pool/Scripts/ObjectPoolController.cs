using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolController : MonoBehaviour
{
    [SerializeField] private float _spawnInterval = 0.1f;
    [SerializeField] private Transform _spawnTransform = null;

    private void Start()
    {
        StartCoroutine(nameof(SpawnRoutine));
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            //Object Pool'dan "0" tipli bir obje çek
            var spawnedObject = ObjectPool.Instance.GetPooledObject(0, _spawnTransform.position);

            //_spawnInterval kadar bekle
            yield return new WaitForSeconds(_spawnInterval);
        }
    }
}

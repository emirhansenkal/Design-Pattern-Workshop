using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerOP : MonoBehaviour
{
    private float _speed = 5;
    private int _gold = 0;

    public static event Action<int> OnGoldCollected;
    
    private void Start()
    {
        InputSystem.OnKeyHold += Move;
        _gold = 0;
    }

    public void Move(Vector3 direction) => transform.Translate(direction * Time.deltaTime * _speed);


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gold"))
        {
            _gold++;
            OnGoldCollected?.Invoke(_gold);
            other.transform.position = new Vector3(Random.Range(-5f,5f), 0, Random.Range(-5f,5f));
        }
    }
}

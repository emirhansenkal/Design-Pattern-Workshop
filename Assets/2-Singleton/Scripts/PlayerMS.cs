using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMS : MonoSingleton<PlayerMS>//MonoSingleton'dan türetiyoruz. 
{
    #region Movement

    private float _speed = 5;

    public void Move(Vector3 direction) => transform.Translate(direction * Time.deltaTime * _speed);

    #endregion
}

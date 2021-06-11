using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUS : MonoBehaviour
{

    #region Singleton
    //Tek olacak olan objemizi static olarak üretiyoruz.
    private static PlayerUS _instance = null;

    public static PlayerUS Instance
    {
        get
        {
            /*if (_instance == null)
            {
                _instance = new GameObject("PlayerUS").AddComponent(typeof(PlayerUS)) as PlayerUS;
            }*/

            return _instance;
        }
    }

    private void OnEnable()
    {
        // Obje aktif olduğunda instance'ımızı dolduyoruz.
        _instance = this;
    }

    #endregion
    
    #region Movement

    private float _speed = 5;

    public void Move(Vector3 direction) => transform.Translate(direction * Time.deltaTime * _speed);

    #endregion

}

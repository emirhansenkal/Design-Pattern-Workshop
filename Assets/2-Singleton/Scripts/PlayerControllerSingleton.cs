using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerSingleton : MonoBehaviour
{
    private void FixedUpdate()
    {
        Vector3 delta = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        
        PlayerUS.Instance?.Move(delta); //Singleton
        
        
        
        
        PlayerMS.Instance?.Move(delta); //MonoSingleton
    }
}

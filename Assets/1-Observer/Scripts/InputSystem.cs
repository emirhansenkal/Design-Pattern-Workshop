using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem : MonoBehaviour
{
    public static event Action<Vector3> OnKeyHold;
    
    private void FixedUpdate()
    {
        if (!Input.anyKey) return;
        
        Vector3 delta = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        OnKeyHold?.Invoke(delta);
    }
}

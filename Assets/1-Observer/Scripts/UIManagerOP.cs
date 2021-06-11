using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManagerOP : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _goldText = null;

    private void Start()
    {
        //Gözlemle
        PlayerOP.OnGoldCollected += SetGoldText;
    }

    public void SetGoldText(int goldAmount) => _goldText.text = goldAmount.ToString();
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinNumber : MonoBehaviour
{
    //public Text coinText;

 
    void Start()
    {

    }

    
    void Update()
    {
        GetComponent<Text>().text=SystemStorage.coin.ToString();
    }

    public void Click() {
        SystemStorage.coin+=1;
    }

   
    public void Buy5(){
        SystemStorage.coin-=5;
    }
}
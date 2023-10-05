using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    [SerializeField] private int _moneyAmout;
     public void ProcessBuy(int money)
     {
        if(_moneyAmout - money < 0)
        {
            return;
        }

        _moneyAmout -= money;
     }

    public bool CanBuy(int price)
    {
        return _moneyAmout - price >= 0;
    }
    
    public int currentMoney()
    {
        return _moneyAmout;
    }
}


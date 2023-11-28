using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.Utilities;
using UnityEngine.UI;
using UnityEngine.Events;

public class PlayerMoney : MonoBehaviour
{
    [SerializeField] private int _moneyAmount;
    [SerializeField] private Text money_Text;
    [HideInInspector] public UnityEvent change_money;

    public int MoneyAmount => _moneyAmount;
    public void ProcessBuy(int money)
     {
        if(_moneyAmount - money < 0)
        {
            return;
        }

        _moneyAmount -= money;
        change_money?.Invoke();
     }

    public bool CanBuy(int price)
    {
        return _moneyAmount - price >= 0;
    }
    public void AddMoney(int amount)
    {
        _moneyAmount += amount;
        money_Text.text = $"Δενόγθ: {_moneyAmount}";
        change_money?.Invoke();
    }

}


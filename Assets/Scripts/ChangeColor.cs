using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Renderer floor;
    [SerializeField] private Renderer wall1;
    [SerializeField] private Renderer wall2;
    [SerializeField] private Renderer wall3;
    [SerializeField] private PlayerMoney playerMoney;
    [SerializeField] private int price;
    [SerializeField] private Text _money_text;

    public void ChangeColorP()
    {

        if (playerMoney.CanBuy(price))
        {
            playerMoney.ProcessBuy(price);
            floor.material.color = Random.ColorHSV();
            wall1.material.color = Random.ColorHSV();
            wall2.material.color = Random.ColorHSV();
            wall3.material.color = Random.ColorHSV();
            _money_text.text = $"Δενόγθ: {playerMoney.MoneyAmount}";

        }
    }
}

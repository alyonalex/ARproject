using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.Utilities;
using UnityEngine;
using UnityEngine.UI;

public class ARMenu : MonoBehaviour
{
    [SerializeField] private ItemsConfig _itemsConfig;

    [SerializeField] private GameObject _buttonPrefab;

    [SerializeField] private Transform _root;

    [SerializeField] private GridObjectCollection _gridObjectCollection;

    [SerializeField] private PlayerMoney _playerMoney;

    [SerializeField] private Text text;

    private int startCountButton;

    public void UpdateTextMoney()
    {
        text.text = $"Money: {_playerMoney.MoneyAmount}";
    }

    private void Start()
    {
        startCountButton = _root.childCount;
        UpdateTextMoney();
        UpdateButtons();
    }

    private void UpdateButtons()
    {
        for(int i = startCountButton; i < _root.childCount; i++)
        {
            Destroy(_root.GetChild(i).gameObject);
        }

        foreach(var itemsConfigItem in _itemsConfig.Items)
        {
            if(!_playerMoney.CanBuy(itemsConfigItem.Price))
            {
                continue;
            }

            var button = Instantiate(_buttonPrefab, _root);

            if(button.TryGetComponent(out ArButton arButton))
            {
                arButton.Initialize(itemsConfigItem);
            }

            arButton.OnButtonClicked += () => ProcessBuy(itemsConfigItem.Price);
        }

        StartCoroutine(UpdateCollection());
    }

    private void ProcessBuy(int price)
    {
        _playerMoney.ProcessBuy(price);

        UpdateButtons();
        UpdateTextMoney();
    }
    private IEnumerator UpdateCollection()
    {
        yield return new WaitForEndOfFrame();

        _gridObjectCollection.UpdateCollection();

    }
}
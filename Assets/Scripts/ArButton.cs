using Microsoft.MixedReality.Toolkit.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ArButton : MonoBehaviour
{
    public event Action OnButtonClicked;

    [SerializeField] private TextMeshPro _title;

    [SerializeField] private Interactable _interactable;

    private GameObject _prefab;

    public void Initialize(Item config)
    {

        _title.text = config.Title;
        _prefab = config.Prefab;
        _interactable.OnClick.AddListener(ProcessClick);
    }

    private void ProcessClick()
    {
        OnButtonClicked?.Invoke();
        Instantiate(_prefab, new Vector3(-0.477f, -1.2f, 4.405f), new Quaternion(0, 0, 0, 0));
    }
}

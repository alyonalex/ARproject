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

    private Vector3 _spawn;

    private GameObject _prefab;

    public void Initialize(Item config)
    {

        _title.text = config.Title;
        _prefab = config.Prefab;
        _spawn = config.SpawnPoint;
        _interactable.OnClick.AddListener(ProcessClick);
    }

    private void ProcessClick()
    {
        Instantiate(_prefab, _spawn, Quaternion.identity);
        OnButtonClicked?.Invoke();
    }
}

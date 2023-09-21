using System;
using UnityEngine;

[Serializable]
public class MenuItem
{
    [field: SerializeField] public string ID { get; private set; }
    [field: SerializeField] public string Name { get; private set; }
}
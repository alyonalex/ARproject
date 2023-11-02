using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Renderer floor;
    public void ChangeColorP()
    {
        floor.material.color = Random.ColorHSV();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Renderer floor;
    [SerializeField] private Renderer wall1;
    [SerializeField] private Renderer wall2;
    [SerializeField] private Renderer wall3;

    public void ChangeColorP()
    {
        floor.material.color = Random.ColorHSV();
        wall1.material.color = Random.ColorHSV();
        wall2.material.color = Random.ColorHSV();
        wall3.material.color = Random.ColorHSV();
    }
}

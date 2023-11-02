using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remove : MonoBehaviour
{
    public GameObject _object;

    public void Button_click()
    {
        if (_object.activeInHierarchy == true)
            _object.SetActive(false);
        else
            _object.SetActive(true);
    }
}

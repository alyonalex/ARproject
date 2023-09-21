using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject spawnGameObject;

    public void SpawnP()
    {
        if (spawnGameObject != null)
        {
            Instantiate(spawnGameObject, transform);
        }
    }

}


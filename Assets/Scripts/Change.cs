using UnityEngine;
using System.Collections;

public class Change : MonoBehaviour
{
    public Color collisionColor; 

    private Renderer renderer;
    private Color originalColor;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        originalColor = renderer.material.color;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("object"))
        {
            renderer.material.color = collisionColor;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        renderer.material.color = originalColor;
    }
}

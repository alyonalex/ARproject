using UnityEngine;
using System.Collections;

public class Change : MonoBehaviour
{
    private Renderer renderer;
    public int _moneyEarned = 100;
    [SerializeField] private PlayerMoney playerMoney;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("object"))
        {
            Color collisionColor = new Color(Random.value, Random.value, Random.value, 1f);
            renderer.material.color = collisionColor;
            playerMoney.AddMoney(_moneyEarned);
        }
    }
}

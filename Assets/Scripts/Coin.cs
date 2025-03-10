using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag( "Player"))
        {
            GameManager.instance.AddCoin(coinValue);
            Destroy(gameObject);
        }
    }
}

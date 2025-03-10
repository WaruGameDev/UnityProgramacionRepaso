using System;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int coinCount;
    public TextMeshProUGUI coinText;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        coinText.text = coinCount.ToString();
    }

    public void AddCoin(int amount)
    {
        coinCount += amount;
        coinText.text = coinCount.ToString();
    }
}

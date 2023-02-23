using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NerfBlock : MonoBehaviour
{
    [SerializeField] Text coinsText;
    [SerializeField] Text gameFinishCoinText;
    private void OnTriggerEnter(Collider ayb)
    {
        if (ayb.gameObject.CompareTag("Player"))
        {
            int ACoin = PlayerPrefs.GetInt("ACoin");
            PlayerPrefs.SetInt("ACoin", ACoin - 3);
            coinsText.text = "Coins: " + PlayerPrefs.GetInt("ACoin");
            gameFinishCoinText.text = "Collected Coin: " + PlayerPrefs.GetInt("ACoin");
            Debug.Log(PlayerPrefs.GetInt("ACoin"));

        }



    }
}

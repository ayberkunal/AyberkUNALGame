using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinAgent : MonoBehaviour
{

    [SerializeField] Text coinsText;
    [SerializeField] Text gameFinishCoinText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            int ACoin = PlayerPrefs.GetInt("ACoin");
            int ACoins = PlayerPrefs.GetInt("ACoin");
            Destroy(this.gameObject);
            PlayerPrefs.SetInt("ACoin", ACoin + 1);
            
            coinsText.text = "Coins: " + ACoins;
            gameFinishCoinText.text = "Collected Coin: " + ACoin;

        }



    }


}

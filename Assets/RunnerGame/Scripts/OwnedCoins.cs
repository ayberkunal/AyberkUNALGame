using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OwnedCoins : MonoBehaviour
{
    public int currentLevel;

    Text level;
    void Start()
    {
        level = GetComponent<Text>();
        currentLevel = PlayerPrefs.GetInt("MainCoin");

    }


    // Update is called once per frame
    void Update()
    {

        level.text = "Owned Coin: " + currentLevel;
    }
}

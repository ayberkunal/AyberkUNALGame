using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Events : MonoBehaviour
{
    public int currentLevel;
    void Start()
    {
        currentLevel = PlayerPrefs.GetInt("levelAt");
    }
    
    public void ReplayGame()
    {
        PlayerPrefs.SetInt("ACoin", 1);
        if (currentLevel == 0)
        {
            SceneManager.LoadScene("Level1");
        }
        else
        {
            SceneManager.LoadScene(currentLevel);
        }
    }

    public void StartGame() 
    {
        PlayerPrefs.SetInt("ACoin", 1);
        if (currentLevel == 0)
        {
            SceneManager.LoadScene("Level1");
        }
        else
        {
            SceneManager.LoadScene(currentLevel);
        }
    }


    public void MainMenu()
    {
        SceneManager.LoadScene("HomePanel");
    }
    public void MainMenu2()
    {
        int ACoin = PlayerPrefs.GetInt("ACoin");
        int MainCoins = PlayerPrefs.GetInt("MainCoin");
        Debug.Log(MainCoins);
        PlayerPrefs.SetInt("MainCoin", MainCoins + ACoin);
        SceneManager.LoadScene("HomePanel");
    }

    public void NextLevel()
    {
        int ACoin = PlayerPrefs.GetInt("ACoin");
        int MainCoins = PlayerPrefs.GetInt("MainCoin");
        PlayerPrefs.SetInt("MainCoin", ACoin + MainCoins);
        SceneManager.LoadScene(currentLevel);
    }
    public void ResetGame()
    {
        //PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("ACoin", 1);
        PlayerPrefs.SetInt("levelAt", 0);
        SceneManager.LoadScene("HomePanel");
    }
}

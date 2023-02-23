using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelAndCash : MonoBehaviour
{
    public int currentLevel;
    
    Text level;
    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 1);
        level = GetComponent<Text> ();
        currentLevel = PlayerPrefs.GetInt("levelAt");

    }


    // Update is called once per frame
    void Update()
    {
        if (currentLevel == 0)
        {
            level.text = "Level 1";
        }
        else
        {
            level.text = "Level " + currentLevel;
        }
    }
}

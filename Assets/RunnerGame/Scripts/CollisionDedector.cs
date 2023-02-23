using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CollisionDedector : MonoBehaviour
{

    public int nextSceneLoad;
    public int currentLevel;

    void Start()
    {
        currentLevel = PlayerPrefs.GetInt("levelAt");
    }

    private void Update()
    {
        if (transform.position.y < -1f)
        {
            SceneManager.LoadScene("GameOverPanel");
        }
    }

    private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.tag == "Fail")
            {
                SceneManager.LoadScene("GameOverPanel");
            }

            if (collision.collider.tag == "Finish")
            
        {
            if (currentLevel == 5)
            {
                SceneManager.LoadScene("GameComp");
            }
            else
            {
                nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
                SceneManager.LoadScene("FinishPanel");
            }



                if(nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
                {
                PlayerPrefs.SetInt("levelAt", nextSceneLoad);
                }

            }
    }


}

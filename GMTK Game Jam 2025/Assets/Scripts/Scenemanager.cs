using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemanager : MonoBehaviour
{
    float WaitBeforeStart = 5f;
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && SceneManager.GetActiveScene().buildIndex != 1&& SceneManager.GetActiveScene().buildIndex != 3)
        {
            SceneManager.LoadScene(1);
        }

        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(3);

            }
        }
            

       

        WaitBeforeStart -= Time.deltaTime;
        if(WaitBeforeStart < 0 && SceneManager.GetActiveScene().buildIndex !=3)
        {
            SceneManager.LoadScene(3);
        }
        
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(2);
    }

  


}

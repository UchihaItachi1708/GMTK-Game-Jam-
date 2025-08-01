using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemanager : MonoBehaviour
{
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && SceneManager.GetActiveScene().buildIndex != 1)
        {
            SceneManager.LoadScene(1);
        }
        
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(2);
    }
}

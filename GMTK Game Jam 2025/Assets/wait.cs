using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class wait : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(WaitBeforeEndScene());
    }

    IEnumerator WaitBeforeEndScene()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(3);

    }
}

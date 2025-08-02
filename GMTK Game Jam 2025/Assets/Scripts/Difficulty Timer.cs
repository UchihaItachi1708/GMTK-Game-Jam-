using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyTimer : MonoBehaviour
{
    private float Timer; 

    private void Update()

   {
        Timer += Time.deltaTime;
        if(Timer <10)
        {
            Time.timeScale = 2f;
        }
   }
}

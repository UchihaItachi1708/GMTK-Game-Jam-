using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiomanager : MonoBehaviour
{
   
    [SerializeField] AudioSource WalkingAudio;
   
   
    [SerializeField] AudioClip Walking;
    


    private void Start()
    {
        

        WalkingAudio.clip = Walking;
        WalkingAudio.loop = true;
        WalkingAudio.Play();
    }
}

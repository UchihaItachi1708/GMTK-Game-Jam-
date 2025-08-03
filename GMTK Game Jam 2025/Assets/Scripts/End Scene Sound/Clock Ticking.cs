using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockTicking : MonoBehaviour
{
    [SerializeField] private AudioSource audiosource;
    [SerializeField] private AudioClip clip;
    
    void Start()
    {
        audiosource.clip = clip;
        audiosource.Play(); 
    }

    
}

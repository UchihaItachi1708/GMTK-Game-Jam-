using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScene1 : MonoBehaviour
{
    [SerializeField]private AudioSource Women_Crying;
    [SerializeField] private AudioSource Sword_Drawn;
    [SerializeField] private AudioSource Bg;

    [SerializeField] private AudioClip womencry;
    [SerializeField] private AudioClip Sworddraw;
    [SerializeField] private AudioClip bgs;

    private void Start()
    {
        Women_Crying.clip = womencry;
        Women_Crying.Play();
       

        Sword_Drawn.clip = Sworddraw;
        Sword_Drawn.Play();


        Bg.clip = bgs;
        Bg.loop = true;
        Bg.Play();
      
       
    }
}

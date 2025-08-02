using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject button;
     private Audiomanager audiomanager;

    private bool isPaused = false;

    private void Start()
    {
        if (audiomanager == null)
        {
            audiomanager = FindObjectOfType<Audiomanager>();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;

            if (isPaused)
            {
                Time.timeScale = 0f;
                button.SetActive(true);
                audiomanager.PauseAudio(); 
            }
            else
            {
                Time.timeScale = 1f;
                button.SetActive(false);
                audiomanager.Walkingaudio2(); 
            }
        }
    }
}

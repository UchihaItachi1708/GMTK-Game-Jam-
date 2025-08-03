using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioBackgroundScript : MonoBehaviour
{
    [SerializeField] private AudioSource Bg;
    [SerializeField] private AudioClip BgClip;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        Bg.clip = BgClip;
        Bg.loop = true;
        Bg.Play();

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        
        if (scene.buildIndex == 5)
        {
            Bg.Stop();
        }
        
        else if (scene.buildIndex == 3)
        {
            if (!Bg.isPlaying)
            {
                Bg.Play();
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] private float JumpForce;
    [SerializeField] private LayerMask GroundLayer;
    private Animator animator;
    private Rigidbody2D rb;
    [SerializeField] private Audiomanager audiomanager;
    [SerializeField] private AudioSource trippingSource;
    [SerializeField] private AudioClip trippingClip;
    [SerializeField] private GameObject Devils;
    // private bool Isground = false;

    // Post-processing
    private Volume globalVolume;
    private Vignette vignette;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        audiomanager = FindObjectOfType<Audiomanager>();
        // Get the Volume and Vignette
        globalVolume = FindObjectOfType<Volume>();
        if (globalVolume != null && globalVolume.profile.TryGet(out vignette))
        {
            vignette.intensity.Override(0.266f);
        }


    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Physics2D.Raycast(transform.position, Vector2.down, 2.7f, GroundLayer))
            {
                animator.SetBool("Jump", true);
                rb.velocity = new Vector2(0, JumpForce);
               // Isground = true;
            }
        }
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            animator.SetBool("Slide", true);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * 2.7f);
    }

    public void JumpanimationStop()
    {
        animator.SetBool("Jump", false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("log"))
        {
            animator.SetBool("Tripping", true);
        }
    }


    public void Tripping()
    {
        Devils.SetActive(true);
        trippingSource.clip = trippingClip;
        trippingSource.Play();

        Time.timeScale = 0f;

        if (vignette != null)
        {
            StartCoroutine(FadeVignette(1f, 2f));
        }

        

        if (audiomanager != null)
        {
            audiomanager.Walkingaudio(); 
        }

       
    }

    private IEnumerator FadeVignette(float targetIntensity, float duration)
    {
        float start = vignette.intensity.value;
        float elapsed = 0f;

        while (elapsed < duration)
        {
            elapsed += Time.unscaledDeltaTime;
            float current = Mathf.Lerp(start, targetIntensity, elapsed / duration);
            vignette.intensity.Override(current);
            yield return null;
        }

        vignette.intensity.Override(targetIntensity);
        SceneManager.LoadScene(5);
        Time.timeScale = 1.0f;


    }





}

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
    private bool Isground = false;

   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        audiomanager = FindObjectOfType<Audiomanager>();

       
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Physics2D.Raycast(transform.position, Vector2.down, 2.7f, GroundLayer))
            {
                animator.SetBool("Jump", true);
                rb.velocity = new Vector2(0, JumpForce);
                Isground = true;
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
        Time.timeScale = 0f;
        SceneManager.LoadScene(4);
        Time.timeScale = 1.0f;

        if (audiomanager != null)
        {
            audiomanager.Walkingaudio(); 
        }

       
    }

    


   
}

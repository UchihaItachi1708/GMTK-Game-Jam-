using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogMovingphysics : MonoBehaviour
{
    [SerializeField] private float LogSpeed = 2f;
    [SerializeField] private LayerMask LayerMask;
    [SerializeField] private AudioSource log_fall;
    [SerializeField] private AudioClip logclip;

    private Rigidbody2D rb;
    private bool isPlayed = false;
    private bool hasShaken = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
        if (Physics2D.Raycast(transform.position, Vector2.down, 0.7f, LayerMask))
        {
            
            transform.Translate(new Vector2(LogSpeed, 0f) * Time.deltaTime);

           
            if (!isPlayed)
            {
                log_fall.clip = logclip;
                log_fall.Play();
                isPlayed = true;
               
            }

            
            if (!hasShaken)
            {
                CineMachineShake.Instance.ShakeCamera(5f, 0.3f);
                hasShaken = true;
            }
        }
    }

    private void OnDrawGizmos()
    {
        // Visualize raycast in editor
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * 0.7f);
    }
}

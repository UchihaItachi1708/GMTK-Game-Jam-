using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogMovingphysics : MonoBehaviour
{
    [SerializeField] private float LogSpeed;
    [SerializeField] private LayerMask LayerMask;
    [SerializeField] private AudioSource log_fall;
    [SerializeField] private AudioClip logclip;

    private bool IsGround = false;
    private bool hasPlayedAudio = false;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
        if (Physics2D.Raycast(transform.position, Vector2.down, 0.7f, LayerMask))
        {
            transform.Translate(new Vector2(LogSpeed, 0f) * Time.deltaTime);
            IsGround = true;
        }

       
        if (IsGround && !hasPlayedAudio)
        {
            log_fall.clip = logclip;
            log_fall.Play();
            hasPlayedAudio = true;
            
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * 0.7f);
    }
}

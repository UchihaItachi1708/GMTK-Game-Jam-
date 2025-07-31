using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] private float JumpForce;
   
   
     private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
          rb.velocity = Vector2.up * JumpForce;

        }

       
    }

    
}

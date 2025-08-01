using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] private float JumpForce;
    [SerializeField] private LayerMask GroundLayer;
   
   
     private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {

       
        if(Input.GetKeyDown(KeyCode.Space))
        {
           if (Physics2D.Raycast(transform.position, Vector2.down,2.7f,GroundLayer))
           {
                rb.velocity = new Vector2(0,JumpForce);
           }
                
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position,transform.position + Vector3.down*2.7f);
    }


}

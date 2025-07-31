using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMoveScript : MonoBehaviour
{
    [SerializeField] private float Speed;
   
    void Update()
    {
        transform.Translate (new Vector2(Speed, 0f) * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Destroy"))
        {
           Destroy(gameObject);
        }
       
    }
}

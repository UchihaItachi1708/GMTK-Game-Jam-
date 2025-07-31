using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    [SerializeField] private GameObject Floor;
   


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Trigger"))
        {
            Instantiate(Floor,new Vector2(10f,0f), Quaternion.identity);
            
        }
    }


}

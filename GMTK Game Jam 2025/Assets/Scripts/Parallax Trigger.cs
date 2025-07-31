using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxTrigger : MonoBehaviour
{
    [SerializeField] private GameObject Parallax;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Spawn"))
        {
          Instantiate(Parallax,new Vector3 (50f, -6.877779f), Quaternion.identity);

        }
       
    }
}

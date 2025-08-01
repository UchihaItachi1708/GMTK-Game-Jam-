using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxTrigger : MonoBehaviour
{
    [SerializeField] private GameObject Parallax;
    [SerializeField] private GameObject Log;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Spawn"))
        {
          Instantiate(Parallax,new Vector3 (50f, -6.877779f), Quaternion.identity);
          GameObject log = Instantiate(Log,new Vector3(14f, -2.83f),Quaternion.identity);
          Destroy(log, 5f);

        }
       
    }
}

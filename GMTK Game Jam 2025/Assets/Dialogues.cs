using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogues : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer; 
    [SerializeField] private Sprite[] sprites; 

    private void Start()
    {
        StartCoroutine(SwitchSpriteRoutine());
    }

    private IEnumerator SwitchSpriteRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f); 

           
            int randomIndex = Random.Range(0, sprites.Length);
            spriteRenderer.sprite = sprites[randomIndex];
            spriteRenderer.enabled = true;

           
            yield return new WaitForSeconds(2f);

           
            spriteRenderer.enabled = false;
        }
    }
}



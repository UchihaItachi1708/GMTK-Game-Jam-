using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;


public class EndAnimation : MonoBehaviour
{
    // Post-processing
    private Volume globalVolume;
    private Vignette vignette;
    [SerializeField] private GameObject button;

    private void Start()
    {
        // Get the Volume and Vignette
        globalVolume = FindObjectOfType<Volume>();
        if (globalVolume != null && globalVolume.profile.TryGet(out vignette))
        {
            vignette.intensity.Override(1f);
        }
    }

    public void StopAnimation()
    {
       
        Time.timeScale = 0f;
        if (vignette != null)
        {
            StartCoroutine(FadeVignette(0.266f, 2f));
        }
    }

    private IEnumerator FadeVignette(float targetIntensity, float duration)
    {
        float start = vignette.intensity.value;
        float elapsed = 0f;

        while (elapsed < duration)
        {
            elapsed += Time.unscaledDeltaTime;
            float current = Mathf.Lerp(start, targetIntensity, elapsed / duration);
            vignette.intensity.Override(current);
            yield return null;
        }

        vignette.intensity.Override(targetIntensity);
        button.SetActive(true);

    }
}

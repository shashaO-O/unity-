using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadingScript : MonoBehaviour
{
    [SerializeField]
    private CanvasGroup canvasGroup;
    [SerializeField]
    private float fadeDuration = 1.0f;//ת��ʱ��

    [SerializeField]
    private bool fadeIn = false;

    private void Start()
    {
        if (fadeIn)
        {
            FadeIn();
        }
        else
        {
            Fadeout();
        }
    }

    public void FadeIn()
    {
        StartCoroutine(FadeCanvasGroup(canvasGroup, canvasGroup.alpha, 0, fadeDuration));
    }

    public void Fadeout()
    {
        StartCoroutine(FadeCanvasGroup(canvasGroup, canvasGroup.alpha, 1, fadeDuration));
    }



    private IEnumerator FadeCanvasGroup(CanvasGroup cg,float start,float end,float duration)
    {
        float elapsedTime = 0.0f;
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            cg.alpha = Mathf.Lerp(start, end, elapsedTime / duration);
            yield return null;
        }
        cg.alpha = end;
    }

   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroManagement : MonoBehaviour
{
    [SerializeField] private Image introBannerImage;
    void Start()
    {
        StartCoroutine(IntroBannerFadeAnimation());
    }

    void Update()
    {
        // ...boş...
    }

    private IEnumerator IntroBannerFadeAnimation()
    {
        // Opaklaştır (fade in)
        float duration = 1.5f;
        float elapsed = 0f;
        Color color = introBannerImage.color;
        color.a = 0f;
        introBannerImage.color = color;
        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            color.a = Mathf.Clamp01(elapsed / duration);
            introBannerImage.color = color;
            yield return null;
        }

        // Bir süre opak kalsın
        yield return new WaitForSeconds(1f);

        // Saydamlaştır (fade out)
        duration = 1.5f;
        elapsed = 0f;
        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            color.a = Mathf.Clamp01(1f - (elapsed / duration));
            introBannerImage.color = color;
            yield return null;
        }
        // Oyun sahnesine geçiş yap
        SceneManager.LoadScene("Main Menu");
    }
}

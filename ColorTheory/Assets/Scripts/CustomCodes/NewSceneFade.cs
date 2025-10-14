using UnityEngine;
using System.Collections;

public class NewSceneFade : CustomCode
{
    [SerializeField] private float duration = 5f;
    [SerializeField] private float fadeWaitTime;
    [SerializeField] private float time;
    private SpriteRenderer spriteRenderer;
    private Color originalColor;
    [Space(8)]
    [SerializeField] private bool FadeScene = true;
    [Space(8)]
    [SerializeField] private GameObject SceneFadingOut;
    [SerializeField] private GameObject SceneFadingIn;
    [Space(8)]
    [SerializeField] private CustomCode[] customCodes;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;
    }

    protected override void Codes()
    {
        StartCoroutine(OneFade());
    }

    private IEnumerator OneFade()
    {
        yield return new WaitForSeconds(fadeWaitTime);
        yield return StartCoroutine(FadeAlpha(0f, 1f, duration / time));
        if (FadeScene)
        {
            SceneFadingOut.SetActive(false);
            SceneFadingIn.SetActive(true);
        }
        yield return new WaitForSeconds(0.7f);
        yield return StartCoroutine(FadeAlpha(1f, 0f, duration / time));
        FadeScene = false;

        if(customCodes != null)
        {
            for(int i = 0; i < customCodes.Length; i++)
            {
                customCodes[i].NextThings();
            }
        }
    }

    private IEnumerator FadeAlpha(float from, float to, float time)
    {
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / time;

            Color c = originalColor;
            c.a = Mathf.Lerp(from, to, t); // change only alpha
            spriteRenderer.color = c;

            yield return null;
        }
    }
}

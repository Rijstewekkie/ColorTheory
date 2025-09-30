using UnityEngine;
using System.Collections;

public class NewSceneFade : CustomCode
{
    [SerializeField] private float duration = 5f;
    private SpriteRenderer spriteRenderer;
    private Color originalColor;

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
        yield return new WaitForSeconds(3f);
        yield return StartCoroutine(FadeAlpha(0f, 1f, duration / 2f));
        yield return new WaitForSeconds(0.5f);
        yield return StartCoroutine(FadeAlpha(1f, 0f, duration / 2f));
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

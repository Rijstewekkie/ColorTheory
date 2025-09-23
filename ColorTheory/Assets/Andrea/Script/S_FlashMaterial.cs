using System.Collections;
using UnityEngine;
using static TriggerObject;

public class S_FadeOpacity : MonoBehaviour
{
    [Tooltip("Duration of one fade-in/out cycle.")]
    [SerializeField] private float duration = 5f;

    private SpriteRenderer spriteRenderer;
    private Color originalColor;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;

        StartCoroutine(FadeLoop());
    }

    private IEnumerator FadeLoop()
    {
        while (true)
        {
            // Fade out (alpha 1 → 0)
            yield return StartCoroutine(FadeAlpha(.5f, 0f, duration / 2f));

            // Fade in (alpha 0 → 1)
            yield return StartCoroutine(FadeAlpha(0f, .5f, duration / 2f));
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

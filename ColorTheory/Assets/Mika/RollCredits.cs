using UnityEngine;
using System.Collections;
using JetBrains.Annotations;

public class RollCredits : CustomCode
{
    [Header("Fade Settings")]
    [SerializeField] private float fadeWaitTime = 1f;  // Wait before fading
    [SerializeField] private float fadeDuration = 2f;  // How long fade to black takes

    [Header("Credits Settings")]
    [SerializeField] private GameObject creditsParent; // Parent of all credit text objects
    [SerializeField] private float scrollSpeed = 1f;   // Scroll speed of credits
    [SerializeField] private float startDelay = 1f;    // Delay after fade before rolling

    private SpriteRenderer spriteRenderer;
    private Color originalColor;
    private bool startRolling = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;
    }

    private IEnumerator FadeAndRoll()
    {
        yield return new WaitForSeconds(fadeWaitTime);

        // Fade to black
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / fadeDuration;
            Color c = originalColor;
            c.a = Mathf.Lerp(0f, 1f, t);
            spriteRenderer.color = c;
            yield return null;
        }

        // Wait a bit, then start rolling
        yield return new WaitForSeconds(startDelay);
        startRolling = true;
    }

    void Update()
    {
        if (startRolling && creditsParent != null)
        {
            // Move credits upward like traditional movie credits
            creditsParent.transform.Translate(Vector3.up * scrollSpeed * Time.deltaTime);
        }
    }

    protected override void Codes()
    {
        StartCoroutine(FadeAndRoll());
    }
}

using UnityEngine;
using System.Collections;

public class BounceOnClick : CustomCode
{
    private bool isBouncing = false;

    protected override void Codes()
    {
        if (!isBouncing)
            StartCoroutine(Bounce());
    }

    private IEnumerator Bounce()
    {
        isBouncing = true;

        Vector3 originalScale = transform.localScale;
        Vector3 smallerScale = originalScale * 0.8f;
        Vector3 biggerScale = originalScale * 1.2f;
        float duration = 0.1f;
        float elapsed = 0f;

        // Scale down
        while (elapsed < duration)
        {
            transform.localScale = Vector3.Lerp(originalScale, smallerScale, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }

        // Scale up
        elapsed = 0f;
        while (elapsed < duration)
        {
            transform.localScale = Vector3.Lerp(smallerScale, biggerScale, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }

        // Scale back
        elapsed = 0f;
        while (elapsed < duration)
        {
            transform.localScale = Vector3.Lerp(biggerScale, originalScale, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }

        // Snap perfectly back to original
        transform.localScale = originalScale;

        isBouncing = false;
        done = true;
    }
}

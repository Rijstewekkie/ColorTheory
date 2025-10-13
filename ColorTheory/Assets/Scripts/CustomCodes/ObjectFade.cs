using System.Collections;
using UnityEngine;

public class ObjectFade : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    private Color originalColor;

    private float from = 0f;
    private float time = 1f;
    private float to = 1f;

    void Start()
    {
        originalColor = spriteRenderer.color;
        StartCoroutine(StartFade());
    }


    private IEnumerator StartFade()
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

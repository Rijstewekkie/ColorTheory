using UnityEngine;
using System.Collections;

public class S_FadeOpacity : MonoBehaviour
{
    [Tooltip("Duration of one fade-in/out cycle.")]
    [SerializeField] private float duration = 1f;

    private SpriteRenderer spriteRenderer;
    private Color originalColor;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;

        StartCoroutine(FadeLoop());
    }

    private void Update()
    {
        if (this.transform.parent.GetComponent<TriggerObject>().Colored == true)
        {
            if (this.gameObject.name == "CurtainMoveableColorless_0 (1)")
            {
                Transform OtherCurtain = this.transform.parent.transform.parent.transform.Find("CurtainMoveableColorless_1");
                OtherCurtain.gameObject.GetComponent<TriggerObject>().Colored = true;
            }
            else if (this.gameObject.name == "CurtainMoveableColorless_1 (1)")
            {
                Transform OtherCurtain = this.transform.parent.transform.parent.transform.Find("CurtainMoveableColorless_0");
                OtherCurtain.gameObject.GetComponent<TriggerObject>().Colored = true;
            }
            else { }
            
                Destroy(gameObject);
        }
    }

    private IEnumerator FadeLoop()
    {
        while (true)
        {
            // Fade out (alpha 1 → 0)
            yield return StartCoroutine(FadeAlpha(1f, 0f, duration / 2f));

            // Fade in (alpha 0 → 1)
            yield return StartCoroutine(FadeAlpha(0f, 1f, duration / 2f));
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

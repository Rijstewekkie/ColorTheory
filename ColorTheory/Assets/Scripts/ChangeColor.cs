using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;

    public List<string> colors = new List<string> { "white", "black" };

    [Header("float")]

    public float colldown = 0.3f;
    [SerializeField] private float nowCollTime = 0f;

    [Header("bool")]

    /// <summary>
    /// true is don't change color, 
    /// false is can change color
    /// </summary>
    [SerializeField] bool colldownCheck = false;

    public enum BulletColor
    {
        white,
        black,
        red,
        blue,
        green,
    }

    [Header("enum")]

    [SerializeField] private BulletColor bulletColor;

    private void Start()
    {
        ColorAbility();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!colldownCheck)
            {
                ChangeToNextAvailableColor();
                colldownCheck = true;
            }
            else
            {
                Debug.Log("Now is colldown");
            }

        }
        Colldown();
    }

    private void ColorAbility()
    {
        switch (bulletColor)
        {
            case BulletColor.red:
                spriteRenderer.color = Color.red;
                // Ability here
                break;
            case BulletColor.green:
                spriteRenderer.color = Color.green;
                // Ability here
                break;
            case BulletColor.blue:
                spriteRenderer.color = Color.blue;
                // Ability here
                break;
            case BulletColor.white:
                spriteRenderer.color = Color.white;
                // Ability here
                break;
            case BulletColor.black:
                spriteRenderer.color = Color.black;
                // Ability here
                break;
        }
    }







    private void ChangeToNextAvailableColor()
    {
        string currentColorName = bulletColor.ToString();
        int currentIndex = colors.IndexOf(currentColorName);
        int nextIndex = (currentIndex + 1) % colors.Count;
        string nextColorName = colors[nextIndex];
        if (System.Enum.TryParse<BulletColor>(nextColorName, out var nextBulletColor))
        {
            bulletColor = nextBulletColor;
            ColorAbility();
        }
    }

    private void Colldown()
    {
        if (colldownCheck)
        {
            nowCollTime += Time.deltaTime;
            if (nowCollTime >= colldown)
            {
                colldownCheck = false;
                nowCollTime = 0f;
            }
        }
    }
}

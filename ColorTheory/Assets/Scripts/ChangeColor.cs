using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;

    public enum NowColor
    {
        red,
        green,
        blue,
        purple,
        yellow,
        orange,
    }

    [Header("enum")]

    public NowColor nowColor;

    private void Start()
    {

    }

    void Update()
    {
        FollowMouse();
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            TouchCheck(touchPos);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            TouchCheck(mousePos);
        }
    }

    private void FollowMouse()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.gameObject.transform.position = mousePos;
    }

    private void TouchCheck(Vector2 opsition)
    {
        RaycastHit2D hit = Physics2D.Raycast(opsition, Vector2.zero);
        if (hit.collider != null)
        {
            if (hit.collider.CompareTag(Colors.RedCan))
            {
                TouchRedCan();
            } else
            if (hit.collider.CompareTag(Colors.OrangeCan))
            {
                TouchOrangeCan();
            } else
            if (hit.collider.CompareTag(Colors.YellowCan))
            {
                TouchYellowCan();
            } else
            if (hit.collider.CompareTag(Colors.GreenCan))
            {
                TouchGreenCan();
            } else
            if (hit.collider.CompareTag(Colors.BlueCan))
            {
                TouchBlueCan();
            } else
            if (hit.collider.CompareTag(Colors.PurpleCan))
            {
                TouchPurpleCan();
            } else
            if (hit.collider.CompareTag("TriggerObject"))
            {
                DrawColor(hit);
            }
        }
        else
        {
            Debug.Log("no hit");
        }
    }

    private void TouchRedCan()
    {
        nowColor = NowColor.red;
        spriteRenderer.color = new Color(0.9529412f, 0.1764706f, 0.2862745f);
    }

    private void TouchOrangeCan()
    {
        nowColor = NowColor.orange;
        spriteRenderer.color = new Color(0.9490196f, 0.4509804f, 0.1803922f);
    }

    private void TouchYellowCan()
    {
        nowColor = NowColor.yellow;
        spriteRenderer.color = Color.yellow;
    }

    private void TouchGreenCan()
    {
        nowColor = NowColor.green;
        spriteRenderer.color = Color.green;
    }

    private void TouchBlueCan()
    {
        nowColor = NowColor.blue;
        spriteRenderer.color = new Color(0.1803922f, 0.7294118f, 0.9490196f);
    }

    private void TouchPurpleCan()
    {
        nowColor = NowColor.purple;
        spriteRenderer.color = new Color(0.8313726f, 0.1803922f, 0.9490196f);
    }

    private void DrawColor(RaycastHit2D hitObject)
    {
        TriggerObject trigger = hitObject.collider.gameObject.GetComponent<TriggerObject>();
        trigger.CheckColor(nowColor.ToString());
    }

}

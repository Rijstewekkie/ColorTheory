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
        spriteRenderer.color = Color.red;
    }

    private void TouchOrangeCan()
    {
        nowColor = NowColor.orange;
        spriteRenderer.color = new Color(1f, 0.5f, 0f);
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
        spriteRenderer.color = Color.blue;
    }

    private void TouchPurpleCan()
    {
        nowColor = NowColor.purple;
        spriteRenderer.color = new Color(0.5f, 0f, 1f);
    }

    private void DrawColor(RaycastHit2D hitObject)
    {
        TriggerObject trigger = hitObject.collider.gameObject.GetComponent<TriggerObject>();
        trigger.CheckColor(nowColor.ToString());
    }

}

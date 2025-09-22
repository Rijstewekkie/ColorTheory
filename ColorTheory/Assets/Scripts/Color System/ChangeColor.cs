using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private GetColor getColor;
    [SerializeField] private SpriteRenderer spriteRenderer;

    public enum NowColor
    {
        None,
        red,
        orange,
        yellow,
        green,
        blue,
        purple,
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
        } else
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
            if (hit.collider.gameObject.GetComponent<HideCan>())
            {
                hit.collider.gameObject.GetComponent<HideCan>().hideObject();
            }
            if (hit.collider.CompareTag(Colors.RedCan))
            {
                TouchRedCan();
                getColor.GetRedColor();
            } else
            if (hit.collider.CompareTag(Colors.OrangeCan))
            {
                TouchOrangeCan();
            } else
            if (hit.collider.CompareTag(Colors.YellowCan))
            {
                TouchYellowCan();
                getColor.GetYellowColor();
            } else
            if (hit.collider.CompareTag(Colors.GreenCan))
            {
                TouchGreenCan();
                getColor.GetGreenColor();
            } else
            if (hit.collider.CompareTag(Colors.BlueCan))
            {
                TouchBlueCan();
                getColor.GetBlueColor();
            }
            else
            if (hit.collider.CompareTag(Colors.PurpleCan))
            {
                TouchPurpleCan();
            } else
            if (hit.collider.CompareTag("TriggerObject"))
            {
                DrawColor(hit);
            }
        }
    }

    public void TouchRedCan()
    {
        nowColor = NowColor.red;
        spriteRenderer.color = Colors.redColor;
    }

    public void TouchOrangeCan()
    {
        nowColor = NowColor.orange;
        spriteRenderer.color = Colors.orangeColor;
    }

    public void TouchYellowCan()
    {
        nowColor = NowColor.yellow;
        spriteRenderer.color = Colors.yellowColor;
    }

    public void TouchGreenCan()
    {
        nowColor = NowColor.green;
        spriteRenderer.color = Colors.greenColor;
    }

    public void TouchBlueCan()
    {
        nowColor = NowColor.blue;
        spriteRenderer.color = Colors.blueColor;
    }

    public void TouchPurpleCan()
    {
        nowColor = NowColor.purple;
        spriteRenderer.color = Colors.purpleColor;
    }

    private void DrawColor(RaycastHit2D hitObject)
    {
        TriggerObject trigger = hitObject.collider.gameObject.GetComponent<TriggerObject>();
        trigger.CheckColor(nowColor.ToString());
    }

}

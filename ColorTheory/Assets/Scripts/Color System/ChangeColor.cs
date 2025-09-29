using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

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
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                TouchCheck(touchPos);
            }
        }
        else
        if (Input.GetMouseButtonDown(0))
        {
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                TouchCheck(mousePos);
            }
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
            if (hit.collider.CompareTag(Colors.RedBucket))
            {
                TouchRedBucket();
                getColor.GetRedColor();
            }
            else
            if (hit.collider.CompareTag(Colors.OrangeBucket))
            {
                TouchOrangeBucket();
            }
            else
            if (hit.collider.CompareTag(Colors.YellowBucket))
            {
                TouchYellowBucket();
                getColor.GetYellowColor();
            }
            else
            if (hit.collider.CompareTag(Colors.GreenBucket))
            {
                TouchGreenBucket();
                getColor.GetGreenColor();
            }
            else
            if (hit.collider.CompareTag(Colors.BlueBucket))
            {
                TouchBlueBucket();
                getColor.GetBlueColor();
            }
            else
            if (hit.collider.CompareTag(Colors.PurpleBucket))
            {
                TouchPurpleBucket();
            }
            else
            if (hit.collider.CompareTag("TriggerObject"))
            {
                DrawColor(hit);
            }
        }
    }

    public void TouchRedBucket()
    {
        nowColor = NowColor.red;
        spriteRenderer.color = Colors.redColor;
    }

    public void TouchOrangeBucket()
    {
        nowColor = NowColor.orange;
        spriteRenderer.color = Colors.orangeColor;
    }

    public void TouchYellowBucket()
    {
        nowColor = NowColor.yellow;
        spriteRenderer.color = Colors.yellowColor;
    }

    public void TouchGreenBucket()
    {
        nowColor = NowColor.green;
        spriteRenderer.color = Colors.greenColor;
    }

    public void TouchBlueBucket()
    {
        nowColor = NowColor.blue;
        spriteRenderer.color = Colors.blueColor;
    }

    public void TouchPurpleBucket()
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

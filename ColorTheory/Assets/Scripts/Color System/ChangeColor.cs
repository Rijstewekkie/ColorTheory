using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private GetColor getColor;
    [SerializeField] private SpriteRenderer spriteRenderer;

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip touchSound;

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
        RaycastHit2D[] hit = Physics2D.RaycastAll(opsition, Vector2.zero);
        if (hit.Length != 0)
        {
            System.Array.Sort(hit, (a, b) =>
            {
                int orderA = a.collider.GetComponent<SpriteRenderer>().sortingOrder;
                int orderB = b.collider.GetComponent<SpriteRenderer>().sortingOrder;
                return orderB.CompareTo(orderA);
            });
            RaycastHit2D frontHit = hit[0];
            if (frontHit.collider.gameObject.GetComponent<HideCan>())
            {
                if (frontHit.collider.CompareTag(Colors.RedBucket))
                {
                    TouchRedBucket();
                    getColor.GetRedColor();
                }
                else
                if (frontHit.collider.CompareTag(Colors.OrangeBucket))
                {
                    TouchOrangeBucket();
                }
                else
                if (frontHit.collider.CompareTag(Colors.YellowBucket))
                {
                    TouchYellowBucket();
                    getColor.GetYellowColor();
                }
                else
                if (frontHit.collider.CompareTag(Colors.GreenBucket))
                {
                    TouchGreenBucket();
                    getColor.GetGreenColor();
                }
                else
                if (frontHit.collider.CompareTag(Colors.BlueBucket))
                {
                    TouchBlueBucket();
                    getColor.GetBlueColor();
                }
                else
                if (frontHit.collider.CompareTag(Colors.PurpleBucket))
                {
                    TouchPurpleBucket();
                }
                frontHit.collider.gameObject.GetComponent<HideCan>().hideObject();
            }

            if (frontHit.collider.CompareTag("TriggerObject"))
            {
                DrawColor(frontHit);
                audioSource.PlayOneShot(touchSound);
            }
        }
        else
        {
            return;
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

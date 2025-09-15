using UnityEngine;

public class TriggerObject : MonoBehaviour
{
    [SerializeField] private SpriteRenderer[] spriteRenderer;
    [SerializeField] private GameObject triggerthings;

    public bool triggerOn = false;

    public enum TriggerColor
    {
        red,
        orange,
        yellow,
        green,
        blue,
        purple,
    }


    [SerializeField] private TriggerColor triggerColor;


    public void CheckColor(string enumName)
    {
        if (triggerColor.ToString() == enumName)
        {
            triggerOn = true;
            ChangeColor(enumName);
            TriggerEnter();
        }
        else if (triggerColor.ToString() != enumName)
        {
            ChangeColor(enumName);
        }
    }

    public void TriggerEnter()
    {
        if (triggerthings.GetComponent<Next>())
        {
            Next next = triggerthings.GetComponent<Next>();
            next.NextThings();
        } //else
        //if (triggerthings.GetComponent<windthing>())
        //{
        //    windthing wind = triggerthings.GetComponent<windthing>();
        //    //wind.SorryTest();
        //}
    }


    private void ChangeColor(string color)
    {
        for (int i = 0; i < spriteRenderer.Length; i++)
        {
            if (color == Colors.Red)
            {
                spriteRenderer[i].color = Colors.RedColor;
            }
            else if (color == Colors.Orange)
            {
                spriteRenderer[i].color = Colors.OrangeColor;
            }
            else if (color == Colors.Yellow)
            {
                spriteRenderer[i].color = Color.yellow;
            }
            else if (color == Colors.Green)
            {
                spriteRenderer[i].color = Color.green;
            }
            else if (color == Colors.Blue)
            {
                spriteRenderer[i].color = Colors.BlueColor;
            }
            else if (color == Colors.Purple)
            {
                spriteRenderer[i].color = Colors.PurpleColor;
            }
        }
    }
}

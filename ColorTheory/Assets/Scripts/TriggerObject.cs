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
        if(triggerColor.ToString() == enumName)
        {
            triggerOn = true;
            ChangeColor(enumName);
            TriggerEnter();
        }
        else if(triggerColor.ToString() != enumName)
        {
            ChangeColor(enumName);
        }
    }

    public void TriggerEnter()
    {
        Next next = triggerthings.GetComponent<Next>();
        next.NextThings();
    }


    private void ChangeColor(string color)
    {
        for(int i = 0; i < spriteRenderer.Length; i++)
        {
            if (color == Colors.Red)
            {
                spriteRenderer[i].color = new Color(0.9529412f, 0.1764706f, 0.2862745f);
            }
            else if (color == Colors.Orange)
            {
                spriteRenderer[i].color = new Color(0.9490196f, 0.4509804f, 0.1803922f);
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
                spriteRenderer[i].color = new Color(0.1803922f, 0.7294118f, 0.9490196f);
            }
            else if (color == Colors.Purple)
            {
                spriteRenderer[i].color = new Color(0.8313726f, 0.1803922f, 0.9490196f);
            }
        }
    }
}

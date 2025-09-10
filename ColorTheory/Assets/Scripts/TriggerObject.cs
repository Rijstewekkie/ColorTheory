using UnityEngine;

public class TriggerObject : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    public enum TriggerColor
    {
        red,
        orange,
        yellow,
        green,
        blue,
        purple,
    }

    //public ChangeColor changeColor;

    [SerializeField] private TriggerColor triggerColor;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void CheckColor(string enumName)
    {
        if(triggerColor.ToString() == enumName)
        {
            ChangeColor(enumName);
            OnTrigger();
        }
        else if(triggerColor.ToString() != enumName)
        {
            ChangeColor(enumName);
        }
    }

    private void OnTrigger()
    {
        Debug.Log("YEPIII");
    }


    private void ChangeColor(string color)
    {
        if(color == Colors.Red)
        {
            spriteRenderer.color = Color.red;
        }
        else if(color == Colors.Orange)
        {
            spriteRenderer.color = new Color(1f, 0.5f, 0f);
        }
        else if(color == Colors.Yellow)
        {
            spriteRenderer.color = Color.yellow;
        }
        else if(color == Colors.Green)
        {
            spriteRenderer.color = Color.green;
        }
        else if(color == Colors.Blue)
        {
            spriteRenderer.color = Color.blue;
        }
        else if(color == Colors.Purple)
        {
            spriteRenderer.color = new Color(0.5f, 0f, 1f);
        }
    }
}

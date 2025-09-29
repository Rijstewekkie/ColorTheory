using UnityEngine;

// Put this code in the object whose color you want to change and add 'Trigger Object' to the object tag.
// Put your sprite in SpriteRenderer and put the object that should be triggered when the color changes in 'triggerthings'
// Set the Trigger Color to the color you want it to work in.
// If you don't know, ask Seonghun.

public class TriggerObject : MonoBehaviour
{
    [SerializeField] private SpriteRenderer[] spriteRenderer;
    [SerializeField] private Next[] triggerthings;
    [SerializeField] private GameObject[] flashObejct;
 
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
            DestroyFlashObject();
        }
        else if (triggerColor.ToString() != enumName)
        {
            ChangeColor(enumName);
        }
    }

    public void TriggerEnter()
    {
        foreach (var thing in triggerthings)
        {
            thing.NextThings();
        }
    }

    private void DestroyFlashObject()
    {
        if (flashObejct == null)
        {
            return;
        }
        else
        {
            for (int i = 0; i < flashObejct.Length; i++)
            {
                flashObejct[i].SetActive(false);
                Destroy(flashObejct[i]);
            }
        }
    }


    private void ChangeColor(string color)
    {
        for (int i = 0; i < spriteRenderer.Length; i++)
        {
            if (color == Colors.red)
            {
                spriteRenderer[i].color = Colors.redColor;
            }
            else if (color == Colors.orange)
            {
                spriteRenderer[i].color = Colors.orangeColor;
            }
            else if (color == Colors.yellow)
            {
                spriteRenderer[i].color = Colors.yellowColor;
            }
            else if (color == Colors.green)
            {
                spriteRenderer[i].color = Colors.greenColor;
            }
            else if (color == Colors.blue)
            {
                spriteRenderer[i].color = Colors.blueColor;
            }
            else if (color == Colors.purple)
            {
                spriteRenderer[i].color = Colors.purpleColor;
            }
        }
    }


}

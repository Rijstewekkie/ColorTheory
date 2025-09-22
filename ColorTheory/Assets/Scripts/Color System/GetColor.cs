using UnityEngine;

public class GetColor : MonoBehaviour
{
    /// <summary>
    /// 0 = red, 1 = orange, 2 = yellow, 3 = green, 4 = blue, 5 = purple
    /// </summary>
    [SerializeField] private GameObject[] colorUI;








    public void GetRedColor()
    {
        colorUI[0].SetActive(true);
    }

    public void GetYellowColor()
    {
        colorUI[2].SetActive(true);
    }

    public void GetGreenColor()
    {
        colorUI[3].SetActive(true);
    }

    public void GetBlueColor()
    {
        colorUI[4].SetActive(true);
    }

}
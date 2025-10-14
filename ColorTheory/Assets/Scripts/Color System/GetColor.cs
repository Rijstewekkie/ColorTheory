using UnityEngine;

public class GetColor : MonoBehaviour
{
    /// <summary>
    /// 0 = red, 1 = yellow, 2 = blue, 3 = purple, 4 = green
    /// </summary>
    [SerializeField] private GameObject[] colorUI;








    public void GetRedColor()
    {
        colorUI[0].SetActive(true);
    }

    public void GetBlueColor()
    {
        colorUI[1].SetActive(true);
    }

    public void GetYellowColor()
    {
        colorUI[2].SetActive(true);
    }

    public void GetPurpleColor()
    {
        colorUI[3].SetActive(true);
    }

    public void GetGreenColor()
    {
        colorUI[4].SetActive(true);
    }

}
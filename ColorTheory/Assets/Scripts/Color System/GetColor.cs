using UnityEngine;

public class GetColor : MonoBehaviour
{
    /// <summary>
    /// 0 = Red, 1 = Orange, 2 = Yellow, 3 = Green, 4 = Blue, 5 = Purple
    /// </summary>
    [SerializeField] private GameObject[] ColorUI;








    public void GetRedColor()
    {
        ColorUI[0].SetActive(true);
    }

    public void GetYellowColor()
    {
        ColorUI[2].SetActive(true);
    }

    public void GetGreenColor()
    {
        ColorUI[3].SetActive(true);
    }

    public void GetBlueColor()
    {
        ColorUI[4].SetActive(true);
    }

}
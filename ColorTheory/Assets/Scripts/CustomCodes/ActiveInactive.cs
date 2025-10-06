using UnityEngine;

public class ActiveInactive : CustomCode
{
    [SerializeField] private GameObject[] objectToActiveInactive;
    protected override void Codes()
    {
         for (int i = 0; i < objectToActiveInactive.Length; i++)
         {
             if (objectToActiveInactive[i].activeInHierarchy)
             {
                 objectToActiveInactive[i].SetActive(false);
             }
             else
             {
                 objectToActiveInactive[i].SetActive(true);
             }
        }
    }
}

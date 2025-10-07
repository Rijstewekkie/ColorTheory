using System.Collections;
using UnityEngine;

public class ActiveInactive : CustomCode
{
    [SerializeField] private GameObject[] objectToActiveInactive;
    [SerializeField] private float delayTime = 1f;

    protected override void Codes()
    {
         for (int i = 0; i < objectToActiveInactive.Length; i++)
         {
             if (objectToActiveInactive[i].activeInHierarchy)
             {
                StartCoroutine(Wait(i));
            }
             else
             {
                 objectToActiveInactive[i].SetActive(true);
             }
        }
    }

    private IEnumerator Wait(int i)
    {
        yield return new WaitForSeconds(delayTime);
        objectToActiveInactive[i].SetActive(false);
    }
}

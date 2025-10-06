using UnityEngine;

public class UnlockableObject : MonoBehaviour
{
    //Drag the CountingObject script onto every object that counts towards unlocking this object.

    [SerializeField] private int objectsNeededToUnlock = 0;
    [SerializeField] private GameObject FlashObject;

    public int objectsCounted = 0;
    void Start()
    {
        FlashObject.SetActive(false);
        this.gameObject.GetComponent<TriggerObject>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (objectsCounted >= objectsNeededToUnlock)
        {
            FlashObject.SetActive(true);
            this.gameObject.GetComponent<TriggerObject>().enabled = true;
        
        }
    }
}

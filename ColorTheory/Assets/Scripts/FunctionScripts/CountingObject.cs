using UnityEngine;

public class CountingObject : Next
{
    public UnlockableObject unlockableObject;

    protected override void NextCode()
    {
        unlockableObject.objectsCounted += 1;
    }
}

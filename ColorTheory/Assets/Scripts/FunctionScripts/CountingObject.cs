using UnityEngine;

public class CountingObject : Next
{
    public UnlockableObject unlockableObject;

    private bool counted = false;

    protected override void NextCode()
    {
        if (counted) return;
        unlockableObject.objectsCounted += 1;
        counted = true;
    }
}

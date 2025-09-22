using UnityEngine;

public abstract class CustomCode : Next
{

    protected override void NextCode()
    {
        Codes();
        done = true;
    }

    // Custom code add here
    protected abstract void Codes();
}

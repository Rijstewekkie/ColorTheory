using UnityEngine;

public abstract class CustomCode : Next
{
    // Custom code add here

    protected override void NextCode()
    {
        Codes();
        done = true;
    }

    protected abstract void Codes();
}

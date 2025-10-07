using UnityEngine;

public class DeleteOnColor : CustomCode
{
    protected override void Codes()
    {
        Destroy(this.gameObject);
        done = true;
    }
}

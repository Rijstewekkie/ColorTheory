using UnityEngine;

public class EndGame : CustomCode
{
    protected override void Codes()
    {
        PokiUnitySDK.Instance.gameplayStop();
    }
}

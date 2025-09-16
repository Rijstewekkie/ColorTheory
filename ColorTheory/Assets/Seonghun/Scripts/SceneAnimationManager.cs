using UnityEngine;

public class SceneAnimationManager : MonoBehaviour
{
    [SerializeField] private Next[] nextScripts;
    [SerializeField] int i = 0;

    private void Update()
    {
        NextCode();
    }

    public interface OnNext
    {
        void NextThings();
    }

    public void NextCode()
    {
        if (nextScripts[i].done)
        {
            i++;
        }
    }


}

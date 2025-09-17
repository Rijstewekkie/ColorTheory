using UnityEngine;

public class SceneAnimationManager : MonoBehaviour
{
    [SerializeField] private Next[] nextScripts;
    [SerializeField] private int i = 0;

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
        if (i < nextScripts.Length)
        {
            if (nextScripts[i].done)
            {
                i++;
            }
        }
        else
        {
            return;
        }
        
    }


}

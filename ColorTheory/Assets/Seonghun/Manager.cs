using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] private Next[] nextScripts;
    [SerializeField] int i = 0;
    
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

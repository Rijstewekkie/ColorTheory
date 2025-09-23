using UnityEngine;

public class S_AudioManager : MonoBehaviour
{
    public AudioSource triggerSource;
    public AudioClip[] soundList;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            triggerSource.PlayOneShot(soundList[0]);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            triggerSource.PlayOneShot(soundList[1]);
        }

    }


}

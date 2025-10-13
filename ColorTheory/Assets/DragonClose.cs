using UnityEngine;

public class DragonClose : MonoBehaviour
{
    public ShowAnimetion showAnimetion;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            showAnimetion.tirggerName = "close";
            showAnimetion.NextAnimation();
        }
    }
}

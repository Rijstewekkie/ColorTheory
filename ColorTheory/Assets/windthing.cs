using UnityEngine;
using TMPro;

public class windthing : MonoBehaviour
{

    public TextMeshProUGUI SpinningText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpinningText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>().Drop();

            SpinningText.enabled = true;
        }
    }
}

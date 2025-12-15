using UnityEngine;
using TMPro;

public class PauseButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TMP_Text pauseText;
    public void OnPress()
    {
        if (Time.timeScale == 1)
        {
            pauseText.text = "RESUME";
            Time.timeScale = 0;
        }
        else
        {
            pauseText.text = "PAUSE";
            Time.timeScale = 1;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

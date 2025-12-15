using UnityEngine;
using UnityEngine.TMPro;

public class PauseButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public 
    public void OnPress()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else
        {
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

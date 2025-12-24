using UnityEngine;
using TMPro;

public class PauseButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TMP_Text pauseText;
    public GameObject pauseMenuMask;
    public void Awake()
    {
        pauseMenuMask.SetActive(false);
        Time.timeScale = 1;
    }
    public void OnPress()
    {
        if (Time.timeScale == 1)
        {
            pauseMenuMask.SetActive(true);
            pauseText.text = "RESUME";
            Time.timeScale = 0;
        }
        else
        {
            pauseMenuMask.SetActive(false);
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

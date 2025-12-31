using UnityEngine;
using UnityEngine.SceneManagement;

public class playButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Play()
    {
        SceneManager.LoadScene("Level_1");
    }
}
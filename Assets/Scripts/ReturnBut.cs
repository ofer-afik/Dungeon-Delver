using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnBut : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void OnPress()
    {
        SceneManager.LoadScene("StartScene");
        GameManager.Instance.dead = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

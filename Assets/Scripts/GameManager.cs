using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static GameManager Instance;
    public int coins;
    public int EnemiesKilled;
    public float PlayerHP = 100f;
    public bool dead = false;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dead == true)
        {
            if (SceneManager.GetActiveScene().name != "GameOver")
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}

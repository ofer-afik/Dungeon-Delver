using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class DoorControl : MonoBehaviour
{
    private TilemapRenderer tr;
    private TilemapCollider2D col;
    public string scene;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tr = GetComponent<TilemapRenderer>();
        col = GetComponent<TilemapCollider2D>();
        tr.enabled = false;
        col.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.EnemiesKilled >= 15)
        {
            tr.enabled = true;
            col.enabled = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.EnemiesKilled = 0;
            SceneManager.LoadScene(scene);
        }
    }
}
using UnityEngine;
using System.Collections;

public class BlueEnemyController : MonoBehaviour
{
    public float speed = 5f;
    public GameObject player;
    private Rigidbody2D rb;
    private float playerX;
    private float playerY;
    public Animator anim;
    private Vector2 direction;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
    }

    void FixedUpdate()
    {
        direction = (player.transform.position - transform.position).normalized;
        rb.linearVelocity = direction * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Fireball"))
        {
            Instantiate(Resources.Load("Blue Death (No flash)"), transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
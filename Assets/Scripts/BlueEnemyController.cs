using UnityEngine;

public class BlueEnemyController : MonoBehaviour
{
    public float speed = 5f;
    public GameObject player;
    private Rigidbody2D rb;
    private float playerX;
    private float playerY;
    private Vector2 direction;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
    }

    void FixedUpdate()
    {
        playerX = player.transform.position.x;
        playerY = player.transform.position.y;
        if (Mathf.Abs(playerX - transform.position.x) > Mathf.Abs(playerY - transform.position.y))
        {
            if (playerX > transform.position.x)
            {
                // Move right
                direction = new Vector2(1, 0);
            }
            else
            {
                // Move left
                direction = new Vector2(-1, 0);
            }
        }
        else
        {
            if (playerY > transform.position.y)
            {
                // Move up
                direction = new Vector2(0, 1);
            }
            else
            {
                // Move down
                direction = new Vector2(0, -1);
            }
        }
        rb.linearVelocity = direction * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Fireball"))
        {
            Destroy(this.gameObject);
        }
    }
}
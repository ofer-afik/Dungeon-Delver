using UnityEngine;
using System.Collections;

public class fireControl : MonoBehaviour
{
    public char dir;
    public GameObject explode;
    public float speed = 5f;
    public Rigidbody2D rb;
    IEnumerator WaitForDir()
    {
        rb = GetComponent<Rigidbody2D>();
        yield return new WaitUntil(() => dir == 'u' || dir == 'd' || dir == 'l' || dir == 'r');
        if (dir == 'u')
        {
            rb.linearVelocity = new Vector2(0, 1) * speed;
        }
        else if (dir == 'd')
        {
            rb.linearVelocity = new Vector2(0, -1) * speed;
        }
        else if (dir == 'l')
        {
            rb.linearVelocity = new Vector2(-1, 0) * speed;
        }
        else if (dir == 'r')
        {
            rb.linearVelocity = new Vector2(1, 0) * speed;
        }
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(WaitForDir());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Map"))
        {
            Instantiate(explode, transform.position, Quaternion.Euler(0, 0, 0));
            Destroy(this.gameObject);
        }
    }
}
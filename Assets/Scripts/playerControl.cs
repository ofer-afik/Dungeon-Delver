using UnityEngine;
using System.Collections;

public class playerControl : MonoBehaviour
{
    public float speed = 0.5f;
    private float x;
    private float y;
    public Rigidbody2D rb;
    public GameObject arrows;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        arrows.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(fire());
        }
    }

    void FixedUpdate()
    {
        x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(x, y, 0);
        if (x != 0)
        {
            transform.localScale = new Vector3(Mathf.Sign(x * -1), 1, 1);
        }

    }

    IEnumerator fire()
    {
        arrows.SetActive(true);
        while (Input.GetAxis("Horizontal") == 0 || Input.GetAxis("Vertical") == 0)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                arrows.SetActive(false);
                yield break;
            }
            else
            {
                yield return null;
            }
        }
        arrows.SetActive(false);
        yield break;
    }
}
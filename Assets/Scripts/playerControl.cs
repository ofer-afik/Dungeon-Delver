using UnityEngine;

public class playerControl : MonoBehaviour
{
    public float speed = 10f;
    private float x;
    private float y;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(x, y, 0);
    }
}

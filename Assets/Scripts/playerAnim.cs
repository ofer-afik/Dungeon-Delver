using UnityEngine;

public class playerAnim : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Animator anim;
    private float x;
    private float y;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        bool isMoving = x != 0 || y != 0;
        anim.SetBool("1_Move", isMoving);
    }
}

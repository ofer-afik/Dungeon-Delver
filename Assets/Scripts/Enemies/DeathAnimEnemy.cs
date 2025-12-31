using UnityEngine;

public class DeathAnimEnemy : MonoBehaviour
{
    public void EndAnim()
    {
        Destroy(gameObject);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("DeathAnimEnemy attached to: " + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

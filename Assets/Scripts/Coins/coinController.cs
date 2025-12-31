using UnityEngine;

public class coinController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject coinCollectEffect;
    void Start()
    {
        coinCollectEffect = Resources.Load<GameObject>("CoinCollect");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(coinCollectEffect, transform.position, Quaternion.identity);
            GameManager.Instance.coins += 1;
            Destroy(gameObject);
        }
    }
}

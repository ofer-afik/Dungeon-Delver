using UnityEngine;
using TMPro;

public class CoinNum : MonoBehaviour
{
    public TextMeshProUGUI Text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = GameManager.Instance.coins.ToString();
    }
}

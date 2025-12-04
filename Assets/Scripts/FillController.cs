using UnityEngine;
using UnityEngine.UI;

public class FillController : MonoBehaviour
{
    private Image fillImage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fillImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        fillImage.fillAmount = GameManager.Instance.EnemiesKilled / 20f;  }
}

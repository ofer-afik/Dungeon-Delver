using UnityEngine;
using UnityEngine.UI;

public class HPControl : MonoBehaviour
{
    private Image hpImage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hpImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        hpImage.fillAmount = GameManager.Instance.PlayerHP / 100f;
    }
}

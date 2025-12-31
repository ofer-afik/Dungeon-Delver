using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FillController : MonoBehaviour
{
    private Image fillImage;
    public float fillSpeed = 0.4f;
    private Coroutine fillCoroutine;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fillImage = GetComponent<Image>();
        fillImage.fillAmount = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (fillImage.fillAmount < (GameManager.Instance.EnemiesKilled / 15f) && fillCoroutine == null)
        {
            fillCoroutine = StartCoroutine(Fill());
        }
    }

    private IEnumerator Fill()
    {
        float targetFill = GameManager.Instance.EnemiesKilled / 15f;
        while (fillImage.fillAmount < targetFill)
        {
            fillImage.fillAmount += Mathf.Min(Time.deltaTime * fillSpeed, targetFill - fillImage.fillAmount);
            yield return null;
        }
        fillCoroutine = null;
    }
}
using UnityEngine;
using System;
using System.Collections;
using System.Linq;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] popUps;
    private int currentPopUpIndex = 0;
    private Func<bool>[] conditions;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        conditions = new Func<bool>[]
        {
            // Movement
            new Func<bool>(() => Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D)),
            // Shooting
            new Func<bool>(() => Input.GetKeyDown(KeyCode.Space)),
            new Func<bool>(() => Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D)),
            // Kill an enemy
            new Func<bool>(() => GameManager.Instance.EnemiesKilled >= 1),
        };
        StartCoroutine(RunTutorial());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator RunTutorial()
    {
        for (int i = 0; i < popUps.Length; i++)
        {
            popUps[i].SetActive(false);
        }
        yield return new WaitForSeconds(1f);
        for (int i = 0; i < popUps.Length; i++)
        {
            if (i == currentPopUpIndex)
            {
                popUps[i].SetActive(true);
            }
            else
            {
                popUps[i].SetActive(false);
            }
            currentPopUpIndex = i;
            if (i < conditions.Length)
            {
                yield return new WaitUntil(() => conditions[i]());
            }
            else
            {
                yield return new WaitForSeconds(3f);
            }
            currentPopUpIndex++;
        }
        for (int i = 0; i < popUps.Length; i++)
        {
            popUps[i].SetActive(false);
        }
        Destroy(gameObject);
    }
}
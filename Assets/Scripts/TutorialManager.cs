using UnityEngine;
using System;
using System.Collections;
using System.Linq;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] conditionalPopUps;
    public GameObject[] nonConditionalPopUps;
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

    IEnumerator NonConditionalPopUps()
    {
        for (int i = 0; i < nonConditionalPopUps.Length; i++)
        {
            for (int j = 0; j < nonConditionalPopUps.Length; j++)
            {
                nonConditionalPopUps[j].SetActive(false);
            }
            nonConditionalPopUps[i].SetActive(true);
            yield return new WaitForSeconds(2f);
        }
        for (int i = 0; i < nonConditionalPopUps.Length; i++)
        {
            nonConditionalPopUps[i].SetActive(false);
        }
        Destroy(this.gameObject);
    }

    IEnumerator RunTutorial()
    {
        for (int i = 0; i < nonConditionalPopUps.Length; i++)
        {
            nonConditionalPopUps[i].SetActive(false);
        }
        for (int i = 0; i < conditionalPopUps.Length; i++)
        {
            conditionalPopUps[i].SetActive(false);
        }

        for (int i = 0; i < conditionalPopUps.Length; i++)
        {
            conditionalPopUps[i].SetActive(true);
            // Wait until the condition is met
            yield return new WaitUntil(conditions[i]);
            conditionalPopUps[i].SetActive(false);
        }
        
        // Start nonconditional popups
        StartCoroutine(NonConditionalPopUps());
    }
}
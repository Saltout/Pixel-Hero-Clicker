using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarVisual : MonoBehaviour
{
    [SerializeField] private GameObject[] healthBarSprites;
    [SerializeField] private Enemy enemy;

    void Start()
    {
        enemy = GetComponent<Enemy>();

    }

    void Update()
    {
        HealthBarVisualiser();
    }

    private void HealthBarVisualiser()
    {
        switch (enemy.EnemyHealth)
        {
            case 5:
                healthBarSprites[0].SetActive(true);
                break;
            case 4:
                healthBarSprites[1].SetActive(true);
                healthBarSprites[0].SetActive(false);
                break;
            case 3:
                healthBarSprites[2].SetActive(true);
                healthBarSprites[1].SetActive(false);
                break;
            case 2:
                healthBarSprites[3].SetActive(true);
                healthBarSprites[2].SetActive(false);
                break;
            case 1:
                healthBarSprites[4].SetActive(true);
                healthBarSprites[3].SetActive(false);
                break;
            case 0:
                healthBarSprites[5].SetActive(true);
                healthBarSprites[4].SetActive(false);
                EnemyDie();
                break;
        }
    }
    private void EnemyDie()
    {
        if (enemy.EnemyHealth == 0)
        {
            Destroy(this.gameObject);
        }
    }
}

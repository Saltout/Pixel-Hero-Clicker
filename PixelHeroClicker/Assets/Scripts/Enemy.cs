using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int enemyHealth;

    public int EnemyHealth {get; set;}
    
    void Start()
    {
        EnemyHealth = 5;
        Debug.Log(EnemyHealth);
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
        {
            TakeDamage(1);
            Debug.Log(EnemyHealth);
        }
    }

    private void TakeDamage(int damage)
    {
        EnemyHealth = EnemyHealth - damage;
    }
}

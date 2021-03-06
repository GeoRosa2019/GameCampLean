using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
     float health = 0f;
    [SerializeField] float maxHealth = 5f;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0f)
        {
            Die();
        }
    }
    void Die()
    {
        Debug.Log("Enemy Died!");
        Destroy(gameObject);
    }
}

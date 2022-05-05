using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float speed = 3f;
    [SerializeField] private float attackDamage = 100f;
    [SerializeField] private float attackSpeed = 1f;
    private float canAttack;
    void Start()
    {
        //Set the tag of this GameObject to Player
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (other.gameObject.tag == "Enemy")
            {
                if (attackSpeed <= canAttack)
                {
                    other.gameObject.GetComponent<EnemyHealth>().UpdateHealth(-attackDamage);
                    canAttack = 0f;
                }
                else
                {
                    canAttack += Time.deltaTime;
                }
            }
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Transform attackPos;
    public float attackRange;
    public LayerMask whatIsEnemies;
    public float attackRate = 2f;
    float nextAttackTime = 0f;
    public int damage;

    public Animator _animate;

    void Start()
    {
        _animate = GetComponent<Animator>();
    }
    void Update()
    {
        if(Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _animate.SetTrigger("Attack");
                Collider2D[] enemies = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
                for (int i = 0; i < enemies.Length; i++)
                {
                    enemies[i].GetComponent<EnemyHealth>().TakeDamage(damage);
                }
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
}

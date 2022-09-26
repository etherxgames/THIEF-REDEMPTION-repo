using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceBehavior : MonoBehaviour
{

    public Animator _animate;
    public Transform attackPoint;
    public float attackRange;
    public LayerMask whatIsPlayer;
    public int damage;
    public float attackRate = 1f;
    float nextAttackTime = 0f;
    bool checkRange = false;
    private void Start()
    {
        _animate = GetComponent<Animator>();
    }
    private void Update()
    {

        if (checkRange)
        {
            if (Time.time >= nextAttackTime)
            {
                _animate.SetTrigger("Attack");
                Collider2D[] players = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, whatIsPlayer);
                for (int i = 0; i < players.Length; i++)
                {
                    players[i].GetComponent<PlayerHealth>().TakeDamage(damage);
                }
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D inRange)
    {
        if(inRange.gameObject.tag == "Player")
        {
            checkRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D inRange)
    {
        if(inRange.gameObject.tag == "Player")
        {
            checkRange= false;
        }
    }
    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
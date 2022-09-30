using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public Rigidbody2D _rb;
    public float maxHealth = 20f;
    public float currentHealth;
    public HealthBar healthBar;
    public bool isDead = false;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }


    void Update()
    {
        if (currentHealth <= 0)
            isDead = true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Spikes")
        {
            TakeDamage(5);
            _rb.AddForce(new Vector2(-3f, 30f), ForceMode2D.Impulse);
        }
    }

}

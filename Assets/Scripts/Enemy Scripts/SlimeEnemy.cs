using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeEnemy : Enemy
{
    public FloatValue playerHealth;
    public float damageAmount = 1f;
    public float playerAttackDamage = 1f;  // Default damage value

    [Header("Animator")]
    public Animator anim;

    [Header("Health Signal")]
    public Signal playerHealthSignal;

    // Start is called before the first frame update
    void Start()
    {
        currentState = EnemyState.idle;
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            playerHealth.RuntimeValue -= damageAmount;
            playerHealthSignal.Raise(); // Update health UI if necessary
        }
        else if (other.CompareTag("PlayerAttack"))  // Detect player attack
        {
            TakeDamage(playerAttackDamage);
        }
    }

    void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            DeathEffect();
            this.gameObject.SetActive(false);  // Kill the slime
        }
    }
}

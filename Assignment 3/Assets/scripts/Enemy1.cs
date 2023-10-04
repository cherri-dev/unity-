using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    [SerializeField] float health, maxHealth = 10f;

public Animator anim;
public bool isDie;

    private void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;

        if(health <= 0)
        {
            isDie = true;
            anim.SetTrigger("IsDie");
            // Destroy(gameObject);
        }

    }

}

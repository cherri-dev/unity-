using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField]private float startingHealth ;
    public float currentHealth { get; private set; }
    private Animator anim;
    public  bool dead;

    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
    }
    public void TakeDamage(float _damage)
    {
        currentHealth -= _damage;
        
        if (currentHealth > 0)
        {
            anim.SetTrigger("hurt");
        }
        else
        {
            anim.SetTrigger("die");
            dead = true;
        }
    }

    public void AddHp()
    {
        currentHealth++;
    }


}

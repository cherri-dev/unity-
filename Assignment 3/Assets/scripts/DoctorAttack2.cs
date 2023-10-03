using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoctorAttack2 : MonoBehaviour
{
    private GameObject attackArea = default;

    private bool attacking = false;

    public Animator _anim;
    private float timeToAttack = 0.25f;
    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        attackArea = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }

        if(attacking)
        {
            timer += Time.deltaTime;

            if(timer >= timeToAttack)
            {
            timer = 0;
            attacking = false;
            attackArea.SetActive(attacking);
            _anim.SetBool("isAttack5",false);
            }
        }
    }
    private void Attack()
    {
        attacking = true;
        attackArea.SetActive(attacking);
            _anim.SetBool("isAttack5",true);
            _anim.SetTrigger("isAttack6");
    }
}

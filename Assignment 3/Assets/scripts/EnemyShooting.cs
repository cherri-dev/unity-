using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;
    public Animator anim;
    private float timer;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(GetComponent<Enemy>().isDie)
        return;

        float distance = Vector2.Distance(transform.position, player.transform.position);

        timer += Time.deltaTime;
        if(timer > 5)
        {
            timer = 0;
            shoot();
        }
        
    }

    void shoot()
    {
        anim.SetTrigger("IsAttack2");
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }
}

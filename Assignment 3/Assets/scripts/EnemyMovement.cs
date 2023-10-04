using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public float moveSpeed;
    [SerializeField] private float damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Health>().TakeDamage(damage);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!GetComponent<Enemy>().isDie)
        {

        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, moveSpeed);
        }
    }
}

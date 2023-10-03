
using UnityEngine;

public class Health : MonoBehaviour
{
 [SerializeField] private float startingHealth;
 public float currentHealth{ get; private set; }
 private Animator anim;
 public GameObject[] Heart;

 private void Awake()
 {
    currentHealth = startingHealth;
    anim = GetComponent<Animator>();
 }

 public void TakeDamage(float _damage)
 {
    currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);
    Heart[(int)currentHealth].SetActive(false);

    if (currentHealth > 0)
    {
      anim.SetTrigger("hurt");
    }

    else
    {
      anim.SetTrigger("die");
    }
 }

 private void Update()
 {

 }
}

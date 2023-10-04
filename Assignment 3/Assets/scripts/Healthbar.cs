
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private Image totalhealthBar;  // Removed "health" prefix
    [SerializeField] private Image currenthealthBar;  // Removed "health" prefix

    private void Start()
    {
        totalhealthBar.fillAmount = playerHealth.currentHealth / 3;
    }

    private void Update()
    {
        currenthealthBar.fillAmount = playerHealth.currentHealth / 3;
    }








}


using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int SetMaxHealth  = 10;
    public int currentHealth;
    public GameObject Weapon;
    public GameObject Player;
    public PlayerHealthBar healthBar;

    void Start()
    {
        currentHealth = SetMaxHealth;
        healthBar.SetMaxHealth(SetMaxHealth);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Weapon)
        {
            currentHealth--;
            healthBar.setHealth(currentHealth);
        }
    }

    private void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(Player);
        }
    }
}

using UnityEngine;

public class Systems : MonoBehaviour
{
    [SerializeField]
    private BoxCollider2D boxCollider2D;

    [SerializeField]
    private Transform player;

    // Values for the player's health
    public int maxHealth = 2;
    public int currentHealth;
    public HealthBar healthBar;

    //Position of the SpawnPoint
    [SerializeField]
    public ReSpawn reSpawn;
    public RespawnAzaès respawnAzaès;

    //Dash Systems
    public WaterSystems waterSystems;

    //Score Systems
    public Score score;

    //Collectible Counter Systems
    public CollectibleCounter collectibleCounter;

    //Pause Menu
    public Canvas mainUI;
    public Canvas pauseMenu;
    


    void Start()
    {
        //Setup Health
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        //Setup UI
        mainUI.enabled = true;
        pauseMenu.enabled = false;
    }

    private void FixedUpdate()
    {
        //Follow the player
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);

        OnTriggerEnter2D(boxCollider2D);

        if (currentHealth <= 0)
        {
            respawnAzaès.BackToCheckpoint();
            transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
        }

        //Pause Button
        if (Input.GetKey(KeyCode.P))
        {
            mainUI.enabled = false;
            pauseMenu.enabled = true;
        }
    }


    // Consequences of collisions
    void OnTriggerEnter2D(Collider2D boxCollider2D)
    {
        if (boxCollider2D.CompareTag("Enemy"))
        {
            TakeDamage(1);
            Debug.Log("Hit Enemy");
        }
        if (boxCollider2D.CompareTag("Trap"))
        {
            TakeDamage(2);
            Debug.Log("Hit Trap");
        }
        if (boxCollider2D.CompareTag("Floor"))
        {
            Debug.Log("Is Touching Floor");
        }
        if (boxCollider2D.CompareTag("Checkpoint"))
        {
            reSpawn.ChangeRespawnPosition();
            FullHealth();
            Debug.Log("Healed");
        }
        if (boxCollider2D.CompareTag("DashUpgrade"))
        {
            waterSystems.AddMaxDash();
        }
        if (boxCollider2D.CompareTag("Pièce"))
        {
            score.AddCoin();
        }
        if (boxCollider2D.CompareTag("PartialUpgrade"))
        {
            collectibleCounter.AddCollectible();
        }

    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
    public void FullHealth()
    {
        currentHealth = 2;
        healthBar.SetHealth(currentHealth);
    }
}


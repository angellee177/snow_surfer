using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    [SerializeField] PowerUpSO powerUp;
    PlayerHandler player;
    SpriteRenderer spriteRenderer;
    float timeLeft;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = FindFirstObjectByType<PlayerHandler>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        timeLeft = powerUp.GetTime();
    }

    // Update is called once per frame
    void Update()
    {
        CountDownTimer();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Player");

        if(collision.gameObject.layer == layerIndex && spriteRenderer.enabled)
        {
            spriteRenderer.enabled = false;
            // activate the powerup
            player.ActivatePowerUp(powerUp);
        }
    }

    void CountDownTimer()
    {
        // only decrease the timeleft if the spriteRenderer is true and timeLeft > 0
        if (!spriteRenderer.enabled && timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;

            // Check if we just hit zero
            if (timeLeft <= 0)
            {
                timeLeft = 0; // Lock it at zero
                player.DeactivedPowerUp(powerUp);
            }
        }
    }
}

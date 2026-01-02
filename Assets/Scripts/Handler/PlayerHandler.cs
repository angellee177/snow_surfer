using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class PlayerHandler : MonoBehaviour
{
    [SerializeField] float torqueAmount;
    [SerializeField] float baseSpeed;
    [SerializeField] float maxSpeed;
    [SerializeField] float minSpeed;
    [SerializeField] float accelerationRate; // Speed added per second held
    [SerializeField] TextMeshProUGUI speedText;


    InputAction moveAction;
    Rigidbody2D playerRigidBody;
    SurfaceEffector2D surfaceEffector2D;
    ScoreManager scoreManager;

    Vector2 moveVector;
    public bool canControlPlayer = true;
    float previousRotation;
    float totalRotation;
    int flipCount;
    int speed;

    // calculate passive score only when player walk on the ground
    float passiveScore;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        playerRigidBody = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindFirstObjectByType<SurfaceEffector2D>();
        scoreManager = FindFirstObjectByType<ScoreManager>();

        surfaceEffector2D.speed = baseSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if(canControlPlayer)
        {
            moveVector = moveAction.ReadValue<Vector2>();

            RotatePlayer();
            BoostPlayer();
            CalculateFlips();
            HandlePassiveScore();
        }
    }

    void RotatePlayer()
    {
        // Remove the ReadValue line from here to keep it clean
        if (moveVector.x < 0)
        {
            playerRigidBody.AddTorque(torqueAmount);
        } 
        else if(moveVector.x > 0)
        {
            playerRigidBody.AddTorque(-torqueAmount);
        }
    }

    void BoostPlayer()
    {
        // handle up cursor
        if(moveVector.y > 0)
        {
            surfaceEffector2D.speed += accelerationRate * Time.deltaTime;
            print("speeding up!");
            print("current speed = " + surfaceEffector2D.speed.ToString());
        } else if(moveVector.y < 0) // handle down cursor
        {
            surfaceEffector2D.speed -= accelerationRate * Time.deltaTime;            
            print("slowing down!");
            print("current base speed = " + surfaceEffector2D.speed.ToString());
        };

        // Keep speed within reasonable bounds
        surfaceEffector2D.speed = Mathf.Clamp(surfaceEffector2D.speed, minSpeed, maxSpeed);
        speed = (int)surfaceEffector2D.speed;
        speedText.text = "Speed: " + speed + " km/h";
    }

    void HandlePassiveScore()
    {
        if(surfaceEffector2D.speed > 1f)
        {

            // Add time passed since last frame (e.g., 0.016s)
            passiveScore += Time.deltaTime;

            if (passiveScore >= 0.2f) 
            {
                scoreManager.AddScore(1);
                passiveScore = 0; // Reset timer for the next second
                print("Walking score added! +1");
            }

        }
    }

    void CalculateFlips()
    {
        float currentRotation = transform.eulerAngles.z;

        // Compare current to previous rotation
        float delta = Mathf.DeltaAngle(previousRotation, currentRotation);
        totalRotation += delta;

        // Using Mathf.Abs handles both +340 and -340 in one check
        if(Mathf.Abs(totalRotation) >= 340f)
        {
            flipCount += 1;
            totalRotation = 0;

            // Trigger the UI and Score update
            scoreManager.multipleScoreFromFlip(flipCount);
        }

        previousRotation = currentRotation;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Floor");

        // reset flip count if the player hit floor
        if(collision.gameObject.layer == layerIndex)
        {
            flipCount = 0;
            scoreManager.ResetFlipUI();
        }
    }

    public void DisableControls()
    {
        canControlPlayer = false;
    }
}

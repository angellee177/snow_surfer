using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerHandler : MonoBehaviour
{
    [SerializeField] float torqueAmount;
    [SerializeField] float baseSpeed;
    [SerializeField] float maxSpeed;
    [SerializeField] float minSpeed;
    [SerializeField] float accelerationRate; // Speed added per second held

    InputAction moveAction;
    Rigidbody2D playerRigidBody;
    SurfaceEffector2D surfaceEffector2D;

    Vector2 moveVector;
    public bool canControlPlayer = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        playerRigidBody = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindFirstObjectByType<SurfaceEffector2D>();

        surfaceEffector2D.speed = baseSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if(canControlPlayer)
        {
            RotatePlayer();
            BoostPlayer();
        }
    }

    void RotatePlayer()
    {
        moveVector = moveAction.ReadValue<Vector2>();
        if (moveVector.x < 0)
        {
            playerRigidBody.AddTorque(torqueAmount);
        } else if(moveVector.x > 0)
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
    }

    public void DisableControls()
    {
        canControlPlayer = false;
    }
}

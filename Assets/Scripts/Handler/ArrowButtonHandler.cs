using UnityEngine;

public class ArrowButtonHandler : MonoBehaviour
{
    PlayerHandler player; 
    Vector2 touchVector;
    Vector2 currentVector = Vector2.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = FindFirstObjectByType<PlayerHandler>();
    }

    // Called by PointerDown on buttons
    public void OnClickUpButton(bool isPressed)
    { 
        currentVector.y = isPressed ? 1f : 0f; 
        print("Up button! move vector:" + currentVector.x);

        SendToPlayer(); 
    }
    public void OnClickDownButton(bool isPressed)
    {
        currentVector.y = isPressed ? -1f : 0f;
        print("Down button! move vector:" + currentVector.x);

        SendToPlayer(); 
    }
    public void OnClickLeftButton(bool isPressed)
    { 
        currentVector.x = isPressed ? -1f : 0f; 
        print("Left button! move vector:" + currentVector.x);
        
        SendToPlayer();
    }
    public void OnClickRightButton(bool isPressed)
    { 
        currentVector.x = isPressed ? 1f : 0f;  
        print("Right button! move vector:" + currentVector.x);

        SendToPlayer();
    }

    // for up and down
    public void OnReleaseVertical()
    { 
        touchVector.y = 0f; 
        SendToPlayer(); 
    }

    // for left and right
    public void OnReleaseHorizontal()
    { 
        touchVector.x = 0f; 
        SendToPlayer(); 
    }

    void SendToPlayer()
    {
        if (player != null)
        {
            player.SetMoveVector(currentVector);
        }
    }
}

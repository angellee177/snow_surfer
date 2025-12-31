using UnityEngine;

public class FinishLineHandler : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerindex = LayerMask.NameToLayer("Player");

        if(collision.gameObject.layer == layerindex)
        {
            print("The player has won!!");
        }
    }
}

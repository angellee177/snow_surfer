using UnityEngine;

public class CrashDetectorHandler : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Floor");

        print(collision.gameObject.layer);

        if(collision.gameObject.layer == layerIndex)
        {
            print("The player has lose!!");
        }
    }
}

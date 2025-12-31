using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetectorHandler : MonoBehaviour
{
    [SerializeField] float delayTime;
    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Floor");

        print(collision.gameObject.layer);

        if(collision.gameObject.layer == layerIndex)
        {
            Invoke("ReloadScene", delayTime);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

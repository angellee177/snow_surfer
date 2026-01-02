using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetectorHandler : MonoBehaviour
{
    [SerializeField] float delayTime;
    [SerializeField] ParticleSystem crashParticle;
    
    PlayerHandler playerHandler;
    void Start()
    {
        playerHandler = FindFirstObjectByType<PlayerHandler>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Floor");

        if(collision.gameObject.layer == layerIndex)
        {
            // to block user control player when it crashed the floor.
            playerHandler.DisableControls();

            crashParticle.Play();
            Invoke("ReloadScene", delayTime);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

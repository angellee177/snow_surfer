using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetectorHandler : MonoBehaviour
{
    [SerializeField] float delayTime;
    [SerializeField] ParticleSystem crashParticle;
    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Floor");

        print(collision.gameObject.layer);

        if(collision.gameObject.layer == layerIndex)
        {
            crashParticle.Play();
            Invoke("ReloadScene", delayTime);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

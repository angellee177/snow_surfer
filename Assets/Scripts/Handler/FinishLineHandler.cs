using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLineHandler : MonoBehaviour
{
    [SerializeField] float delayTime;
    [SerializeField] ParticleSystem finishParticles;
    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerindex = LayerMask.NameToLayer("Player");

        if(collision.gameObject.layer == layerindex)
        {
            finishParticles.Play();
            Invoke("ReloadScene", delayTime);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

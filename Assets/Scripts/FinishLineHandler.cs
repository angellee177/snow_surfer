using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLineHandler : MonoBehaviour
{
    [SerializeField] float delayTime;
    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerindex = LayerMask.NameToLayer("Player");

        if(collision.gameObject.layer == layerindex)
        {
            Invoke("ReloadScene", delayTime);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

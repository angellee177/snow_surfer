using UnityEngine;
using UnityEngine.SceneManagement;

public class CharactersHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // pause the game
        Time.timeScale = 0;
    }
    
    void BeginGame()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }

    public void ChooseOx()
    {
        Debug.Log("Ox Button was clicked!");
        PlayerPrefs.SetInt("SelectedCharacter", 0); // 0 = Ox
        SceneManager.LoadScene("Level1");
        BeginGame();
    }

    public void ChooseDino()
    {
        Debug.Log("Dino Button was clicked!");
        PlayerPrefs.SetInt("SelectedCharacter", 1); // 1 = Dino
        SceneManager.LoadScene("Level1");
        BeginGame();
    }

    public void ChooseFox()
    {
        Debug.Log("Fox Button was clicked!");
        PlayerPrefs.SetInt("SelectedCharacter", 2); // 2 = Fox
        SceneManager.LoadScene("Level1");
        BeginGame();
    }

    public void ChooseFrog()
    {
        Debug.Log("Frog Button was clicked!");
        PlayerPrefs.SetInt("SelectedCharacter", 3); // 3 = Frog
        SceneManager.LoadScene("Level1");
        BeginGame();
    }
}

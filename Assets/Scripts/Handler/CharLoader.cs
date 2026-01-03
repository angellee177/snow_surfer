using UnityEngine;

public class CharLoader : MonoBehaviour
{
    [SerializeField] GameObject[] characterVisuals;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int selectedID = PlayerPrefs.GetInt("SelectedCharacter", 0);

        if(selectedID < characterVisuals.Length)
        {
            characterVisuals[selectedID].SetActive(true);
            Debug.Log("Character " + selectedID + " activated!");
        }
    }
}

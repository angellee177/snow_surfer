using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI flipCounterText;

    int score = 0;

    public void AddScore(int additionalScore)
    {
        score += additionalScore;
        scoreText.text = "Score: " + score;
    }

    public void multipleScoreFromFlip(int currentFlipCount)
    {
        int points = 100 * currentFlipCount;
        score += points;

        // Update Main score
        scoreText.text = "Score: " + score;

        if(currentFlipCount > 1)
        {
            flipCounterText.text = $"Flip {currentFlipCount}x + {points}";
        } else
        {
            flipCounterText.text = "Flip +100";
        }
    }

    // Reset the Flip counter text;
    public void ResetFlipUI()
    {
        flipCounterText.text = "";
    }
}

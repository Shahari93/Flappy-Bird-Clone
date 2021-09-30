using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private int currentScore = 0;

    private void Start()
    {
        scoreText.text = currentScore.ToString();
    }

    public void AddToScore()
    {
        currentScore++;
        scoreText.text = currentScore.ToString();
    }
}
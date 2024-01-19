using UnityEngine;
using UnityEngine.UI;

public class ScoreManage : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    // Método para sumar puntos al score
    public void AddPoints(int points)
    {
        score += points;
        UpdateScoreText();
    }

    // Método para actualizar el texto de puntuación en la interfaz de usuario
    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
}

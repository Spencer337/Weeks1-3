using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public GameObject gameOverScreen;
    public TextMeshProUGUI score;
    int scoreValue = 0;
    bool gameActive = true;

    private void Start()
    {
        score.text = scoreValue.ToString();
        gameOverScreen.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && gameActive)
        {
            scoreValue++;
            score.text = scoreValue.ToString();
        }
        if (scoreValue > 10)
        {
            gameOverScreen.SetActive(true);
            gameActive = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && gameActive == false)
        {
            scoreValue = 0;
            score.text = scoreValue.ToString();
            gameActive = true;
            gameOverScreen.SetActive(false);
        }
    }
}

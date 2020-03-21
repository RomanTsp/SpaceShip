using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameScore : MonoBehaviour
{
    Text scoreTextUI;

    int score;
    
    public int Score
    {
        get
        {
            return this.score;
        }
        set
        {
            this.score = value;
            UpdateScoreTextUI();
        }
    }
    
    void Start ()
    {
        //отримати текстовий компонент UI цього ігрового об'єкта
        scoreTextUI = GetComponent<Text>();

    }

    //Функція для оновлення інтерфейсу  тексту UI
    void UpdateScoreTextUI ()
    {
        string scoreStr = string.Format("{0:0000000}", score);
        scoreTextUI.text = scoreStr;

        if (score > 5000) 
            {
            SceneManager.LoadScene("PlatformUp");
        }
	}
}

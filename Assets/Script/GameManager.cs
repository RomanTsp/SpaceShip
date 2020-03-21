using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Посилання на  ігрові об'єкти
    public GameObject GameOverGO;//посилання на зображення (game over)
    public GameObject playButton;
    public GameObject playShip;
    public GameObject enemySpawner; //посилання на ворога (spawner)
    public GameObject scoreUITextGO;//Посилання на результат текстy ігрового інтерфейсу об'єкта

    public enum GameManagerState
    {
        Opening,
        Gameplay,
        GameOver,
    }
    // Use this for initialization
    GameManagerState GMState;

    void Start()
    {
        GMState = GameManagerState.Opening;

    }
    //Функція оновлення стану гри 
    void UpdateGameMangerState()
    {
        switch (GMState)
        {
            case GameManagerState.Opening:

                //Приховати (гра закінчена)
                GameOverGO.SetActive(false);

                //Включити кнопку" play "  (активна)
                playButton.SetActive(true);
                break;
            case GameManagerState.Gameplay:

                //скинути рахунок
                scoreUITextGO.GetComponent<GameScore>().Score = 0;

                //Приховати кнопку "play" в ігровому стані
                playButton.SetActive(false);

                //ініціалізуйте життя гравця
                playShip.GetComponent<PlayerControl>().Init();

                //Запуск (створення) противника 
                enemySpawner.GetComponent<EnemySpawner>().ScheduleEnemySpawner();
                break;

            case GameManagerState.GameOver:
                //Зупинити (створення) ворога
                enemySpawner.GetComponent<EnemySpawner>().ScheduleEnemySpawner();
                
                //Відображити (game over)
                GameOverGO.SetActive(true);

                Invoke("ChangeTo0peningState",4f);

                break;
        }
    }
    public void SetGameManagerState(GameManagerState state)
    {
        GMState = state;
        UpdateGameMangerState();
    }
    public void StartGamePlay()
    {
        GMState = GameManagerState.Gameplay;
        UpdateGameMangerState();
    }
    public void ChangeTo0peningState()
    {
        SetGameManagerState(GameManagerState.Opening);
    }
}

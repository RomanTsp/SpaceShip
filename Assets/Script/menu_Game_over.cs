using UnityEngine;

using System.Collections;

using UnityEngine.SceneManagement;




public class menu_Game_over : MonoBehaviour

{
    public GameObject settings;

    public void StartGame()

    {

        SceneManager.LoadScene("Level1");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
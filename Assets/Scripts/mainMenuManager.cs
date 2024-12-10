using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuManager : MonoBehaviour
{

    public void playGame(int charIndex)
    {
        SceneManager.LoadScene("Gameplay");
        PlayerPrefs.SetInt("Character Index", charIndex);
    }

    public void quitGame()
    {
        Application.Quit();
     
    }


}


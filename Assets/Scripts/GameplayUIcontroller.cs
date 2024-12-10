using UnityEngine;
using UnityEngine.SceneManagement;
public class GameplayUIcontroller : MonoBehaviour
{

   public void home()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void restart()
    {
        SceneManager.LoadScene("Gameplay");
    }


}

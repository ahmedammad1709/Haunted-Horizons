using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamePlayManager : MonoBehaviour
{
    [SerializeField] private GameObject[] playerPrefabs;
    [SerializeField] private GameObject gameOverWindow;
    [SerializeField] private RectTransform retryButton;
    [SerializeField] private RectTransform homeButton;
    [SerializeField] private TextMeshProUGUI scoretext;
    [SerializeField] private TextMeshProUGUI highscoreText;

    private void Awake()
    {
        int charIndex = PlayerPrefs.GetInt("Character Index", 0);
        Instantiate(playerPrefabs[charIndex]);
        gameOverWindow.SetActive(false);
    }

    public void gameOver()
    {
        gameOverWindow.SetActive(true);
        retryButton.localPosition = new Vector2 (-137, -175);
        homeButton.localPosition = new Vector2 (137, -175);
        scoretext.rectTransform.localPosition = new Vector2(0, -20);

        int highscore = PlayerPrefs.GetInt("highScore", 0);
        score scorescript = FindFirstObjectByType<score>();
        if (scorescript.playerScore > highscore)
        {
            highscore = scorescript.playerScore;
            PlayerPrefs.SetInt("highScore", highscore);
        }

        highscoreText.text = "High Score : "+ highscore.ToString();

    }

   
    public void home()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void restart()
    {
        SceneManager.LoadScene("Gameplay");
        retryButton.position = new Vector2(-103, -85);
        homeButton.position = new Vector2(122, -123);

    }


}

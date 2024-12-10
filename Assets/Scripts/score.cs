using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{
     public int playerScore;
     [SerializeField] private TextMeshProUGUI scoreText;
   
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        if(scoreText == null)
        {
            Debug.Log("NULL REF");
        }
    }
    void Update()
    {
        scoreText.text = "Score: " + playerScore;
    }
    public void scoreIncrease()
    {
            playerScore += 10;
            Debug.Log("Score + 10");
      
    }
}

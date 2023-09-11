using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject Objetoaaparecer;
    private int score = 0;
    public TMP_Text scoreText;
    //public Text scoreText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void UpdateScore(int points)
    {
       
        score +=30* points;
        UpdateScoreUI();
        if(score>=180)
        {
            Objetoaaparecer.SetActive(true);
        }
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "KWH GENERADOS " + score.ToString();
            
        }
    }
}

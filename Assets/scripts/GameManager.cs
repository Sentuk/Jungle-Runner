using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject scoreTable;
    public PlayerController playerController;
    private int score = 0;
    [SerializeField] private TextMeshProUGUI scoreCount;
    [SerializeField] private TextMeshProUGUI highScore;
    [SerializeField] private TextMeshProUGUI GameOverScore;
    [SerializeField] private TextMeshProUGUI GameoverBestScore;
    private int highscore = 0;
    public GameObject bacGroud;
    public GameObject player;
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;
    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;

    }
    void Start()
    {
        playerController = GetComponent<PlayerController>();
        highscore = PlayerPrefs.GetInt("highscore", 0);
        GameOverScore.text = "Score : " + score.ToString();
        GameoverBestScore.text = "Best Score : " + highscore.ToString();
        scoreCount.text = "SCORE " + score.ToString();
        highScore.text = "Best Score: " + highscore.ToString();
        if (highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score);

        }
    }
    public void GameOver()
    {
        bacGroud.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;

    }
    public void Restart()
    {
        Physics.gravity = new Vector3(0, -9.8f, 0);
        SceneManager.LoadScene("Game_1");

    }


    // Update is called once per frame
    public void updateScore()
    {
        score += 1;
        scoreCount.text = "Score : " + score;
        GameOverScore.text = "Score : " + score;
        PlayerPrefs.SetInt("highscore", score);
    }

    public void BackToMenu()
    {
        Physics.gravity = new Vector3(0, -9.8f, 0);
        SceneManager.LoadScene("MainMenu");

    }
    public void IsGameActive()
    {
        isGameActive = true;
    }
    void OnDestroy()
    {
        DontDestroyOnLoad(highScore);
    }
}

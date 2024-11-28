using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuHandlerUI : MonoBehaviour
{
    public GameManager gameManager;
    public void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    // Start is called before the first frame update
    public void StartOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void manuelmenu()
    {
        gameManager.isGameActive = true;
    }

    public void BackMenu()
    {
        gameManager.BackToMenu();
    }

    public void ResTartGame()
    {
        gameManager.Restart();
    }

}

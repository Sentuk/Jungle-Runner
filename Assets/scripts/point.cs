using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class point : MonoBehaviour
{
    int maxplatform = 0;
    public GameOverScreen GameOverScreen;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Points")
        {
            gameManager.updateScore();
        }
        if (other.tag == "Obstacle")
        {
            GameOverScreen.Setup(maxplatform);
        }

    }
    public void GameOver()
    {
        GameOverScreen.Setup(maxplatform);
    }

}

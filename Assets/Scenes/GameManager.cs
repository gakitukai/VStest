using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    void Awake()
    {
        instance = this;
    }

    [SerializeField] GameObject gameOverText;
    [SerializeField] GameObject retryButton;
    [SerializeField] GameObject titleButton;
    [SerializeField] Text scoreText;
    int score;
    // Start is called before the first frame update
    private void Start()
    {
        gameOverText.SetActive(false);
        retryButton.SetActive(false);
        titleButton.SetActive(false);
        score = 0;
    }

    // Update is called once per frame
    public void GameOver()
    {
        


        gameOverText.SetActive(true);
        retryButton.SetActive(true);
        titleButton.SetActive(true);
    }
    public void OnRetryButton()
    {
        string sceneName = SceneManager.GetActiveScene().name;

        SceneManager.LoadScene(sceneName);
    }
    public void OntitleButton()
    {
        string sceneName = SceneManager.GetActiveScene().name;

        SceneManager.LoadScene("Title");
    }
    public void AddDestroyCount()
    {
        score++;

        scoreText.text = score.ToString();
        Debug.Log("‚â‚Á‚Â‚¯‚½");
    }
}


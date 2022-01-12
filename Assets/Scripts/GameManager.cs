using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using TMPro;

public class GameManager : MonoBehaviour
{
    #region Singleton pattern
    public static GameManager instance;

    private void Awake()
    {
        // Singleton Zımbırtısı
        // Eğer ilk defa giriyorsa bir scene'e,
        // GameManager Instance'ı olmadığı için atama yapıyoruz
        if (instance == null || instance == this)
        {
            instance = this;
            // DontDestroyOnLoad(this);
        }
        else
        {
            // Eğer null değilse zaten daha önce girilmiş
            // ve buranın instance'ı var demektir
            Destroy(this.gameObject);
        }

    }
    #endregion

    public int score;
    [SerializeField] private TMP_Text scoreText;

    public float gameSpeed;

    public float difficulty;

    public bool isGameRunning = false;

    public AudioClip startEffect,
     hitEffect, jumpEffect, pointEffect, dieEffect;

    [SerializeField] private GameObject gameOverMenu;
    private void Start()
    {
        Time.timeScale = 0;
        isGameRunning = false;
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        scoreText.text = score.ToString(); 
    }

    public void StartGame()
    {
        
        isGameRunning = true;
        Time.timeScale = 1;
        SoundManager.instance.PlaySound(startEffect);
    }

    public void Jump()
    {
        SoundManager.instance.PlaySound(jumpEffect);
    }

    public void GameOver()
    {
        
        Time.timeScale = 0;
        gameOverMenu.SetActive(true);
        isGameRunning = false;
        SoundManager.instance.PlaySound(hitEffect);
        SoundManager.instance.PlaySound(dieEffect);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void FixedUpdate()
    {
        gameSpeed += (difficulty * 1/1000);
    }
}

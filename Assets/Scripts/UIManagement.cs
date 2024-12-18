using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class UIManagement : MonoBehaviour
{
    [SerializeField] private GameObject pauseUI;
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private GameObject HUD;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private Timer timer;
    //[SerializeField] private Audio audio
    void Update()
    {
        if (timer.isTimeOver())
        {
            HandleGameOver();
        }
        else
        {
            HandlePause();
        }
    }


    private void HandlePause()
    {
        if (playerController.IsPause())
        {
            pauseUI.SetActive(true);
        }
        else
        {
            pauseUI.SetActive(false);
        }
    }

    private void HandleGameOver()
    {
        HUD.SetActive(false);
        pauseUI.SetActive(false);
        gameOverUI.SetActive(true);
    }
}

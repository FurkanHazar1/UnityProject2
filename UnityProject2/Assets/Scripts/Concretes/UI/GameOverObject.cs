using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityProject2.managers;
using UnityProject2.controller;


namespace UnityProject2.ui
{

    public class GameOverObject : MonoBehaviour
    {
        [SerializeField] GameObject gameOverPanel;
        
        private void Awake()
        {
            if (gameOverPanel.activeSelf)
            {
                gameOverPanel.SetActive(false);
            }

           
        }
        private void OnEnable()
        {
            GameManager.instance.onGameOver += handleGameOverPanel;
        }
        private void OnDisable()
        {
            GameManager.instance.onGameOver -= handleGameOverPanel;
        }

        public void handleGameOverPanel()
        {
            if (!gameOverPanel.activeSelf)
            {
                gameOverPanel.SetActive(true);
            }
        }


    }

}
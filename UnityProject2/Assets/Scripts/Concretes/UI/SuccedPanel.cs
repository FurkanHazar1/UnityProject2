using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityProject2.managers;



namespace UnityProject2.ui
{
    public class SuccedPanel : MonoBehaviour
    {
       [SerializeField] GameOverPanel gameOverPanel;

        private void Awake()
        {
            gameOverPanel = new GameOverPanel();
        }
        public void NextLevelButton()
        {
            GameManager.instance.loadLevelScene(1);
        }
        public void TryAgainButton()
        {
            gameOverPanel.TryAgeinButton();
        }

        public void MainMenuButton()
        {
            gameOverPanel.MainMenuButton();
        }


    }
}


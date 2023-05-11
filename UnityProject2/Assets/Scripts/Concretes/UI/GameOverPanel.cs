using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityProject2.managers;



namespace UnityProject2.ui
{
    public class GameOverPanel : MonoBehaviour
    {
       public void TryAgeinButton()
        {
            GameManager.instance.loadLevelScene();
        }
        public void MainMenuButton()
        {

            GameManager.instance.loadMenuScene();
        }
    }
}

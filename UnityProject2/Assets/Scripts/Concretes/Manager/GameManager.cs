using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityProject2.Abstracts.utilities;
namespace UnityProject2.managers
{
    public class GameManager : SingletenGameObject<GameManager>
    {
       

        public event System.Action onGameOver;
        public event System.Action onSucced;
        private void Awake()
        {
            singletenPattern(this);
           
        }
      

        public void gameOver()
        {
            onGameOver?.Invoke();
        }

        public void Succed()
        {
            onSucced?.Invoke();
        }

        public void loadLevelScene(int levelIndex = 0)
        {
            StartCoroutine(loadLevelSceneAscyn(levelIndex));
        }
        private IEnumerator loadLevelSceneAscyn(int levelIndex)
        {
            SoundManager.instance.StopSound(1);
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + levelIndex);
            SoundManager.instance.PlaySound(2);
        }

        public void loadMenuScene()
        {
            StartCoroutine(loadMenuSceneAsycn());
        }

        private IEnumerator loadMenuSceneAsycn()
        {
            SoundManager.instance.StopSound(2);
            yield return SceneManager.LoadSceneAsync("menu");
            SoundManager.instance.PlaySound(1);
        }

        public void exit()
        {
            Application.Quit();
        }
    }
}


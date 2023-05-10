using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityProject2.managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance { get; private set; }

        public event System.Action onGameOver;
        public event System.Action onSucced;
        private void Awake()
        {
            singletenPattern();
        }
        private void singletenPattern()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this);
            }
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
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + levelIndex);
        }

        public void loadMenuScene()
        {
            StartCoroutine(loadMenuSceneAsycn());
        }

        private IEnumerator loadMenuSceneAsycn()
        {
            yield return SceneManager.LoadSceneAsync("menu");
        }

        public void exit()
        {
            Application.Quit();
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UnityProject2.managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance { get; private set; }

        public event System.Action onGameOver;
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

    }
}


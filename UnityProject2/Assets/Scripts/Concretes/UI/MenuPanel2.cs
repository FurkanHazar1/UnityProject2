using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityProject2.managers;

namespace UnityProject2.ui
{
    public class MenuPanel2 : MonoBehaviour
    {
       public void StartButton()
        {
            GameManager.instance.loadLevelScene(1);
        }
        public void ExitButton()
        {
            GameManager.instance.exit();
        }
    }

}
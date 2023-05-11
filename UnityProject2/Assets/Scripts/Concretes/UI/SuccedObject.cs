using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityProject2.managers;

namespace UnityProject2.ui
{
    public class SuccedObject : MonoBehaviour
    {
        [SerializeField]GameObject succedObject;
        private void Awake()
        {
            if (succedObject.activeSelf)
            {
                succedObject.SetActive(false);
            }
        }
        private void OnEnable()
        {
            GameManager.instance.onSucced += handleObject;
        }
        private void OnDisable()
        {
            GameManager.instance.onSucced -= handleObject;
        }

        public void handleObject()
        {
            succedObject.SetActive(true);
        }

    }

}

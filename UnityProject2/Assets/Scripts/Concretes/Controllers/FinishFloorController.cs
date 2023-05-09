using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityProject2.managers;

namespace UnityProject2.controller
{
    public class FinishFloorController : MonoBehaviour
    {
        [SerializeField] GameObject finishFloorParticle;


        bool isFinished;
        private void OnCollisionEnter(Collision collision)
        {
            PlayerController player = collision.collider.GetComponent<PlayerController>();
            if (player == null) return;
            if (collision.GetContact(0).normal.y == -1)
            {
                finishFloorParticle.gameObject.SetActive(true);
            
                isFinished = true;
            }
            else
            {
                GameManager.instance.gameOver();
            }
        }
    }

}

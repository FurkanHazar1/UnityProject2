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
       

        private void OnCollisionEnter(Collision collision)
        {
            PlayerController player = collision.collider.GetComponent<PlayerController>();
            if (player == null || !player.CanMove) return;
            if (collision.GetContact(0).normal.y == -1)
            {
                finishFloorParticle.gameObject.SetActive(true);
                GameManager.instance.Succed();
                
            }
            else
            {
                GameManager.instance.gameOver();
            }
        }
    }

}

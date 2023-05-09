using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityProject2.managers;

namespace UnityProject2.controller
{
    public class WallController : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            PlayerController player = collision.collider.GetComponent<PlayerController>();
            if (player != null)
            {
                GameManager.instance.gameOver(); 
            }
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityProject2.controller;
using UnityProject2.managers;

namespace UnityProject2.Abstracts.controller
{
    public abstract class WallController : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            PlayerController player = collision.collider.GetComponent<PlayerController>();
            if (player != null && player.CanMove)
            {
                GameManager.instance.gameOver(); 
            }
        }
    }

}

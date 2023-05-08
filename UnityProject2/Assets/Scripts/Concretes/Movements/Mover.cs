using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityProject2.controller;

namespace UnityProject2.movments
{
    public class Mover
    {
        Rigidbody rigidbody;
        PlayerController playerController;
        public Mover(PlayerController playerController)
        {
            this.playerController = playerController;
            this.rigidbody = playerController.GetComponent<Rigidbody>();
        }

        public void FixedTick()
        {
            rigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * playerController.force);

        }

        
    }

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityProject2.controller;

namespace UnityProject2.movments
{
    public class Rotater
    {
        PlayerController playerController;
        Rigidbody rb;
        public Rotater(PlayerController playerController)
        {
            this.playerController = playerController;
            rb = playerController.GetComponent<Rigidbody>();
        }


        public void FixedTick(float leftRight)
        {
            if (leftRight == 0)
            {
                if (rb.freezeRotation) rb.freezeRotation = false;
                return;
            }

            if (!rb.freezeRotation) rb.freezeRotation = true;
            playerController.transform.Rotate(Vector3.back * Time.deltaTime * leftRight * playerController.turnSpeed);

        }
        
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityProject2.Inputs;
using UnityProject2.movments;


namespace UnityProject2.controller
{
    public class PlayerController : MonoBehaviour
    {

        DefaultInput input;
        Mover mover;

        private bool isForceUp;


        private void Awake()
        {

            mover = new Mover(GetComponent<Rigidbody>());
            input = new DefaultInput();
        }
        private void Update()
        {
            if (input.isForcedUp)
            {
                isForceUp = true;
            }
            else
            {
                isForceUp = false;
            }
        }
        private void FixedUpdate()
        {
            if (isForceUp)
            {
                mover.FixedTick();
            }
        }
    }

}



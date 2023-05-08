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
        Rotater rotater;


        private bool isForceUp;
        public float leftRight;

        public float turnSpeed= 50f;
        public float force = 75;

        private void Awake()
        {
            rotater = new Rotater(this);
            mover = new Mover(this);
            input = new DefaultInput();
        }
        private void Update()
        {
            Debug.Log(input.leftRight);
            if (input.isForcedUp)
            {
                isForceUp = true;
            }
            else
            {
                isForceUp = false;
            }

            leftRight = input.leftRight;
        }
        private void FixedUpdate()
        {
            if (isForceUp)
            {
                mover.FixedTick();
            }
            rotater.FixedTick(leftRight);    
        }
    }

}



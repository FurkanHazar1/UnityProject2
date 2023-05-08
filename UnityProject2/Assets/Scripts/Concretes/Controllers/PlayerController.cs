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
        Fuel fuel;
   

        private bool canForceUp;
        public float leftRight;


       [SerializeField] private float increase = 0.5f;
       [SerializeField] private float decrease = 2f;
        public float turnSpeed = 50f;
        public float force = 75;

        private void Awake()
        {
            rotater = new Rotater(this);
            mover = new Mover(this);
            input = new DefaultInput();
            fuel = GetComponent<Fuel>();
        }
        private void Update()
        {
          
            if (input.isForcedUp && !fuel.isEmpty)
            {
                canForceUp = true;
                
            }
            else
            {
                canForceUp = false;
                fuel.fuelIncrease(increase);
            }

            leftRight = input.leftRight;
        }
        private void FixedUpdate()
        {
            if (canForceUp)
            {
                mover.FixedTick();
                fuel.fuelDecrease(decrease);
            }
            rotater.FixedTick(leftRight);    
        }
    }

}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityProject2.Inputs;
using UnityProject2.movments;
using UnityProject2.managers;

namespace UnityProject2.controller
{
    public class PlayerController : MonoBehaviour
    {

        DefaultInput input;
        Mover mover;
        Rotater rotater;
        Fuel fuel;


        public bool CanMove => canMove;
        private bool canMove;
        private bool canForceUp;
        public float leftRight;


       [SerializeField] private float increase = 0.1f;
       [SerializeField] private float decrease = 0.3f;
        public float turnSpeed = 50f;
        public float force = 75;

        private void Awake()
        {
            rotater = new Rotater(this);
            mover = new Mover(this);
            input = new DefaultInput();
            fuel = GetComponent<Fuel>();
        }
        private void OnEnable()
        {
            GameManager.instance.onGameOver += gameTrigger;
            GameManager.instance.onSucced += gameTrigger;
        }
        private void OnDisable()
        {
            GameManager.instance.onGameOver -= gameTrigger;
            GameManager.instance.onSucced -= gameTrigger;
        }
        private void Start()
        {
            canMove = true;
        }
        private void Update()
        {
            if (!canMove) return;

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
        public void gameTrigger()
        {
            canMove = false;
            canForceUp = false;
            leftRight = 0f;
            fuel.fuelIncrease(0);

        }
    }

}



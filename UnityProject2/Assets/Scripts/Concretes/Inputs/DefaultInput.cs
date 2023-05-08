using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UnityProject2.Inputs
{
    public class DefaultInput
    {
        private DefaultAction input;

        public bool isForcedUp { get; private set; }
        public float leftRight  { get; private set; }


        public DefaultInput()
        {
            input = new DefaultAction();

            input.Rocket.ForceUP.performed += context => isForcedUp = context.ReadValueAsButton();
            input.Rocket.LeftRight.performed += context => leftRight = context.ReadValue<float>();

            input.Enable();
        }
    }




}


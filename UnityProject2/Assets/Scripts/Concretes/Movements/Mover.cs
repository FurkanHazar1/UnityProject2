using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UnityProject2.movments
{
    public class Mover
    {
        Rigidbody rigidbody;
        public Mover(Rigidbody rigidbody)
        {
            this.rigidbody = rigidbody;
        }

        public void FixedTick()
        {
            rigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * 100f);

        }

        
    }

}


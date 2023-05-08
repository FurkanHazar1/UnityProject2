using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityProject2.Inputs;

namespace UnityProject2.controller
{
    public class PlayerController : MonoBehaviour
    {
        Rigidbody rb;
        DefaultInput input;


        private bool isForceUp;
        [SerializeField] float force;


        private void Awake()
        {

            rb = GetComponent<Rigidbody>();
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
                rb.AddForce(Vector3.up * Time.deltaTime * force);
            }
        }
    }

}



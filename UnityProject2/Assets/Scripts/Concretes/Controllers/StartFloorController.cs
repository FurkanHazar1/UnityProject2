using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UnityProject2.controller
{

    public class StartFloorController : MonoBehaviour
    {
        private void OnCollisionExit(Collision collision)
        {
            PlayerController player = collision.collider.GetComponent<PlayerController>();
            if (player != null)
            {
                Destroy(this.gameObject);
            }
        }
    }


}


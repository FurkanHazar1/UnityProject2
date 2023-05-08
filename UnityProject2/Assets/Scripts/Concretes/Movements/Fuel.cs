using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityProject2.movments
{
    public class Fuel : MonoBehaviour
    {
        [SerializeField] float currentFuel;
        
        [SerializeField] ParticleSystem particle;
        public bool isEmpty => currentFuel < 1;

        [SerializeField] float maxFuel=100;
        [SerializeField] float minFuel=0;

        private void Awake()
        {
            currentFuel = maxFuel;
        }

        public void fuelIncrease(float increase)
        {
            currentFuel += increase;
            currentFuel = Mathf.Min(currentFuel, maxFuel);
            if (particle.isPlaying)
            {
                particle.Stop();
            }
        }

        public void fuelDecrease(float decrease)
        {
            currentFuel -= decrease;
            currentFuel = Mathf.Max(currentFuel, minFuel);
            if (particle.isStopped)
            {
                particle.Play();
            }

        }


    }



}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityProject2.managers;

namespace UnityProject2.movments
{
    public class Fuel : MonoBehaviour
    {
        [SerializeField] float currentFuel;
        
        [SerializeField] ParticleSystem particle;
        public bool isEmpty => currentFuel < 1;
        public float CurrentFuel => currentFuel/maxFuel;
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
            SoundManager.instance.StopSound(0);
        }

        public void fuelDecrease(float decrease)
        {
            currentFuel -= decrease;
            currentFuel = Mathf.Max(currentFuel, minFuel);
            if (particle.isStopped)
            {
                particle.Play();
            }
            SoundManager.instance.PlaySound(0);
        }


    }



}


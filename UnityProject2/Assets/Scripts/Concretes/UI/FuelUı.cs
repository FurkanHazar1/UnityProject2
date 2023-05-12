using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityProject2.movments;



namespace UnityProject2.uı
{
    public class FuelUı : MonoBehaviour
    {
        [SerializeField] float sliderValue;
        Slider slider;
        [SerializeField] Fuel fuel;
        private void Awake()
        {
            slider = GetComponent<Slider>();
            fuel = FindObjectOfType<Fuel>();
        }
        private void Update()
        {
            sliderValue = fuel.CurrentFuel;
            slider.value=sliderValue;
            
        }
    }
}


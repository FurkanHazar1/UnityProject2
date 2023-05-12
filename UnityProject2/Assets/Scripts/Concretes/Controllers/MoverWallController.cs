using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityProject2.Abstracts.controller;



namespace UnityProject2.controller
{
    public class MoverWallController : WallController
    {
        [SerializeField] Vector3 direction;
        [Range(0,1)][SerializeField] float range;
        [SerializeField] float slowSpeed=10;
        
        Vector3 startPosition;

        const float fullCircle = Mathf.PI * 2f; 
        private void Awake()
        {
            startPosition = transform.position;
        }

       private void Update()
        {
            float circle = Time.time / slowSpeed;
            float sinWave = Mathf.Sin(circle * fullCircle);
            
            range = sinWave / 2 + 0.5f;
            
            Vector3 offset = direction * range;
            transform.position = offset + startPosition;
        }
    }

}

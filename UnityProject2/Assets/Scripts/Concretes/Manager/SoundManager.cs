using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityProject2.Abstracts.utilities;
namespace UnityProject2.managers
{
    public class SoundManager : SingletenGameObject<SoundManager>
    {
        AudioSource[] audioSource;
  
        private void Awake()
        {
            singletenPattern(this);
            audioSource = GetComponentsInChildren<AudioSource>();
        }
        public void PlaySound(int index)
        {
            if (!audioSource[index].isPlaying)
            {
                audioSource[index].Play();
            }
               
        }
        public void StopSound(int index)
        {
            if (audioSource[index].isPlaying) 
            {
                audioSource[index].Stop();
            }
                
        }

    }
}


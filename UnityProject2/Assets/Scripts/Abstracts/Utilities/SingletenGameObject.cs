using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace UnityProject2.Abstracts.utilities
{
    public abstract class SingletenGameObject<A> : MonoBehaviour
    {
        public static A instance { get; private set; }
        protected void singletenPattern( A entitiy)
        {
            if (instance == null)
            {
                instance = entitiy;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this);
            }
        }
    }


}

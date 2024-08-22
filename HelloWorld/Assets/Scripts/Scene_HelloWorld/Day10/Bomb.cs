using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace SIRO.Practices.Day10
{
    public class Bomb : MonoBehaviour
    {
        EventTest testing;
        private void Awake()
        {
            testing = FindObjectOfType<EventTest>();
        }

        private void Start()
        {
            if (testing)
            {
                testing.ExplosionEvt += Explosion;
            }
        }

        private void Update()
        {
         
        }

        public void Explosion()
        {
            Debug.Log("Boom noooo");
        }
    }
}

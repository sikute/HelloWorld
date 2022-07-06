using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace SIRO.Practices.Day10
{ 
    public class EventTest : MonoBehaviour
    {
        public bool isCollisionWithTrap;
        public delegate void myDelegate();
        public event myDelegate ExplosionEvt;

        public delegate void myDelegate2(float a);

        private void Start()
        {
            //myDelegate dele = new myDelegate(Hello);
            //myDelegate dele = () =>
            //{
            //    Debug.Log("day la ham nac danh");
            //};

            //myDelegate2 dele2 = (float x) =>
            //{
            //    Debug.Log(x);
            //};

            //myDelegate2 dele3 = (float x) => Hello(x);

            //myDelegate dele4 = () => Hello2();

            //dele();
            //dele2(2);
            //dele3(9);
            //dele4();

            //ExplosionEvt += () => Hello2();
        }

        void Hello(float x)
        {
            Debug.Log(x);
        }

        void Hello2()
        {
            Debug.Log("Phuong thuc khong co tham so");
        }
        private void Update()
        {
            if(ExplosionEvt != null && isCollisionWithTrap)
            {
                isCollisionWithTrap = false;
                ExplosionEvt();
            }
        }
    }
}

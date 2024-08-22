using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace SIRO.Practices.Day10
{ 
    public class DelegateTest : MonoBehaviour
    {
        delegate float myDelegate(float a, float b);

        private void Start()
        {
            //myDelegate myDele = new myDelegate(TinhTong);

            //float kq = myDele(3, 5);
            //Debug.Log(kq);

            //TinhTong(2, 1);
            //TinhHieu(4, 9);

            myDelegate tinhTongDele = new myDelegate(TinhTong);
            myDelegate tinhHieuDele = new myDelegate(TinhHieu);

            Main(tinhTongDele);

            //myDelegate multiCastDele = tinhTongDele + tinhHieuDele;

            //multiCastDele(4, 7);
            //multiCastDele -= tinhTongDele;

            //multiCastDele(2, 6);
        }
        void Main(myDelegate tinhTongDele)
        {
            int a = 5;
            int b = 8;

            tinhTongDele(a, b);
        }

        float TinhTong(float x, float y)
        {
            Debug.Log(x + y);
            return x + y;
        }
        float TinhHieu(float x , float y)
        {
            Debug.Log(x - y);
            return x + y;
        }
    }
}

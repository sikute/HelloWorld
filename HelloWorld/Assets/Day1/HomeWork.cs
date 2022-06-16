using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Day1.HomeWorks

{

public class HomeWork : MonoBehaviour
{
        int a = 8;
        int b = 10;
        int c = 12;
        int d = 2;

        //Ban kinh
        int R = 5;
        float pi = 3.14f;
        //Van toc
        int S = 20;
        int T = 5;
        private void Start()
        {
            Calculate();
        }
        void Calculate()
        {
            //trung binh cong 4 so bat ky
            Debug.Log($"Trung binh cong: {(a + b + c + d) / 4}");

            //Chu vi,dien tich hinh tam giac voi 3 canh a,b,c
            Debug.Log("Chu vi, dien tich hinh tam giac:");
            int P = a + b + c;
            Debug.Log(P);
            int p = P / 2;
            Debug.Log(Mathf.Sqrt(p*(p-a)*(p-b)*(p-c)));

            //Chu vi, dien tich hinh tron voi ban kinh R = 5, pi = 3.14
            Debug.Log("Chu vi, dien tich hinh tron:");

            Debug.Log((R*2)*pi);
            Debug.Log(Mathf.Pow(R,2) * pi);

            //Van toc cua quang duong 20km, thoi gian 5p
            Debug.Log($"Van toc: {S/T} km/phut");
        }
}

}


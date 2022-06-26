using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SIRO.HomeWorks.Day4
{

    public class HomeWork : MonoBehaviour
    {
        public enum PhepTinh
        {
            Tong,
            Tich
        }
        //int[] array1 = { 1, 2, 4, 2, 6, 1, 7, 8, 6, 5 };
        int[] array1 = { 1,2,3,4,5,6,7,8,9 };
        int[,] array2 =
            {
                { 1, 2, 4, 2, 6, 1, 7, 8, 6, 5},
                { 7, 3, 0, 9, 1, 8, 6, 10, 11, 17},
                { 10, 21, 1, 3, 5, 9, 2, 4, 12, 18}
            };
        //int[,] array2 =
        //    {
        //        { 0,1,2,3},
        //        { 4,5,6,0},
        //        { 0,7,8,9}
        //    };

        private void Start()
        {
            //SoGiongNhau();

            //int[] result = SoGiongNhauReturnValue();
            //int[] result = SoDuyNhatReturnValue();
            //string str = "";
            //foreach (int child in result) 
            //{
            //    str += child + ",";
            //}
            //Debug.Log(str);

            //SoDuyNhat();

            //Calculate();

            //Debug.Log(CalculateChanLe(7));
            Debug.Log(CalculateTongTich(PhepTinh.Tich,array1,null));
            Debug.Log(CalculateTongTich(PhepTinh.Tich,null,array2));


        }
        void SoGiongNhau()
        {
            string str;
            int count;

            ////mang 1 chieu
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    if (IsNumberChecked(i)) continue;
            //    str = "";
            //    count = 0;
            //    for (int j = 0; j < array1.Length; j++)
            //    {
            //        if (array1[j] == array1[i] && i != j) count++;
            //    }
            //    if (count == 0) continue;
            //    count++;
            //    while(count > 0)
            //    {
            //        str += array1[i] + ",";
            //        count--;
            //    }
            //    Debug.Log($"So giong nhau la: {str}");
            //}

            //mang 2 chieu
            int indexC = 0;
            int indexT;
            foreach (int child in array2)
            {
                if (IsNumberChecked(indexC, child))
                {
                    indexC++;
                    continue;
                }

                str = "";
                count = 0;
                indexT = 0;
                foreach (int temp in array2)
                {
                    if (temp == child && indexT != indexC) count++;
                    indexT++;
                }
                if (count == 0)
                {
                    indexC++;
                    continue;
                }
                count++;
                indexC++;
                while (count > 0)
                {
                    str += child + ",";
                    count--;
                }
                Debug.Log($"So giong nhau la: {str}");
            }


        }

        int[] SoGiongNhauReturnValue()
        {
            //string str;
            int count;
            int[] tempArray = new int[] { };
            int[] resultArray = new int[0] { };

            ////mang 1 chieu
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    if (IsNumberChecked(i)) continue;
            //    count = 0;
            //    Array.Resize(ref tempArray, count + 1);
            //    tempArray[count] = array1[i];
            //    for (int j = 0; j < array1.Length; j++)
            //    {
            //        if (array1[j] == array1[i] && i != j)
            //        {
            //            count++;
            //            Array.Resize(ref tempArray, count + 1);
            //            tempArray[count] = array1[j];
            //        }
            //    }
            //    if (tempArray.Length == 1) continue;
            //    int oldIndex = resultArray.Length;
            //    Array.Resize(ref resultArray, resultArray.Length + tempArray.Length);
            //    for (int k = 0, q = oldIndex; k < tempArray.Length && q < resultArray.Length; k++, q++)
            //    {
            //        resultArray[q] = tempArray[k];
            //    }
            //}
            //return resultArray;

            //mang 2 chieu
            int indexC = 0;
            int indexT;
            foreach (int child in array2)
            {
                if (IsNumberChecked(indexC, child))
                {
                    indexC++;
                    continue;
                }

                count = 0;
                indexT = 0;

                Array.Resize(ref tempArray, count + 1);
                tempArray[count] = child;

                foreach (int temp in array2)
                {
                    if (temp == child && indexT != indexC)
                    {
                        count++;
                        Array.Resize(ref tempArray, count + 1);
                        tempArray[count] = temp;
                    }
                    indexT++;
                }
                if (tempArray.Length == 1)
                {
                    indexC++;
                    continue;
                }
                indexC++;
                int oldIndex = resultArray.Length;
                Array.Resize(ref resultArray, resultArray.Length + tempArray.Length);
                for (int i = 0, p = oldIndex; i < tempArray.Length && p < resultArray.Length ; i++, p++)
                {
                    resultArray[p] = tempArray[i];
                }
            }

            return resultArray;

        }

        bool IsNumberChecked(int a)
        {
            if (a == 0) return false;
            for (int i = 0; i < a; i++)
            {
                if (array1[i] == array1[a]) return true;

            }
            return false;
        }

        bool IsNumberChecked(int count, int child)
        {
            if (count == 0) return false;
            int count1 = 0;
            foreach(int temp in array2)
            {
                if (temp == child) return true;
                if (count1 == count - 1) break;
                count1++;
            }
            return false;
        }

        void SoDuyNhat()
        {
            //mang 1 chieu
            string soDuyNhat = "";
            int count = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                count = 0;
                for (int j = 0; j < array1.Length; j++)
                {
                    if (array1[j] == array1[i] && i != j)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0) soDuyNhat += array1[i] + ",";
            }
            Debug.Log(soDuyNhat);

            //mang 2 chieu
            soDuyNhat = "";
                count = 0;
                int a = 0;
                int b = 0;
            foreach (int child in array2)
            {
                b = 0;
                count = 0;
                foreach (int temp in array2)
                {
                    if (temp == child && a != b)
                    {
                        count++;
                        b++;
                        Debug.Log(b);
                        break;
                    }
                }
                if (count == 0) soDuyNhat += child + ",";
                a++;
             }
             Debug.Log(soDuyNhat);

            ////mang 2 chieu
            //soDuyNhat = "";
            //count= 0;
            //int count1 = 0;
            //foreach (int child in array2)
            //{
            //    count1 = 0;
            //    foreach (int temp in array2)
            //    {
            //        if (count1 == array2.Length - 1 && temp == child) soDuyNhat += child + ",";
            //        if (count1 == count) 
            //        {
            //            count1++;
            //            continue; 
            //        }
            //        if (temp == child) break;
            //        if (count1 == array2.Length - 1) soDuyNhat += child + ",";
            //        count1++;
            //    }
            //    count++;

       
        }

        int[] SoDuyNhatReturnValue()
        {
            int count = 0;
            int[] resultArray = new int[0] { };
            int index = 0;

            ////mang 1 chieu
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    count = 0;
            //    for (int j = 0; j < array1.Length; j++)
            //    {
            //        if (array1[j] == array1[i] && i != j)
            //        {
            //            count++;
            //            break;
            //        }
            //    }
            //    if (count != 0) continue;
            //    index = resultArray.Length;
            //    Array.Resize(ref resultArray, index + 1);
            //    resultArray[index] = array1[i];
            //}
            //return resultArray;

            //mang 2 chieu
            count = 0;
            int a = 0;
            int b = 0;
            foreach (int child in array2)
            {
                b = 0;
                count = 0;
                foreach (int temp in array2)
                {
                    if (temp == child && b != a)
                    {
                        count++;
                        break;
                    }
                    b++;
                }
                if (count != 0)
                {
                    a++;
                    continue; 
                }
                a++;
                index = resultArray.Length;
                Array.Resize(ref resultArray, index + 1);
                resultArray[index] = child;
            }
            return resultArray;


        }

        void Calculate()
        {
            //mang 1 chieu
            string soChan = "";
            string soLe = "";
            int tong = 0;
            int tich = 1;
            foreach (int child in array1)
            {
                if (child % 2 == 0) soChan += child + ",";
                else soLe += child + ",";

                tong += child;
                tich *= child;
            }

            Debug.Log($"So chan: {soChan}");
            Debug.Log($"So le: {soLe}");
            Debug.Log($"Tong cac so la: {tong}");
            Debug.Log($"Tich cac so la: {tich}");

            //mang 2 chieu
            Debug.Log("Mang 2 chieu");

            soChan = "";
            soLe = "";
            tong = 0;
            tich = 1;
            foreach (int child in array2)
            {
                if (child % 2 == 0) soChan += child + ",";
                else soLe += child + ",";

                tong += child;
                tich *= child;
            }

            Debug.Log($"So chan: {soChan}");
            Debug.Log($"So le: {soLe}");
            Debug.Log($"Tong cac so la: {tong}");
            Debug.Log($"Tich cac so la: {tich}");
        }
        int CalculateTongTich(PhepTinh pheptinh, int[] array = null, int[,] array1 = null)
        {
            int tong = 0;
            int tich = 1;
            if (array == null)
            {
                foreach (int child in array1)
                {
                    tong += child;
                    tich *= child;
                }
            }
            if (array1 == null) 
            { 
            foreach (int child in array)
            {
                tong += child;
                tich *= child;
            }
            }
            return pheptinh == 0 ? tong : tich;
        }

        string CalculateChanLe(int pheptinh)
        {
            //mang 1 chieu
            string soChan = "";
            string soLe = "";
            foreach (int child in array1)
            {
                if (child % 2 == 0) soChan += child + ",";
                else soLe += child + ",";

            }


            //mang 2 chieu
            Debug.Log("Mang 2 chieu");

            soChan = "";
            soLe = "";
            foreach (int child in array2)
            {
                if (child % 2 == 0) soChan += child + ",";
                else soLe += child + ",";

            }

            //Debug.Log($"So chan: {soChan}");
            //Debug.Log($"So le: {soLe}");

            return pheptinh %2 == 0 ? soChan : soLe;
        }
    }
}


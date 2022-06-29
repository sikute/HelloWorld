using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SIRO.HomeWorks.Day4
{

    public class HomeWork1 : MonoBehaviour
    {
        public enum PhepTinh
        {
            Tong,
            Tich
        }
        int[] array1 = { 1, 1, 2, 4, 2, 6, 1, 7, 8, 6, 5 };
        int[,] array2 =
            {
                { 1, 2, 4, 2, 6, 1, 7, 8, 6, 5},
                { 7, 3, 0, 9, 1, 8, 6, 10, 11, 17},
                { 10, 21, 1, 3, 5, 9, 2, 4, 12, 18}
            };
        private void Start()
        {
            //SoGiongNhau();

            int[] result = SoGiongNhauReturnValue();
            ArrayToString(result);

            //int[] result = SoDuyNhatReturnValue();
            //ArrayToString(result);

            //SoDuyNhat();

            //Calculate();

            //Debug.Log(CalculateChanLe(7));
            //Debug.Log(CalculateTongTich(PhepTinh.Tich,array1,null));
            //Debug.Log(CalculateTongTich(PhepTinh.Tich,null,array2));


        }
        void ArrayToString(int[] array)
        {
            string str = "[";
            foreach (int child in array)
            {
                str += child + ",";
            }
            str = str.Substring(0, str.Length - 1) + "]";
            Debug.Log(str);
        }
        void SoGiongNhau()
        {
            string str ="";
            int count;

            ////mang 1 chieu
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    if (IsNumberChecked(i)) continue;
            //    count = 0;
            //    for (int j = 0; j < array1.Length; j++)
            //    {
            //        if (array1[j] == array1[i] && i != j) count++;
            //    }
            //    if (count == 0) continue;
            //    count++;
            //    while (count > 0)
            //    {
            //        str += array1[i] + ",";
            //        count--;
            //    }
            //}
            //Debug.Log($"So giong nhau la: {str}");

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

                count = 1;
                indexT = 0;
                foreach (int temp in array2)
                {
                    if (temp == child && indexT != indexC) count++;
                    indexT++;
                }
                if (count > 1)
                {
                    while (count > 0)
                    {
                        str += child + ",";
                        count--;
                    }
                }
                indexC++;
            }
            Debug.Log($"So giong nhau la: {str}");
        }

        int[] SoGiongNhauReturnValue()
        {
            //string str;
            int sameNumber;
            int indexOfResult = 0;
            int[] resultArray = new int[0] { };

            ////mang 1 chieu
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    if (IsNumberCheckedReturnValue1(array1[i], resultArray)) continue;
            //    sameNumber = 1;
            //    for (int j = 0; j < array1.Length; j++)
            //    {
            //        if (array1[j] == array1[i] && i != j) sameNumber++;
            //    }
            //    if (sameNumber == 1) continue;
            //    while (sameNumber > 0)
            //    {
            //        Array.Resize(ref resultArray, indexOfResult + 1);
            //        resultArray[indexOfResult] = array1[i];
            //        sameNumber--;
            //        indexOfResult++;
            //    }
            //}
            //return resultArray;


            //mang 2 chieu
            int indexOfChild = 0;
            int indexOfTemp;
            foreach (int child in array2)
            {
                if (IsNumberCheckedReturnValue2(child, resultArray))
                {
                    indexOfChild++;
                    continue;
                }

                sameNumber = 1;
                indexOfTemp = 0;

                foreach (int temp in array2)
                {
                    if (temp == child && indexOfTemp != indexOfChild) sameNumber++;
                    indexOfTemp++;
                }
                if (sameNumber > 1)
                {
                    while (sameNumber > 0)
                    {
                        Array.Resize(ref resultArray, indexOfResult + 1);
                        resultArray[indexOfResult] = child;
                        sameNumber--;
                        indexOfResult++;
                    }
                }
                indexOfChild++;
            }

            return resultArray;

        }
        #region CheckedNumberBoolen
        /// <summary>
        /// use for array 1 direction in method not return value
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        bool IsNumberChecked(int a)
        {
            if (a == 0) return false;
            for (int i = 0; i < a; i++)
            {
                if (array1[i] == array1[a]) return true;

            }
            return false;
        }
        /// <summary>
        /// use for array 1 direction in method return value
        /// </summary>
        /// <param name="a"></param>
        /// <param name="array"></param>
        /// <returns></returns>
        bool IsNumberCheckedReturnValue1(int a, int[] array)
        {
            if (array == null || array.Length == 0) return false;
            foreach (int child in array)
            {
                if (child == a) return true;
            }
            return false;
        }
        /// <summary>
        /// use for array 2 direction in method not return value
        /// </summary>
        /// <param name="count"></param>
        /// <param name="child"></param>
        /// <returns></returns>
        bool IsNumberChecked(int count, int child)
        {
            if (count == 0) return false;
            int count1 = 0;
            foreach (int temp in array2)
            {
                if (temp == child) return true;
                if (count1 == count - 1) break;
                count1++;
            }
            return false;
        }
        /// <summary>
        /// Use for array 2 direction in method return value
        /// </summary>
        /// <param name="child"></param>
        /// <param name="array"></param>
        /// <returns></returns>
        bool IsNumberCheckedReturnValue2(int child, int[] array)
        {
            if (array == null || array.Length == 0) return false;
            foreach (int temp in array)
            {
                if (temp == child) return true;
            }
            return false;
        }
        #endregion

        void SoDuyNhat()
        {
            string soDuyNhat = "";
            int count = 0;

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
            //    if (count == 0) soDuyNhat += array1[i] + ",";
            //}
            //Debug.Log(soDuyNhat);

            //mang 2 chieu
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
                        break;
                    }
                    b++;
                }
                if (count == 0) soDuyNhat += child + ",";
                a++;
             }
             Debug.Log(soDuyNhat);

                   
        }

        int[] SoDuyNhatReturnValue()
        {
            int[] resultArray = new int[0] { };
            int indexOfResult;
            int sameNumber;

            ////mang 1 chieu
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    sameNumber = 0;
            //    for (int j = 0; j < array1.Length; j++)
            //    {
            //        if (array1[j] == array1[i] && i != j)
            //        {
            //            sameNumber++;
            //            break;
            //        }
            //    }
            //    if (sameNumber != 0) continue;
            //    indexOfResult = resultArray.Length;
            //    Array.Resize(ref resultArray, indexOfResult + 1);
            //    resultArray[indexOfResult] = array1[i];
            //}
            //return resultArray;

            //mang 2 chieu
            int indexOfChild = 0;
            int indexOfTemp;
            foreach (int child in array2)
            {
                indexOfTemp = 0;
                sameNumber = 0;
                foreach (int temp in array2)
                {
                    if (temp == child && indexOfTemp != indexOfChild)
                    {
                        sameNumber++;
                        break;
                    }
                    indexOfTemp++;
                }
                if (sameNumber == 0)
                {
                    indexOfResult = resultArray.Length;
                    Array.Resize(ref resultArray, indexOfResult + 1);
                    resultArray[indexOfResult] = child;
                }
                indexOfChild++;
            }
            return resultArray;

        }

        void Calculate()
        {
            //mang 1 chieu
            string soChan = "", soLe = "";
            int tong = 0, tich = 1;
            foreach (int child in array1)
            {
                if (child % 2 == 0) soChan += child + ",";
                else soLe += child + ",";

                tong += child;
                tich *= child;
            }
            Debug.Log("Ket qua mang 1 chieu:");
            Debug.Log($"So chan: {soChan}, So le: {soLe}, Tong cac so: {tong}, Tich cac so: {tich}");


            //mang 2 chieu
            soLe = ""; soChan = "";
            tong = 0; tich = 1;
            foreach (int child in array2)
            {
                if (child % 2 == 0) soChan += child + ",";
                else soLe += child + ",";

                tong += child;
                tich *= child;
            }
            Debug.Log("Ket qua mang 2 chieu:");
            Debug.Log($"So chan: {soChan}, So le: {soLe}, Tong cac so: {tong}, Tich cac so: {tich}" );
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
            return pheptinh %2 == 0 ? soChan : soLe;
        }
    }
}


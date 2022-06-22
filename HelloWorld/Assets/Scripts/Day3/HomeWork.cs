using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SIRO.HomeWorks.Day3
{

public class HomeWork : MonoBehaviour
{
        const string TONG = "tong";
        const string HIEU = "hieu";
        const string THUONG = "thuong";
        const string TICH = "tich";
        const string CHAN = "chan";
        const string LE = "le";


        //int a = 5;
        //int b = 8;

        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] array1 = { 2, 4, 6, 7, 8, 9, 11, 2, 3, 0, 1, 5, 6, 15, 24, 21 };
        private void Start()
        {
            //Calculate(a, b, TONG);
            //Calculate(a, b, HIEU);
            //Calculate(a, b, THUONG);
            //Calculate(a, b, TICH);
            //Calculate(a, b, "");

            //float tong = CalculateReturnValue(a, b, TONG);
            //Debug.Log(tong);
            //float hieu = CalculateReturnValue(a, b, HIEU);
            //Debug.Log(hieu);
            //float thuong = CalculateReturnValue(a, b, THUONG);
            //Debug.Log(thuong);
            //float tich = CalculateReturnValue(a, b, TICH);
            //Debug.Log(tich);
            //float test = CalculateReturnValue(a, b, "");
            //Debug.Log(test);

            //TongChanLe();
            //int tongSoChan = TongChanLeReturnValue(CHAN);
            //int tongSoLe = TongChanLeReturnValue(LE);
            //Debug.Log($"Tong so chan la: {tongSoChan} \nTong so le la: {tongSoLe}");

            //TongCacSo();
            //int tong = TongCacSoReturnValue();
            //Debug.Log(tong);

            TimSoNguyenTo();
            string soNguyenTo = TimSoNguyenToReturnValue(array1);
            Debug.Log($"So nguyen to cua {nameof(array1)} la {soNguyenTo}");
        }


        void Calculate(int a, int b, string phepTinh)
        {
            switch (phepTinh)
            {
                case TONG:
                    Debug.Log($"Tong: {a} + {b} = {a + b}");
                    break;
                case HIEU:
                    Debug.Log($"Hieu: {a} - {b} = {a - b}");
                    break;
                case THUONG:
                    Debug.Log($"Thuong: {a} / {b} = {a / b}");
                    break;
                case TICH:
                    Debug.Log($"Tich: {a} * {b} = {a * b}");
                    break;
                default:
                    Debug.Log("Phep tinh khong ton tai");
                    break;
            }


        }

        float CalculateReturnValue(int a, int b, string phepTinh)
        {
            switch (phepTinh)
            {
                case TONG:
                    //Debug.Log($"Tong: {a} + {b} = {a + b}");
                    return a + b;
                case HIEU:
                    //Debug.Log($"Hieu: {a} - {b} = {a - b}");
                    return a - b;
                case THUONG:
                    //Debug.Log($"Thuong: {a} / {b} = {a / b}");
                    return a / b;
                case TICH:
                   // Debug.Log($"Tich: {a} * {b} = {a * b}");
                    return a * b;
                default:
                    Debug.Log("Phep tinh khong ton tai");
                    return 0;
            }

        }

        void TongChanLe()
        {
            //tong so chan,le trong array
            //for
            int tongSoChan = 0;
            int tongSoLe = 0;
            for (int i=0; i< array.Length; i++)
            {
                if (array[i] % 2 == 0) tongSoChan += array[i];
                else tongSoLe += array[i];
            }
            Debug.Log($"Tong so chan la:{tongSoChan}");
            Debug.Log($"Tong so le la:{tongSoLe}");

            //while
            int count = 0;
            tongSoChan = 0;
            tongSoLe = 0;
            while(count < array.Length)
            {
                if (array[count] % 2 == 0) tongSoChan += array[count];
                else tongSoLe += array[count];
                count++;
            }
            Debug.Log($"Tong so chan la:{tongSoChan}");
            Debug.Log($"Tong so le la:{tongSoLe}");

            //dowhile
            count = 0;
            tongSoChan = 0;
            tongSoLe = 0;
            do
            {
                if (array[count] % 2 == 0) tongSoChan += array[count];
                else tongSoLe += array[count];
                count++;
            } while (count < array.Length);
            Debug.Log($"Tong so chan la:{tongSoChan}");
            Debug.Log($"Tong so le la:{tongSoLe}");
        }

        int TongChanLeReturnValue(string requirement)
        {
            //tong so chan,le trong array
            //for
            int tongSoChan = 0;
            int tongSoLe = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) tongSoChan += array[i];
                else tongSoLe += array[i];
            }

            //while
            int count = 0;
            tongSoChan = 0;
            tongSoLe = 0;
            while (count < array.Length)
            {
                if (array[count] % 2 == 0) tongSoChan += array[count];
                else tongSoLe += array[count];
                count++;
            }

            //dowhile
            count = 0;
            tongSoChan = 0;
            tongSoLe = 0;
            do
            {
                if (array[count] % 2 == 0) tongSoChan += array[count];
                else tongSoLe += array[count];
                count++;
            } while (count < array.Length);

            switch (requirement)
            {
                case "chan": 
                    return tongSoChan;
                case "le": 
                    return tongSoLe;
                default:
                    Debug.Log("yeu cau khong hop le");
                    return 0;
            }
        }

        void TongCacSo()
        {

            //for
            int tong = 0;
            for (int i = 0; i < array.Length; i++)
            {
                tong += array[i];
            }
            Debug.Log($"Tong cac so la {tong}");

            //while
            tong = 0;
            int count = 0;
            while(count < array.Length)
            {
                tong += array[count];
                count++;
            }
            Debug.Log($"Tong cac so la {tong}");

            //dowhile
            tong = 0;
            count = 0;
            do
            {
                tong += array[count];
                count++;
            } while (count < array.Length);
            Debug.Log($"Tong cac so la {tong}");

        }

        int TongCacSoReturnValue()
        {
            int tong = 0;
            foreach (int child in array)
            {
                tong += child;
            }
            return tong;
        }

        void TimSoNguyenTo() 
        {
            //for
            string tapHopSNT = "";

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 2) continue;
                if (array[i] == 2 || array[i] == 3)
                {
                    tapHopSNT += array[i] + ",";
                    continue;
                }

                for (int j = 2; j < array[i]; j++)
                {
                    if (array[i] % j == 0) break;
                    if (j == array[i] - 1) tapHopSNT += array[i] + ",";
                }
            }
            Debug.Log($"For: So nguyen to la: [{tapHopSNT}]");

            //while
            tapHopSNT = "";
            int count = 0;
            while(count < array.Length)
            {
                if (array[count] < 2)
                {
                    count++;
                    continue;
                }
                if(array[count] == 2 || array[count] == 3)
                {
                    tapHopSNT += array[count] + ",";
                    count++;
                    continue;
                }
                int i = 2;
                while(i < array[count])
                {
                    if (array[count] % i == 0) break;
                    if (i == array[count] - 1) tapHopSNT += array[count] + ",";
                    i++;
                }
                count++;
            }
            Debug.Log($"While: So nguyen to la: [{tapHopSNT}]");

            //dowhile
            tapHopSNT = "";
            count = 0;

            do
            {
                if (array[count] < 2) 
                {
                    count++;
                    continue;
                }
                if (array[count] == 2 || array[count] == 3)
                {
                    tapHopSNT += array[count] + ",";
                    count++;
                    continue;
                }
                int i = 2;
                while (i < array[count])
                {
                    if (array[count] % i == 0) break;
                    if (i == array[count] - 1) tapHopSNT += array[count] + ",";
                    i++;
                }
                count++;
            } while (count < array.Length);

            Debug.Log($"Dowhile: So nguyen to la: [{tapHopSNT}]");
        }


        string TimSoNguyenToReturnValue(int[] array)
        {
            //for
            string tapHopSNT = "";

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 2) continue;
                if (array[i] == 2 || array[i] == 3)
                {
                    tapHopSNT += array[i] + ",";
                    continue;
                }

                for (int j = 2; j < array[i]; j++)
                {
                    if (array[i] % j == 0) break;
                    if (j == array[i] - 1) tapHopSNT += array[i] + ",";
                }
            }

            //while
            tapHopSNT = "";
            int count = 0;
            while (count < array.Length)
            {
                if (array[count] < 2)
                {
                    count++;
                    continue;
                }
                if (array[count] == 2 || array[count] == 3)
                {
                    tapHopSNT += array[count] + ",";
                    count++;
                    continue;
                }
                int i = 2;
                while (i < array[count])
                {
                    if (array[count] % i == 0) break;
                    if (i == array[count] - 1) tapHopSNT += array[count] + ",";
                    i++;
                }
                count++;
            }

            //dowhile
            tapHopSNT = "";
            count = 0;

            do
            {
                if (array[count] < 2)
                {
                    count++;
                    continue;
                }
                if (array[count] == 2 || array[count] == 3)
                {
                    tapHopSNT += array[count] + ",";
                    count++;
                    continue;
                }
                int i = 2;
                while (i < array[count])
                {
                    if (array[count] % i == 0) break;
                    if (i == array[count] - 1) tapHopSNT += array[count] + ",";
                    i++;
                }
                count++;
            } while (count < array.Length);


            return tapHopSNT;
        }


    }
}

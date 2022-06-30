using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SIRO.HomeWorks.Day7 {
    
    public class HomeWork: MonoBehaviour
    {
        public PC myPc;
        private void Start()
        {
            myPc = new PC();
            PC.ChuSoHuu = "Siro";
            PC.DiaChiWifi = "192.168.0.1";
            PC.TocDoWifi = 15.5f;
            Debug.Log("Chu so huu: " + PC.ChuSoHuu);
            Debug.Log("Dia chi Wifi: " + PC.DiaChiWifi);
            Debug.Log("Toc Do Wifi: " + PC.TocDoWifi);
            myPc.KhoiDong();
            myPc.TatMay();
            myPc.EpXung();
            myPc.TruyenDuLieu();
            myPc.NhanDuLieu();
        }


    }
    public class PC
    {
        public static string DiaChiWifi;
        public static float TocDoWifi;
        public static string ChuSoHuu;
        string m_case;
        string mainBoard;
        string ram;
        string cpu;
        string psu;
        string cooler;
        string fan;
        public PC()
        {
            m_case = "Asus";
            mainBoard = "Asus";
            ram = "Gskill";
            cpu = "AMDRyzen";
            psu = "Asus";
            cooler = "Asus";
            fan = "Infinity";
        }
        public PC(string m_case, string mainBoard, string ram, string cpu,string psu,string cooler, string fan)
        {
            this.m_case = m_case;
            this.mainBoard = mainBoard;
            this.ram = ram;
            this.cpu = cpu;
            this.psu = psu;
            this.cooler = cooler;
            this.fan = fan;
        }

        ~PC()
        {

        }
        public void KhoiDong()
        {
            Debug.Log("Khoi dong may");
        }
        public void TatMay()
        {
            Debug.Log("Tat may");

        }
        public void EpXung()
        {
            Debug.Log("Ep xung");

        }
        public void TruyenDuLieu()
        {
            Debug.Log("Truyen du lieu");

        }
        public void NhanDuLieu()
        {
            Debug.Log("Nhan du lieu");

        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SIRO.Practices.Day7
{

    public class Practices : MonoBehaviour
    {
        private void Start()
        {
            Enemy enemy = new Enemy(1);
            Enemy.lifeTime = 4;
            Debug.Log(Enemy.lifeTime);
            Enemy.CalculateLifeTime();
            Helper.GetDistance();
            //enemy.Bonus = 1;
            //Debug.Log(enemy.Bonus);
        }
    }
    public static class Helper
    {
        public static float distance;
        public static float GetDistance()
        {
            return distance;
        }
    }
    public class Enemy
    {
        public static float moveSpeed;
        public float detectDist;
        public float damage;
        private int bonus;
        protected float skillRate;
        public static float lifeTime;
        public int Bonus 
        {
            get => bonus; // get {return bonus;}
            set { if (value > 5) bonus = value; } }

        public static void CalculateLifeTime()
        {

        }
        static Enemy()
        {
            moveSpeed = 1;
            Debug.Log("Enemy constructor static");
        }
        public Enemy()
        {
            Debug.Log("Day la phuong thuc khoi tao khong co tham so truyen vao");
        }
        public Enemy(float move1Speed)
        {
            Move();
            moveSpeed = move1Speed;
            Debug.Log("Phuong thuc khoi tao move speed");
        }
        public Enemy(int bonus)
        {
            Debug.Log("Constructor int type");
        }
        public Enemy(float move1Speed, float detectDist, float damage)
        {
            moveSpeed = move1Speed;
            this.detectDist = detectDist;
            this.damage = damage;
            Debug.Log("Day la phuong thuc khoi tao co tham so");
        }
        static void Move()
        {
            
        }
        ~Enemy()
        {

        }
        public void DetectPlayer()
        {

        }
        public void Die()
        {

        }
        protected void SkillCountDown()
        {

        }
    }
    public class Boss : Enemy
    {
        public void Testing()
        {
            skillRate = 6;
        }
    }
}


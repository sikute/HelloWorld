using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SIRO.Practices.Day8
{

    public class Practices : MonoBehaviour
    {
        private void Start()
        {
            Enemy boss = new Boss();
            boss.Move();
        }
    }
    public abstract class Enemy
    {
        private float hp;
        public float damage;
        public float movespeed;

        public Enemy()
        {
            Debug.Log("Cha");
        }

        public Enemy(float dmg)
        {
            Debug.Log("Cha 1 tham so float");
        }
        public Enemy(int dmg)
        {
            Debug.Log("Cha 1 tham so int");
        }
        public Enemy(float hp, float dmg)
        {
            Debug.Log("Cha 2 tham so");
        }
        public Enemy(float hp, float dmg, float moveSpeed)
        {

        }
        public virtual void Move()
        {
            Debug.Log("Move cua Enemy");
        }
        public abstract void Die();

    }
    public class Boss: Enemy, IEnemy, IOther
    {
        public Boss()
        {
            Debug.Log("Con");
        }
        public Boss(float hpCopy,float dmgCopy)  : base(hpCopy)
        {
            Debug.Log("Con");
        }
        public Boss(float hp): base(hp)
        {
            Debug.Log("Con");
        }
        public override void Move()
        {
            Debug.Log("Move cua Boss");
        }
        public void Move(float moveSpeed)
        {

        }
        public void Eat()
        {

        }
        public override void Die()
        {
            
        }

        public void GetHit(int dmg)
        {
            Debug.Log("Get hit" + dmg);
        }
    }
    public interface IOther : IEnemy
    {

    }
    public interface IEnemy
    {
        public void GetHit(int dmg);
    }
}

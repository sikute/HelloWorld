using UnityEngine;

namespace SIRO.HomeWorks.Day8.B1
{

    public class AnimalB1
{
        public string name;
        public string enviroment;
        public string food;
        public virtual void Move() 
        { 
        }
        public virtual void Eat()
        {
        }
        public virtual void Eat(string food)
        {
        }
        public virtual void Sound()
        {
        }
    }

    public class Cat : AnimalB1
    {
        public override void Move()
        {
            Debug.Log("Di bang bon chan");
        }
        public override void Eat()
        {
            Debug.Log("An thit");
        }
        public override void Eat(string food)
        {
        }
        public override void Sound()
        {
            Debug.Log("Keu meo meo");
        }
    }
    public class Bird: AnimalB1
    {
        public override void Move()
        {
            Debug.Log("Bay bang canh");
        }
        public override void Eat()
        {
            Debug.Log("An sau bo");
        }
        public override void Eat(string food)
        {
        }
        public override void Sound()
        {
            Debug.Log("Hot");
        }
    }
    public class Fish : AnimalB1
    {
        public override void Move()
        {
            Debug.Log("Boi");
        }
        public override void Eat()
        {
            Debug.Log("An tao, sinh vat nho");
        }
        public override void Eat(string food)
        {
        }
        public override void Sound()
        {
            Debug.Log("Quay nuoc");
        }
    }
}

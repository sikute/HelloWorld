using UnityEngine;

namespace SIRO.HomeWorks.Day8.B2
{

    public abstract class AnimalB3
    {
        public string name;
        public string enviroment;
        public string food;
        public abstract void Move();
        public abstract void Eat();
        public abstract void EatWhat();
        public abstract void Sound();
    }

    public class Cat : AnimalB3
    {
        public override void Move()
        {
            Debug.Log("Di bang bon chan");
        }
        public override void Eat()
        {
            
        }
        public override void EatWhat()
        {
            Debug.Log("An thit");
        }
        public override void Sound()
        {
            Debug.Log("Keu meo meo");
        }
    }
    public class Bird: AnimalB3
    {
        public override void Move()
        {
            Debug.Log("Bay bang canh");
        }
        public override void Eat()
        {

        }
        public override void EatWhat()
        {
            Debug.Log("An sau bo");
        }
        public override void Sound()
        {
            Debug.Log("Hot");
        }

       
    }
    public class Fish : AnimalB3
    {
        public override void Move()
        {
            Debug.Log("Boi");
        }
        public override void Eat()
        {

        }
        public override void EatWhat()
        {
            Debug.Log("An tao, sinh vat nho");
        }
        public override void Sound()
        {
            Debug.Log("Quay nuoc");
        }
    }
}

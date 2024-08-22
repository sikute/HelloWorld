using UnityEngine;

namespace SIRO.HomeWorks.Day8.B3
{

    public class AnimalB3
    {
        public string name;
        public string enviroment;
        public string food;
    }
    public interface IAnimal
    {
        public void Move();
        public void Eat();
        public void Eat(string food);
        public void Sound();


    }
    public class Cat : AnimalB3, IAnimal
    {
        public void Move()
        {
            Debug.Log("Di bang bon chan");
        }
        public void Eat()
        {
            Debug.Log("An thit");
        }
        public void Sound()
        {
            Debug.Log("Keu meo meo");
        }

        public void Eat(string food)
        {
        }
    }
    public class Bird: AnimalB3, IAnimal
    {
        public void Move()
        {
            Debug.Log("Bay bang canh");
        }
        public void Eat()
        {
            Debug.Log("An sau bo");
        }
        public void Sound()
        {
            Debug.Log("Hot");
        }

        public void Eat(string food)
        {
        }
    }
    public class Fish : AnimalB3,IAnimal
    {
        public void Move()
        {
            Debug.Log("Boi");
        }
        public void Eat()
        {
            Debug.Log("An tao, sinh vat nho");
        }
        public void Sound()
        {
            Debug.Log("Quay nuoc");
        }

        public void Eat(string food)
        {
        }
    }
}

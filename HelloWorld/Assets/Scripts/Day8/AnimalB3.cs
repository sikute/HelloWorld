using UnityEngine;

namespace SIRO.HomeWorks.Day8.B3
{

    public class AnimalB3
    {
        public string name;
        public string enviroment;
        public string food;
    }
    public interface IMove
    {
        public void Move();
    }
    public interface IEat
    {
        public void Eat();
    }
    public interface IEatWhat
    {
        public void EatWhat();
    }
    public interface ISound
    {
        public void Sound();
    }
    public class Cat : AnimalB3, IMove, IEatWhat, ISound
    {
        public void Move()
        {
            Debug.Log("Di bang bon chan");
        }
        public void EatWhat()
        {
            Debug.Log("An thit");
        }
        public void Sound()
        {
            Debug.Log("Keu meo meo");
        }
    }
    public class Bird: AnimalB3, IMove, IEatWhat,ISound
    {
        public void Move()
        {
            Debug.Log("Bay bang canh");
        }
        public void EatWhat()
        {
            Debug.Log("An sau bo");
        }
        public void Sound()
        {
            Debug.Log("Hot");
        }
    }
    public class Fish : AnimalB3,IMove,IEatWhat,ISound
    {
        public void Move()
        {
            Debug.Log("Boi");
        }
        public void EatWhat()
        {
            Debug.Log("An tao, sinh vat nho");
        }
        public void Sound()
        {
            Debug.Log("Quay nuoc");
        }
    }
}

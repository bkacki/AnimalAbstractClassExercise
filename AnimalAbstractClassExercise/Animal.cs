using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstractClassExercise
{
    interface ISwimmer
    {
        void Swim();
    }

    interface IPackHunter
    {
        void HuntInPack();
    }

    abstract class Animal
    {
        public abstract void MakeNoise();
    }

    class Hippo : Animal, ISwimmer
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Chrząkanie");
        }

        public void Swim()
        {
            Console.WriteLine("Plusk! Idę popływać");
        }
    }

    abstract class Canine : Animal
    {
        public bool BelongsToPack { get; protected set; } = false;
    }

    class Wolf : Canine, IPackHunter
    {
        public Wolf(bool belongsToPack)
        {
            BelongsToPack = belongsToPack;
        }

        public override void MakeNoise()
        {
            if (BelongsToPack) Console.WriteLine("Należę do stada!");
            Console.WriteLine("Auuuuuuuu!");
        }

        public void HuntInPack()
        {
            if (BelongsToPack) Console.WriteLine("Wybieram się na polowanie z moim stadem.");
            else Console.WriteLine("Nie należę do stada.");
        }
    }
}

using System;

namespace Task2_animal
{
    internal class Dog : Animal
    {

        public Dog(int speed) : base(speed)
        {
        }

        public override string Move()
        {
            speed = Math.Min(speed + 5, 35);
            string ext = "Собака двигается со скоростью " + speed.ToString() + " км/ч";
            return ext;
        }

        public override string Stand()
        {
            speed = Math.Max(speed - 5, 0);
            string ext = "Собака двигается со скоростью " + speed.ToString() + " км/ч";
            return ext;
        }

        public string Voice()
        {
            return "Лай собаки";
        }

    }
}

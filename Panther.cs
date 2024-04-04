using System;

namespace Task2_animal
{
    internal class Panther : Animal
    {

        public Panther(int speed) : base(speed)
        {
        }

        public override string Move()
        {
            speed = Math.Min(speed + 5, 100);
            string ext = "Пантера двигается со скоростью " + speed.ToString() + " км/ч";
            return ext;
        }

        public override string Stand()
        {
            speed = Math.Max(speed - 5, 0);
            string ext = "Пантера двигается со скоростью " + speed.ToString() + " км/ч";
            return ext;
        }

        public string Voice()
        {
            return "Рычание пантеры";
        }

        public string Climb()
        {
            return "Пантера залезла на дерево";
        }
    }
}

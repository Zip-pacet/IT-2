namespace Task2_animal
{
   
    internal class Animal
    {
        protected int speed;

        public Animal(int speed)
        {
            this.speed = speed;
        }

        public virtual string Move()
        {
            return "Животное двигается";
        }

        public virtual string Stand()
        {
            return "Животное останавливается";
        }
    }
}

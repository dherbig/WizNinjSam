using System;
namespace WizNinjSam
{
    public class Wizard : Human
    {

        public Wizard(string Nombre) : base(Nombre)
        {
            health = 50;
            intelligence = 25;
        }
        public void Heal()
        {
            this.health += 10*this.intelligence;
        }
        public void Fireball(Object obj)
        {
            if (obj is Human)
            {
                Human target = (Human)obj;
                target.health -= rand.Next(20, 50);
            }
        }
    }
}
using System;

namespace WizNinjSam
{
    public class Ninja : Human
    {
        public Ninja(string Nombre) : base(Nombre)
        {
            dexterity = 175;
        }
        public void Steal(Object obj)
        {
            if (obj is Human)
            {
                attack(obj);
                this.health += 10;
            }
        }
        public void Get_Away()
        {
            this.health -= 15;
        }
    }
}
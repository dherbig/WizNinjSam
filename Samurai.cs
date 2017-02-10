using System;

namespace WizNinjSam
{
    public class Samurai : Human
    {
        public Samurai(string Nombre) : base(Nombre)
        {
            health = 200;
        }

        public void death_blow(Object obj)
        {
            if (obj is Human)
            {
                attack(obj);
                Human target = (Human)obj;
                if (target.health < 50)
                {
                    target.health = 0;
                }   
            }
        }
        public void meditate()
        {
            health = 200;
        }
    }

}
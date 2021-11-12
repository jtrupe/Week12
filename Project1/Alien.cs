using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
     class Alien
    {
        private string name;
        private int health;
        protected int atk = 0;

        public void SetName(string nm)
        {
            name = nm;
        }
        public string GetName()
        {
            return name;
        }
        public void SetHealth(int hp)
        {
            health = hp;
        }
        public int GetHealth()
        {
            return health;
        }
        public int GetDamage()
        {
            return atk;
        }
    }

    class SnakeAlien : Alien
    {
        public SnakeAlien(string nm, int hp)
        {
            atk = 10;
            SetName(nm);
            SetHealth(hp);
        }
    }

    class OgreAlien: Alien
    {
        public OgreAlien(string nm, int hp)
        {
            atk = 6;
            SetName(nm);
            SetHealth(hp);
        }
    }

    class MarshmallowMan : Alien
    {
        public MarshmallowMan(string nm, int hp)
        {
            atk = 1;
            SetName(nm);
            SetHealth(hp);
        }
    }

    class AlienPack
    {
        private Alien[] aliens;

        public AlienPack(int numAliens)
        {
            aliens = new Alien[numAliens];
        }

        public void AddAlien(Alien newAlien, int index)
        {
            aliens[index] = newAlien;
        }

        public Alien[] GetAliens()
        {
            return aliens;
        }
        public int CalculateDamage()
        {
            int damage = 0;
            foreach(Alien a in aliens)
            {
                damage += a.GetDamage();
            }
            return damage;
        }
    }

}

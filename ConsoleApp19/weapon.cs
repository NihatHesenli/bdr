using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class weapon
    {
        public double CapacityBullet;
        public double CurrentBullet;
        public bool FireMood;
         

        public void Shoot()
        {
            if (FireMood == false)
            {
                Console.WriteLine("tekli");

            }
            else
            {
                Console.WriteLine("avtomatik");

            }
        }
        public void GetRemainBulletcount()
        {

            CapacityBullet-=(double)CurrentBullet;
        }
        public void ChangeFireMood();

    }
}

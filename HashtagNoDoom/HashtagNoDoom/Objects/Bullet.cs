using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HashtagNoDoom.GameWindow;

namespace HashtagNoDoom.Objects
{
    class Bullet
    {
        Shapes ammo;
        Direction direct;
        int speed;

        public Bullet(Shapes ammo, Direction direct, int speed)
        {
            this.ammo = ammo;
            this.direct = direct;
            this.speed = speed * 2;
        }

        public Shapes bullet
        {
            get
            {
                return bullet;
            }
        }

        public bool Move(int palyaW, int palyaH)
        {
            switch (direct)
            {
                case Direction.Up:
                    bullet.ChangeY(-speed); break;
                case Direction.Down:
                    bullet.ChangeY(speed); break;
                case Direction.Left:
                    bullet.ChangeX(-speed); break;
                case Direction.Right:
                    bullet.ChangeX(speed); break;

            }
            if (bullet.Area.Top <= 0 || bullet.Area.Left <= 0 || bullet.Area.Bottom >= palyaH || bullet.Area.Right >= palyaW)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}

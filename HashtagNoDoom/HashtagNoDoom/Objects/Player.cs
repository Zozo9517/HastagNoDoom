using HashtagNoDoom.GameWindow;
using HashtagNoDoom.Objects;
using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;


namespace HashtagNoDoom.Entity
{

    //TODO: CODE SIMPLIFICATION
    public class Player
    {
        public int Health;

        public BitmapImage[] player;
        public double X, Y;
        public Canvas canvas;
        public Image currentImage { get; set; }
        public Shapes playerShape;
        private ObservableCollection<Bullet> bullets = new ObservableCollection<Bullet>();

        private int currentDown = 0, currentUp = 5, currentLeft = 10, currentRight = 15;
        private int AnimTick = 0;
        private Direction elozoIrany;
        private int speed;

        public void InitPlayer(ref Image playerInstance)
        {
            currentImage = playerInstance;
            ChImSrc(player[0]); //Player Standby For the first time
        }

        public Player()
        {
            Health = 3;
            player = null;
         //   gameWindow.GetCanvasCenter(out X, out Y);
        }

        public void Move(int palyaW, int palyaH, Direction irany)
        {
            elozoIrany = irany;
            if (irany == Direction.Up && playerShape.Area.Top - speed >= 0)
            {
                playerShape.ChangeY(-speed);
            }
            else if (irany == Direction.Down && playerShape.Area.Bottom + speed <= palyaH)
            {
                playerShape.ChangeY(speed);
            }
            else if (irany == Direction.Left && playerShape.Area.Left - speed >= 0)
            {
                playerShape.ChangeX(-speed);
            }
            else if (irany == Direction.Right && playerShape.Area.Right + speed <= palyaW)
            {
                playerShape.ChangeX(speed);
            }
            else if (irany == Direction.UpRight && playerShape.Area.Right + speed <= palyaW && playerShape.Area.Top <= palyaH)
            {
                playerShape.ChangeX(speed);
                playerShape.ChangeY(-speed);
            }
            else if (irany == Direction.UpLeft && playerShape.Area.Left - speed >= 0 && playerShape.Area.Top <= palyaH)
            {
                playerShape.ChangeX(-speed);
                playerShape.ChangeY(-speed);
            }
            else if (irany == Direction.DownLeft && playerShape.Area.Left - speed >= 0 && playerShape.Area.Bottom >= 0)
            {
                playerShape.ChangeX(-speed);
                playerShape.ChangeY(speed);
            }
            else if (irany == Direction.DownRight && playerShape.Area.Right + speed <= palyaW && playerShape.Area.Bottom >= 0)
            {
                playerShape.ChangeX(speed);
                playerShape.ChangeY(speed);
            }
        }

        public void Shoot()
        {
            Shapes bullet = null;
            switch (elozoIrany)
            {
                case Direction.Up:
                    {
                        bullet = new Shapes((int)(playerShape.Area.X + playerShape.Area.Width / 2 - 2), (int)playerShape.Area.Y, 5, 5);
                        break;
                    }
                case Direction.Down:
                    {
                        bullet = new Shapes((int)(playerShape.Area.X + playerShape.Area.Width / 2 - 2), (int)(playerShape.Area.Y + playerShape.Area.Height), 5, 5);
                        break;
                    }
                case Direction.Left:
                    {
                        bullet = new Shapes((int)(playerShape.Area.X), (int)(playerShape.Area.Y + playerShape.Area.Height / 2 - 2), 5, 5);
                        break;
                    }
                case Direction.Right:
                    {
                        bullet = new Shapes((int)playerShape.Area.X + (int)playerShape.Area.Width, (int)playerShape.Area.Y + ((int)playerShape.Area.Height / 2 - 2), 5, 5);
                        break;
                    }
                case Direction.UpRight:
                    {
                        bullet = new Shapes((int)playerShape.Area.X + (int)playerShape.Area.Width, (int)playerShape.Area.Y + ((int)playerShape.Area.Height / 2 - 2), 5, 5);
                        break;
                    }
                case Direction.UpLeft:
                    {
                        bullet = new Shapes((int)playerShape.Area.X + (int)playerShape.Area.Width, (int)playerShape.Area.Y + ((int)playerShape.Area.Height / 2 - 2), 5, 5);
                        break;
                    }
                case Direction.DownRight:
                    {
                        bullet = new Shapes((int)playerShape.Area.X + (int)playerShape.Area.Width, (int)playerShape.Area.Y + ((int)playerShape.Area.Height / 2 - 2), 5, 5);
                        break;
                    }
                case Direction.DownLeft:
                    {
                        bullet = new Shapes((int)playerShape.Area.X + (int)playerShape.Area.Width, (int)playerShape.Area.Y + ((int)playerShape.Area.Height / 2 - 2), 5, 5);
                        break;
                    }
            }
            bullets.Add(new Bullet(bullet, elozoIrany, speed));
        }

        static public string moving()
        {
            //Only a placeholder
            return "";

        }

        public void SetLocation(double x, double y)
        {
            //Logging.WriteLog(String.Format("Player is at X[{0}] Y[{1} and moving to X[{2}] Y[{3}]",X,Y,x,y)); Memory can't handle this #SadPanda
            Canvas.SetLeft(currentImage, x);
            Canvas.SetTop(currentImage, y);
            X = x;
            Y = y;
        }

        private void AnimateDown()
        {
            if (AnimTick == 5)
            {
                ChImSrc(player[currentDown]);
                if (currentDown >= 4) currentDown = 0;
                else currentDown++;
                AnimTick = 0;
            }
            else
            {
                AnimTick++;

            }
        }
        private void AnimateUp()
        {
            if (AnimTick == 5)
            {
                ChImSrc(player[currentUp]);
                if (currentUp >= 9) currentUp = 5;
                else currentUp++;
                AnimTick = 0;
            }
            else
            {
                AnimTick++;

            }
        }
        private void AnimateLeft()
        {
            if (AnimTick == 5)
            {
                ChImSrc(player[currentLeft]);
                if (currentLeft >= 14) currentLeft = 10;
                else currentLeft++;
                AnimTick = 0;
            }
            else
            {
                AnimTick++;
            }

        }
        private void AnimateRight()
        {
            if (AnimTick == 5)
            {
                ChImSrc(player[currentRight]);
                if (currentRight >= 19) currentRight = 15;
                else currentRight++;
                AnimTick = 0;
            }
            else
            {
                AnimTick++;
            }
        }
        private void ChImSrc(BitmapImage bim)
        {
            currentImage.Source = bim;
        }
    }
}
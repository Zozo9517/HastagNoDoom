using HashtagNoDoom.Entity;
using HashtagNoDoom.Objects;
using HashtagNoDoom.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace HashtagNoDoom.GameWindow
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        private DispatcherTimer PlayerTimer = new DispatcherTimer();
        Player p = new Player();
        int palyaW;
        int palyaH;
        MVVM VM;

        public GameWindow()
        {
            InitializeComponent();
            DataContext = VM;
            palyaH = (int)GameCanvas.ActualHeight;
            palyaW = (int)GameCanvas.ActualWidth;
            VM = new MVVM(palyaW, palyaH);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            Image i = new Image();
            i.Width = 50;
            i.Height = 50;
            Canvas.SetLeft(i, 375);
            Canvas.SetRight(i, 375);
            GameCanvas.Children.Add(i);
      
            p.player = StaticURIs.PlayerOne_BitMaps;
            p.InitPlayer(ref i);
           
            
            
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.Up) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Left))
            {
                p.Move(palyaW, palyaH, Direction.Up); 
            }
            else if (Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Left))
            {
                p.Move(palyaW, palyaH, Direction.Down); 
            }
            else if (Keyboard.IsKeyDown(Key.Left) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Up))
            {
                p.Move(palyaW, palyaH, Direction.Left); 
            }
            else if (Keyboard.IsKeyDown(Key.Right) && !Keyboard.IsKeyDown(Key.Down) && !Keyboard.IsKeyDown(Key.Up))
            {
                p.Move(palyaW, palyaH, Direction.Right);
            }
            if ((Keyboard.IsKeyDown(Key.Up) && Keyboard.IsKeyDown(Key.Right)) || (Keyboard.IsKeyDown(Key.Right) && Keyboard.IsKeyDown(Key.Up)))
            {
                p.Move(palyaW, palyaH, Direction.UpRight);
            }
            else if ((Keyboard.IsKeyDown(Key.Down) && Keyboard.IsKeyDown(Key.Left)) || (Keyboard.IsKeyDown(Key.Left) && Keyboard.IsKeyDown(Key.Down)))
            {
                p.Move(palyaW, palyaH, Direction.DownLeft);
            }
            else if ((Keyboard.IsKeyDown(Key.Up) && Keyboard.IsKeyDown(Key.Left)) || (Keyboard.IsKeyDown(Key.Left) && Keyboard.IsKeyDown(Key.Up)))
            {
                p.Move(palyaW, palyaH, Direction.UpLeft);
            }
            else if ((Keyboard.IsKeyDown(Key.Down) && Keyboard.IsKeyDown(Key.Right)) || (Keyboard.IsKeyDown(Key.Right) && Keyboard.IsKeyDown(Key.Down)))
            {
                p.Move(palyaW, palyaH, Direction.DownRight);
            }

            else if (Keyboard.IsKeyDown(Key.Space))
            {
                //Egyszerre max 5 lövést adhat le
                //if (p.Bullets.Count < 5)
                //{
                //    p.Shoot();
                //    foreach (BulletBL item in PL.Bullets)
                //    {
                //        MyShape p = item.Bullet;
                //        Ellipse r = new Ellipse();
                //        r.DataContext = item.Bullet;
                //        r.Fill = Brushes.Red;
                //        r.SetBinding(Canvas.LeftProperty, new Binding("Area.X"));
                //        r.SetBinding(Canvas.TopProperty, new Binding("Area.Y"));
                //        r.SetBinding(Rectangle.WidthProperty, new Binding("Area.Width"));
                //        r.SetBinding(Rectangle.HeightProperty, new Binding("Area.Height"));
                //        MyCanvas.Children.Add(r);
                //    }
                //}
            }
        }
}

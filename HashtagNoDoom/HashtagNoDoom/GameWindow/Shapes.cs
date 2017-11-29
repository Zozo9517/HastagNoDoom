using System.Windows;

namespace HashtagNoDoom.GameWindow
{
    class Shapes : Binding
    {
        Rect area;

        public Rect Area
        {
            get
            {
                return area;
            }
        }

        public Shapes(int x, int y, int w, int h)
        {
            area = new Rect(x, y, w, h);
        }

        public void ChangeX(int speed)
        {
            area.X += speed;
            OnPropertyChanged("Area");
        }

        public void ChangeY(int speed)
        {
            area.Y += speed;
            OnPropertyChanged("Area");
        }

        public void SetXY(int newX, int newY)
        {
            area.X = newX;
            area.Y = newY;
            OnPropertyChanged("Area");
        }

    }
}

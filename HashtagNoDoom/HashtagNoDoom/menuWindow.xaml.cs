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
using System.Windows.Navigation;
using System.Windows.Shapes;

using HashtagNoDoom.Resources;

namespace HashtagNoDoom
{
    /// <summarys
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            LoadPictures();
            Lottery<string> lottery = new Lottery<string>();
            lottery.SetLottery(StaticURIs.TitleQuotes);
            Title += lottery.GetWinner();

        }
        public void LoadPictures()
        {
            GameTitle.Source = new BitmapImage(StaticURIs.MenuTitle);
            NewGame.Source = new BitmapImage(StaticURIs.MenuNewGame);
            Score.Source = new BitmapImage(StaticURIs.MenuScore);
            Exit.Source = new BitmapImage(StaticURIs.MenuExit);
            Settings.Source = new BitmapImage(StaticURIs.Cogwheel);
            Help.Source = new BitmapImage(StaticURIs.Help);
            Icon = new BitmapImage(StaticURIs.GameIcon);
        }

        private void ImageClick(object sender, MouseButtonEventArgs e)
        {
            Image snd = (Image)sender;

            switch (snd.Name)
            {
                case "NewGame":
                    this.Hide();
                    CharacterSelection cs = new CharacterSelection();
                    cs.Show();
                    
                    break;
                case "Settings":
                    break;
                case "Help":
                    break;
                case "Exit":
                    Environment.Exit(0);
                    break;
                case "Score":
                    MessageBox.Show("No");
                    break;
            }
        }

        private void NewGame_MouseEnter(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void NewGame_MouseLeave(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Arrow; 
        }
    }
}

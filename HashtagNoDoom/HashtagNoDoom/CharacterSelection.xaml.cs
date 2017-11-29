using HashtagNoDoom.Entity;
using HashtagNoDoom.Resources;
using HashtagNoDoom.GameWindow;

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

namespace HashtagNoDoom
{
    /// <summary>
    /// Interaction logic for CharacterSelection.xaml
    /// </summary>
    public partial class CharacterSelection : Window
    {
        public CharacterSelection()
        {
            InitializeComponent();
            playerOne_IMG.Source = StaticURIs.PlayerOne_BitMaps[0];
            playerTwo_IMG.Source = new BitmapImage(StaticURIs.Help);
            playerThree_IMG.Source = new BitmapImage(StaticURIs.Help);
        }
        private void ChoosePlayer_Click(object sender, RoutedEventArgs e)
        {
            Player p = new Player();
            //GW Show
            GameWindow.GameWindow gw = new GameWindow.GameWindow();
            p.player = StaticURIs.PlayerOne_BitMaps;
            //p.InitPlayer(ref gw.playerCurrentImage);
            Close();
            gw.Show();
        }
    }
}

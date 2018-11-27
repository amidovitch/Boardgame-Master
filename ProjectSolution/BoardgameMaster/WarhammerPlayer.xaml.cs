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

namespace BoardgameMaster
{
	/// <summary>
	/// Логика взаимодействия для WarhammerPlayer.xaml
	/// </summary>
	public partial class WarhammerPlayer : UserControl
	{
		public WarhammerPlayer()
		{
			InitializeComponent();
		}

		private void Generate_Click(object sender, RoutedEventArgs e)
		{
			Random rnd = new Random();
			Num.Text = rnd.Next(1, Int32.Parse(Num.Text)).ToString();
		}

		private void Delete_Click(object sender, RoutedEventArgs e)
		{
			Visibility = Visibility.Collapsed;
		}
	}
}

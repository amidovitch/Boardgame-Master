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

namespace BoardgameMaster
{
	/// <summary>
	/// Логика взаимодействия для Munchkin.xaml
	/// </summary>
	public partial class Munchkin : Window
	{
		public Munchkin()
		{
			InitializeComponent();
		}

		private void MunchkinPlayer_Loaded(object sender, RoutedEventArgs e)
		{

		}

		private void MunchkinPlayer_Loaded_1(object sender, RoutedEventArgs e)
		{

		}

		private void addPlayer_Click(object sender, RoutedEventArgs e)
		{
			Field.Children.Add(new MunchkinPlayer());
		}
	}
}

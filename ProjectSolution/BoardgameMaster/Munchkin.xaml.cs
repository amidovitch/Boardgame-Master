using System;
using System.Collections;
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
using System.IO;

namespace BoardgameMaster
{
	/// <summary>
	/// Логика взаимодействия для Munchkin.xaml
	/// </summary>
	public partial class Munchkin : Window
	{
		private int playerCounter;
		public Munchkin()
		{
			InitializeComponent();
		}

		private void addPlayer_Click(object sender, RoutedEventArgs e)
		{
			Field.Children.Add(new MunchkinPlayer());
			playerCounter++;
		}

		private void Save_Click(object sender, RoutedEventArgs e)
		{
			
			FileStream fstream = new FileStream(@"./Munch/save.txt", FileMode.Create);
			fstream.Close();
			using (StreamWriter write = new StreamWriter(@"./Munch/save.txt", false, System.Text.Encoding.Default))
			{
				write.WriteLine(playerCounter.ToString());
				for (int i = 0; i < playerCounter; i++)
				{
				var child = VisualTreeHelper.GetChild(Field, i);
				
					write.WriteLine(((MunchkinPlayer)child).playerName.Content);
					write.WriteLine(((MunchkinPlayer)child).playerRole.Content);
					write.WriteLine(((MunchkinPlayer)child).level.Content);
					write.WriteLine(((MunchkinPlayer)child).power.Content);
				}
			}
		}

		private void Load_Click(object sender, RoutedEventArgs e)
		{
			using (StreamReader sr = new StreamReader(@"./Munch/save.txt", System.Text.Encoding.Default))
			{
				playerCounter = Int32.Parse(sr.ReadLine());
				for (int i = 0; i < playerCounter; i++)
				{
					MunchkinPlayer mch = new MunchkinPlayer(true);
					mch.playerName.Content = sr.ReadLine();
					mch.playerRole.Content = sr.ReadLine();
					mch.power.Content = sr.ReadLine();
					mch.level.Content = sr.ReadLine();
					Field.Children.Add(mch);
				}
				sr.Close();
			}
		}
	}
}

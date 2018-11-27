﻿using System;
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
	/// Логика взаимодействия для Mafia.xaml
	/// </summary>
	public partial class Mafia : Window
	{
		public Mafia()
		{
			InitializeComponent();
		}

		private void addPlayer_Click(object sender, RoutedEventArgs e)
		{
			Field.Children.Add(new MafiaPlayer());
		}

		
	}
}

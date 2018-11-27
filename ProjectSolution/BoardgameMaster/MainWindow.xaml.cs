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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BoardgameMaster
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void MunchkinWindow_Click(object sender, RoutedEventArgs e)
		{
			Munchkin newMunchWindow = new Munchkin();
			newMunchWindow.Show();
			Close();
		}

		private void MafiaWindow_Click(object sender, RoutedEventArgs e)
		{
			Mafia newMafiaWindow = new Mafia();
			newMafiaWindow.Show();
			Close();
		}

		private void DDWindow_Click(object sender, RoutedEventArgs e)
		{
			DungDrag newDungDragWindow = new DungDrag();
			newDungDragWindow.Show();
			Close();
		}

		private void WarhammerWindow_Click(object sender, RoutedEventArgs e)
		{
			Warhammer newWarhWindow = new Warhammer();
			newWarhWindow.Show();
			Close();
		}
	}
}

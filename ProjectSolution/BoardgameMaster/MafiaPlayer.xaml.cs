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
	/// Логика взаимодействия для MafiaPlayer.xaml
	/// </summary>
	public partial class MafiaPlayer : UserControl
	{
		public MafiaPlayer()
		{
			InitializeComponent();
			ChangingInfo();
		}

		private void Delete_Click(object sender, RoutedEventArgs e)
		{
			Visibility = Visibility.Collapsed;
		}

		private void ChangingInfo()
		{
			NewInfo newInfo = new NewInfo();
			newInfo.ShowDialog();
			if (newInfo.SavingFlag)
			{
				playerName.Content = newInfo.playerName.Text;
				playerRole.Content = newInfo.playerRole.Text;
			}
			else
				Visibility = Visibility.Collapsed;
		}
	}
}

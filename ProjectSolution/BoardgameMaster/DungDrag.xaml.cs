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
	/// Логика взаимодействия для DungDrag.xaml
	/// </summary>
	public partial class DungDrag : Window
	{
		public DungDrag()
		{
			InitializeComponent();
		}

		private void addPlayer_Click(object sender, RoutedEventArgs e)
		{
			Field.Children.Add(new DungDragPlayer());
		}
	}
}

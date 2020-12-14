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

namespace TiliToli
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			Shuffle();
		}

		int steps = 0;
		private void Button1_Click(object sender, RoutedEventArgs e)
		{
			Button clickedButton = sender as Button;
			Button zeroButton = (Button)FindName("button0");
			int horizontalDistance = Math.Abs((int)(clickedButton.Margin.Left - zeroButton.Margin.Left));
			int verticalDistance = Math.Abs((int)(clickedButton.Margin.Top - zeroButton.Margin.Top));
			if ((horizontalDistance < 135 && verticalDistance == 0) || (verticalDistance < 135 && horizontalDistance == 0))
			{
				var aux = clickedButton.Margin;
				clickedButton.Margin = zeroButton.Margin;
				zeroButton.Margin = aux;
				steps++;
				stepsCounter.Text = Convert.ToString(steps);
			}
			if (button0.Margin.Left == 330 && button0.Margin.Top == 330 && button1.Margin.Left == 70 && button1.Margin.Top == 70 && button2.Margin.Left == 200 && button2.Margin.Top == 70 && button3.Margin.Left == 330 && button3.Margin.Top == 70 && button4.Margin.Left == 70 && button4.Margin.Top == 200 && button5.Margin.Left == 200 && button5.Margin.Top == 200 && button6.Margin.Left == 330 && button6.Margin.Top == 200 && button7.Margin.Left == 70 && button7.Margin.Top == 330 && button8.Margin.Left == 200 && button8.Margin.Top == 330)
			{
				MessageBox.Show("Gratulálok, nyertél!");
			}
		}

		public void Shuffle()
		{
			Random rand = new Random();
			for (int i = 0; i < 50; i++)
			{
				Button zeroButton = (Button)FindName("button0");
				string button = "button" + rand.Next(1, 9);
				Button randomButton = (Button)FindName(button);
				int horizontalDistance = Math.Abs((int)(randomButton.Margin.Left - zeroButton.Margin.Left));
				int verticalDistance = Math.Abs((int)(randomButton.Margin.Top - zeroButton.Margin.Top));
				if ((horizontalDistance < 135 && verticalDistance == 0) || (verticalDistance < 135 && horizontalDistance == 0))
				{
					var aux = randomButton.Margin;
					randomButton.Margin = zeroButton.Margin;
					zeroButton.Margin = aux;
				}
			}
		}

		private void NewGame_Click(object sender, RoutedEventArgs e)
		{
			steps = 0;
			stepsCounter.Text = Convert.ToString(steps);
			Shuffle();
		}
	}
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab4_OnScope_Pass_By_Reference
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		double total = 0;
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			double amount = Convert.ToDouble(txbox1.Text);
			double operatingCost = amount * 0.17;
			double afterOperatingCost = amount * 0.83;
			opertingTextBox.Text = Convert.ToString(operatingCost);
			txbox2.Text = Convert.ToString(afterOperatingCost);
			total += afterOperatingCost;
			totalDonationBox.Text = Convert.ToString(total);
		}
	}
}
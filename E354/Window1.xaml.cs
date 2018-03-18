/*
 * Utworzone przez SharpDevelop.
 * Użytkownik: rados
 * Data: 18.03.2018
 * Godzina: 22:56
 * 
 * Do zmiany tego szablonu użyj Narzędzia | Opcje | Kodowanie | Edycja Nagłówków Standardowych.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace E354
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
		{
			InitializeComponent();
		}
		void ObliczButton_Click(object sender, RoutedEventArgs e)
		{
			int liczba=Convert.ToInt32(LiczbaTextBox.Text);
			int i = 1;
			int sum=liczba;
			do{
				if (liczba%i==0) {
					int a = i;
					int b = liczba / i;
					int tmp = a + b;
					sum= (tmp < sum) ? tmp : sum;
				}
				i++;
			}while(i!=liczba);
			MessageBox.Show(Convert.ToString(sum));
		}
	}
}
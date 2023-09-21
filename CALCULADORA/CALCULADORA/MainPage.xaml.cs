using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CALCULADORA
{
	public partial class MainPage : ContentPage
	{
		public double numeroUno = 0, numeroDos = 0, numeroResta = 0;
		int operador = 4;
		bool hayPunto = false, unoDecimal = false, dosDecimal = false;
		public MainPage()
		{
			InitializeComponent();
		}

		private void Btn_sumar(object sender, EventArgs e)
		{

		}
		private void Btn_restar( object sender, EventArgs e)
		{

		}

		private void Btn_dividir(object sender, EventArgs e)
		{

		}

		private void Btn_por(object sender, EventArgs e)
		{

		}
	}
}

﻿using System;
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
		public double numeroUno = 0, numeroDos = 0, numRespuesta = 0;
		int operador = 4;
		bool hayPunto = false, unoDecimal = false, dosDecimal = false;
		public MainPage()
		{
			InitializeComponent();
		}


		private void Igualar_valores(String operando, int valor)
		{
			bool validaLbl = lblNumber.Text.GetType() != operador.GetType();
			bool validaSpn = spnFirst.Text.GetType() != operador.GetType();
			if (numRespuesta != 0 || ((validaLbl || validaSpn) || (validaLbl && validaSpn)))
				unoDecimal = true;
			if (unoDecimal)
				numeroUno = double.Parse(lblNumber.Text);
			else
				numeroUno = double.Parse(lblNumber.Text);
			spnFirst.Text = numeroUno + " ";
			lblNumber.Text = "0";
			spnSecond.Text = operando;
			operador = valor;
			hayPunto = false;
		}

		private bool Hallar_Lleno()
		{
			bool estaLleno = false;
			if (spnFirst.Text == "" && spnSecond.Text == "")
				estaLleno = true;
			return estaLleno;
		}

		private void Ingresar_numero(string numero)
		{
			if (lblNumber.Text == "0" && numero != ".")
				lblNumber.Text = numero;
			else
				lblNumber.Text += numero;
		}

		private void Btn_AC(object semder, EventArgs e)
		{
			numeroUno = 0; numeroDos = 0; numRespuesta = 0; hayPunto = false;
			spnFirst.Text = ""; spnSecond.Text = ""; spnThird.Text = ""; lblNumber.Text = "0";
		}
		private void Btn_sumar(object sender, EventArgs e)
		{
			Igualar_valores("+", 0);
			if (!Hallar_Lleno())
				spnThird.Text = "";
		}

		private void Click_C(object sender, EventArgs e)
		{
			if (lblNumber.Text.EndsWith("."))
			{
				hayPunto = false;
			}
			if (lblNumber.Text != "0" && lblNumber.Text != "0.")
			{
				if (double.Parse(lblNumber.Text) > 10)
				{
					lblNumber.Text = lblNumber.Text.Substring(0, lblNumber.Text.Length - 1);
				}
				else
				{
					lblNumber.Text = "0";
				}
			}
			if (lblNumber.Text.EndsWith("."))
			{
				lblNumber.Text = lblNumber.Text.Substring(0, lblNumber.Text.Length - 1);
			}

		}
		private void Btn_restar(object sender, EventArgs e)
		{
			Igualar_valores("-", 1);
			if (!Hallar_Lleno())
				spnThird.Text = "";
		}

		private void Btn_dividir(object sender, EventArgs e)
		{
			Igualar_valores("/", 3);
			if (!Hallar_Lleno())
				spnThird.Text = "";
		}

		private void Btn_por(object sender, EventArgs e)
		{
			Igualar_valores("*", 2);
			if (!Hallar_Lleno())
				spnThird.Text = "";
		}

		private void Click_zero(object sender, EventArgs e)
		{
			if (lblNumber.Text != "0")
			{
				Ingresar_numero("0");
			}
		}
		private void Click_one(object sender, EventArgs e)
		{
			Ingresar_numero("1");
		}
		private void Click_two(object sender, EventArgs e)
		{
			Ingresar_numero("2");
		}
		private void Click_three(object sender, EventArgs e)
		{
			Ingresar_numero("3");
		}
		private void Click_four(object sender, EventArgs e)
		{
			Ingresar_numero("4");
		}
		private void Click_five(object sender, EventArgs e)
		{
			Ingresar_numero("5");
		}
		private void Click_six(object sender, EventArgs e)
		{
			Ingresar_numero("6");
		}
		private void Click_seven(object sender, EventArgs e)
		{
			Ingresar_numero("7");
		}
		private void Click_eight(object sender, EventArgs e)
		{
			Ingresar_numero("8");
		}
		private void Click_nine(object sender, EventArgs e)
		{
			Ingresar_numero("9");
		}

		private void Click_return(object sender, EventArgs e)
		{
			Navigation.PopAsync();
		}

		private void Btn_equals(object sender, EventArgs e)
		{
			if(spnFirst.Text != "" && spnSecond.Text != "")
			{
				spnThird.Text = " " + lblNumber.Text;
				if (dosDecimal)
					numeroDos = double.Parse(spnThird.Text);
				else
					numeroDos = int.Parse(spnThird.Text);
				if(operador == 0)
				{
					numRespuesta = numeroUno + numeroDos;
					lblNumber.Text = numRespuesta + "";
				}
				else if (operador == 1)
				{
					numRespuesta = numeroUno - numeroDos;
					lblNumber.Text = numRespuesta + "";
				}
				else if (operador == 2)
				{
					numRespuesta = numeroUno * numeroDos;
					lblNumber.Text = numRespuesta + "";
				}
				else
				{
					if (numRespuesta != 0)
					{
						lblNumber.Text = "NO SE PUEDE MOSTRAR";
						return;
					}
					else if(operador == 3)
					{
						numRespuesta = numeroUno / numeroDos;
						lblNumber.Text = numRespuesta + "";
					}

				}
				numeroUno = 0; numeroDos = 0; numRespuesta = 0;
				operador = 4; unoDecimal = false; dosDecimal = false;

			}
		}
		private void Click_point(object sender, EventArgs e)
		{
			if (!hayPunto)
			{
				Ingresar_numero(".");
				hayPunto = true;
			}
			if (operador == 4)
				unoDecimal = true;
			else
				dosDecimal = true;
		}
	}
}

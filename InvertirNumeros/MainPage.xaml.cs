namespace InvertirNumeros;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	

	private void btnInvertir_Clicked(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(datoA.Text)
			&& !String.IsNullOrEmpty(datoB.Text)
			&& !String.IsNullOrEmpty(datoC.Text)
			&& !String.IsNullOrEmpty(datoD.Text))

		{
			double Dato1, Dato2, Dato3, Dato4;
			Dato1 = Convert.ToDouble(datoA.Text);
			Dato2 = Convert.ToDouble(datoB.Text);
			Dato3 = Convert.ToDouble(datoC.Text);
			Dato4 = Convert.ToDouble(datoD.Text);

			datoA.Text = Convert.ToString(Dato4);
			datoB.Text = Convert.ToString(Dato3);
			datoC.Text = Convert.ToString(Dato2);
			datoD.Text = Convert.ToString(Dato1);
		}

		else
		{
			DisplayAlert("Error", "Introduce todos los números", "Ok");
		}


	}

}


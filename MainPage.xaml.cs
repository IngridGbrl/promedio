namespace Promedio;
///<Summary>
///<Createddate>16/06/2023</Createddate>
///<Company>INDEL</Company>
///<Lastmodificationdate>18/06/2023</Lastmodificationdate>
///<Lastmodificationdescription>
///que en uno d elos label muestre el resultado en vez de un entry
///</Lastmodificationdescription>
///<Lastmodifierautor>Ingrid Gabriel</Lastmodifierautor>
///</Summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// Constructor de la clase
	/// </summary>

	public MainPage()
	{
		InitializeComponent();
	}

	/// <summary>
	/// En el evento del botn se calculará el promedio final de todas
	/// las notas introducidas y dara el resultado
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
    private void Resultado_Clicked(object sender, EventArgs e)
    {
		if (!string.IsNullOrEmpty(nota1.Text) || !string.IsNullOrEmpty(nota2.Text) || !string.IsNullOrEmpty(nota3.Text) ||
			!string.IsNullOrEmpty(nota4.Text) || !string.IsNullOrEmpty(nota5.Text))
		{
			int C1, C2, C3, C4, C5, Result;

			C1 = Convert.ToInt32(nota1.Text);
			C2 = Convert.ToInt32(nota2.Text);
			C3 = Convert.ToInt32(nota3.Text);
			C4 = Convert.ToInt32(nota4.Text);
			C5 = Convert.ToInt32(nota5.Text);

			Result = (C1 + C2 + C3 + C4 + C5) / 5;

			promedio.Text = Result.ToString();
		}
		else
		{
            DisplayAlert("Error", "ocurrio un error al introducir notas", "ok");
        }

    }
}


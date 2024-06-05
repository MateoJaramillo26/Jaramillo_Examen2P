using Microsoft.Maui.Controls;

namespace mjnotas.Views;

public partial class MJContarpage : ContentPage
{
	public MJContarpage()
	{
		InitializeComponent();
	}

	private void OnCalculateClicked(Object sender, EventArgs e) 
	{
		String text = TextEditor.Text;

		int totalCaracteres = text.Length;
		int letras = text.Count(char.IsLetter);
		int numeros = text.Count(char.IsDigit);
		int vocales = text.Count(c => "aeiouAEIOU".Contains(c));
		int mayusculas = text.Count(char.IsUpper);
		int minusculas = text.Count(char.IsLower);

		ResultLabel.Text= $"Total: {totalCaracteres}\n" +
                               $"Letras: {letras}\n" +
                               $"Números: {numeros}\n" +
                               $"Vocales: {vocales}\n" +
                               $"Mayúsculas: {mayusculas}\n" +
                               $"Minúsculas: {minusculas}";
    }

	private void OnClearClicked(object sender, EventArgs e)
	{
		TextEditor.Text = string.Empty;
		ResultLabel.Text = string.Empty;
	}
}
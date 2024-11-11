namespace MauiAppHOTeL.views;

public partial class hospedagemtratada : ContentPage
{
	public hospedagemtratada()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PopAsync();
		} catch (Exception ex)
		{
            DisplayAlert("OPS", ex.Message, "Ok");
        }

    }
}
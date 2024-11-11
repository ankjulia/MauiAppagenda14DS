namespace MauiAppHOTeL.views;

public partial class contratacaodahospedagem : ContentPage
{
    App PropriedadesApp;


    public contratacaodahospedagem()
    {
        InitializeComponent();

        PropiedadesApp =(App)Application.Current;

        pck_quarto.ItemsSource = PropiedadesApp.lista_quartos;

        dtpck_checkin.MinimumDate = DateTime.Now;
        dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);

    }

    public App? PropiedadesApp { get; }

    private void Button_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new views.sobre();
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync (new hospedagemtratada());
        }catch(Exception ex) {
            DisplayAlert("OPS", ex.Message, "Ok");
 }
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemeto = sender as DatePicker;

        DateTime data_selecionada_checkin = elemeto.Date;


        dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);


    }
}

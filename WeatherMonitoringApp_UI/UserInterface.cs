using WeatherMonitoringApp_UI.Contains;

namespace WeatherMonitoringApp_UI
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        private void Button_SetWeather_Click(object sender, EventArgs e)
        {
            try
            {
                var cityName = textBox_GetCity.Text;
                var apiKey = textBox_GetApi.Text;

                if (String.IsNullOrWhiteSpace(cityName) ^ String.IsNullOrWhiteSpace(apiKey))
                    throw new Exception("Забыли вести город или API Ключ");

                var weatherViewModel = Factory.CreateWeatherViewModel();

                var model = weatherViewModel.GetWeatherView(cityName, apiKey);

                textBox_Temperature.Text = String.Format($"{ model.Item1}°C");
                textBox_Description.Text = model.Item2.ToString();
                textBox_WindSpeed.Text = String.Format($"{model.Item3} м/с");
            }
            catch (Exception ex) when (String.IsNullOrWhiteSpace(textBox_GetCity.Text) ^ String.IsNullOrWhiteSpace(textBox_GetApi.Text))
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте данные или повторите попытку позже");
            }
        }
    }
}

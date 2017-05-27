using Xamarin.Forms;

namespace TestingXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button_Clicked(object sender, System.EventArgs e)
        {
            if(entry.Text.Contains("@") && entry.Text.Contains("."))
            {
                Label.Text = "Contains OK";
            }
        }
    }
}

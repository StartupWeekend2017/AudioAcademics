using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.MediaManager;
using Plugin.MediaManager.Abstractions;

namespace AudioAcademics
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Login_onClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ArticleList());
        }
    }
}
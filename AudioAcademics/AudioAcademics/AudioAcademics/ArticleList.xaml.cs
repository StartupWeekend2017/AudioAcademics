using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioAcademics.Models;
using Plugin.MediaManager;
using Plugin.MediaManager.Abstractions;
using Plugin.MediaManager.Abstractions.Implementations;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AudioAcademics
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArticleList : ContentPage
    {
        private IMediaManager PlaybackController => CrossMediaManager.Current;

        public ArticleList()
        {
            InitializeComponent();

            ArticleListListView.ItemsSource = DemoArticles.Articles;

            PlaybackController.PlayingChanged += (sender, e) =>
            {

            };
        }

        protected override void OnAppearing()
        {
        }

        private void ArticleListListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;
            ((ListView) sender).SelectedItem = null;
            Navigation.PushAsync(new ArticlePlayPage((Article) e.SelectedItem));
        }
    }
}
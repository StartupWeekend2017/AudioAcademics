using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudibleAcademics.Models;
using Plugin.MediaManager;
using Plugin.MediaManager.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AudibleAcademics
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArticlePlayPage : ContentPage
    {
        private Article _article;
        private IMediaManager PlaybackController => CrossMediaManager.Current;

        public ArticlePlayPage(Article article)
        {
            InitializeComponent();

            _article = article;

            PlaybackController.PlayingChanged += (sender, e) =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    ArticleProgressBar.Progress = e.Progress;
                });
            };
        }

        protected override void OnAppearing()
        {

        }

        private void ToggleArticle1(object sender, EventArgs e)
        {
            PlaybackController.PlaybackController.Stop();
            PlaybackController.Play("https://phoodfridge.blob.core.windows.net/audibleacademics/4637.mp3");
        }

        private void ToggleArticle2(object sender, EventArgs e)
        {
            PlaybackController.PlaybackController.Stop();
            PlaybackController.Play("https://phoodfridge.blob.core.windows.net/audibleacademics/95.mp3");
        }

        private void ToggleArticle3(object sender, EventArgs e)
        {
            PlaybackController.PlaybackController.Stop();
            PlaybackController.Play("https://phoodfridge.blob.core.windows.net/audibleacademics/142.mp3");
        }
        private void Stop_OnClicked(object sender, EventArgs e)
        {
            PlaybackController.PlaybackController.Stop(); 
        }

        private void Start_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioAcademics.Models;
using Plugin.MediaManager;
using Plugin.MediaManager.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AudioAcademics
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
            ArticleTitle.Text = article.Title;
            ArticleContents.Text = article.Contents;

            PlaybackController.Play(article.AudioUrl);
            PlaybackController.PlaybackController.Stop();

            PlaybackController.PlayingChanged += (sender, e) =>
            {
                Device.BeginInvokeOnMainThread(() => { ArticleProgressBar.Progress = e.Progress; });
            };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            PlaybackController.PlaybackController.Stop();
        }

        private void Pause_OnClicked(object sender, EventArgs e)
        {
            PlaybackController.PlaybackController.Pause();
        }

        private void Play_OnClicked(object sender, EventArgs e)
        {
            PlaybackController.PlaybackController.Play();
        }
    }
}
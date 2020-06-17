using Android.Content.Res;
using QuizApp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using FileControllers.Controllers;

namespace QuizApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void PlayButton_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new QuizGame_Page();
        }

        private void LeaderboardButton_Clicked(object sender, EventArgs e)
        {
            //var x = FileController.FileToString("lang/local_en.json");
            //LeaderboardButton.Text = x;
            FileController.FileToJson();
            return;
        }
    }
}

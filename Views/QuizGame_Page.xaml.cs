using Android.Content.Res;
using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FileControllers.Controllers;
using QuizApp.Views;
//using Questions.Models;

namespace QuizApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuizGame_Page : ContentPage
    {
        public QuizGame_Page()
        {
            InitializeComponent();
            //ImageO.Source = ImageSource.FromFile("Placeholder.png");

        }

        private void debugButton_Clicked(object sender, EventArgs e)
        {
            ((Button)sender).Text += "+";
        }
    }
}
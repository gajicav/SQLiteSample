using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace SQLiteSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetStudentsAsync();
        }
        async void OnButtonClicked(Object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(nameEntry.Text))
            {
                await App.Database.SaveStudentAsync(new Student
                {
                    Name = nameEntry.Text,
                    IsAttending = isAttending.IsChecked
                });
                nameEntry.Text = string.Empty;
                isAttending.IsChecked = false;
                collectionView.ItemsSource = await App.Database.GetStudentsAsync();
            }
        }
    }
}

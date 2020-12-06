using People.Models;
using System;
using Xamarin.Forms;
using System.Collections.Generic;



namespace People
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void OnNewButtonClicked(object sender, EventArgs args)
        {
            statusMessage.Text = "";

            App.PersonRepo.AddNewPerson(newPerson.Text, newGender.Text, newTShirtSize.Text, newDateOfOrder.Text, newTShirt_Color.Text, newShipping_Address.Text);
            statusMessage.Text = App.PersonRepo.StatusMessage;
        }

        public void OnGetButtonClicked(object sender, EventArgs args)
        {
            statusMessage.Text = "";

            List<Person> people = App.PersonRepo.GetAllPeople();
            peopleList.ItemsSource = people;
        }
    }
}

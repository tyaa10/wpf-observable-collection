using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace ObservableCollection
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        //List<string> phones;
        //ObservableCollection<string> phones;
        ObservableCollection<Person> persons;
        public Window1()
        {
            InitializeComponent();

            //phones = new List<string> { "iPhone 6S Plus", "Nexus 6P", "Galaxy S7 Edge" };
            //phones = new ObservableCollection<string> { "iPhone 6S Plus", "Nexus 6P", "Galaxy S7 Edge" };
            //phonesList.ItemsSource = phones;

            persons = new ObservableCollection<Person> {
                new Person(){ Name="n1", Age="20" }
                , new Person(){ Name="n2", Age="22" }
                , new Person(){ Name="n3", Age="25" }
            };
            personsList.ItemsSource = persons;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string phone = phoneTextBox.Text;
            // добавление нового объекта
            //phones.Add(phone);

            Person person = new Person() {
                Name = personNameTextBox.Text
                , Age = personAgeTextBox.Text
            };

            Person selectedPerson = (Person)personsList.SelectedItem;
            if (selectedPerson != null)
            {
                selectedPerson.Name = personNameTextBox.Text;
                selectedPerson.Age = personAgeTextBox.Text;
            }
            else
            {
                persons.Add(person);
            }

            foreach (var item in persons)
            {
                Console.WriteLine(item);
            }
        }

        private void PersonsList_SelectionChanged(object sender, SelectionChangedEventArgs evArgs)
        {
            //Console.WriteLine(evArgs.Source);
            //Console.WriteLine(personsList.SelectedIndex);
            //Console.WriteLine(personsList.SelectedItem);

            Person selectedPerson = (Person)personsList.SelectedItem;

            personNameTextBox.Text = selectedPerson.Name;
            personAgeTextBox.Text = selectedPerson.Age;
        }
    }
}

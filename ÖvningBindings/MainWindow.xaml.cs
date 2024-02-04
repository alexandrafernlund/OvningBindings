using System.Collections.ObjectModel;
using System.ComponentModel;
using System;
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

namespace ÖvningBindings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        
        public ObservableCollection<Person> Persons { get; set; } //Listan som du hämtar data ur till UI-elementet
        
        public string SelectedCellData { get; set; } //Lagrar namnet på raden som du har klickat på.

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            Persons = new ObservableCollection<Person>
            {
                new Person { Name = "Alice Johnson", Address = "456 Oak St", PhoneNumber = "555-5678", Email = "alice@example.com" },
                new Person { Name = "Bob Smith", Address = "789 Pine St", PhoneNumber = "555-9876", Email = "bob@example.com" },
                new Person { Name = "Eva Williams", Address = "101 Elm St", PhoneNumber = "555-4321", Email = "eva@example.com" },
                new Person { Name = "David Brown", Address = "202 Cedar St", PhoneNumber = "555-8765", Email = "david@example.com" },
                new Person { Name = "Grace Davis", Address = "303 Maple St", PhoneNumber = "555-2109", Email = "grace@example.com" }
            };
        }

        
        private void PersonListView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (PersonListView.SelectedItem != null)
            {
                //Du behöver casta det du hämtar från Listviewen - till SelectedCellaData - till den klass du hämtar från (Person) så att du kommer åt dess properties.

                //Du behöver också calla OnPropertyChanged för att UI ska uppdateras
            }
        }

        
        private void UpdateDataButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (PersonListView.SelectedItem != null)
            {
                //Du behöver casta det du hämtar från Listviewen - till SelectedCellaData - till den klass du hämtar från (Person) så att du kommer åt dess properties.
                //Kom ihåg att du ska tilldela ett värde här
                
                //Du behöver också calla OnPropertyChanged för att UI ska uppdateras
            }
        }

        
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

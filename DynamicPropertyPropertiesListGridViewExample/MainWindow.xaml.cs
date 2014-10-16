using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

//http://msdn.microsoft.com/en-us/magazine/cc163816.aspx
namespace DynamicPropertyPropertiesListGridViewExample
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      this.InitializeComponent();

      this.DataContext = this;

      this.People = new ObservableCollection<Person>();
      this.People.Add(new Person() { Name = "Justin", Age = 40, Hobbies = "ADG", OtherHalf = new Person() { Name = "Micaela" } });
      this.People.Add(new Person() { Name = "Ade", Age = 24, Hobbies = "Giggling", OtherHalf = new Person() { Name = "Coops", Age = 10 } });
      this.People.Add(new Person() { Name = "Mark", Age = 24, Hobbies = "Dragos", OtherHalf = new Person() { Name = "Dragos", Age = 29 } });

      this.Products = new List<Product> { new Product { Name = "Some product", Attributes = "Very cool product" }, new Product { Name = "Other product", Attributes = "Not so cool one" } };
      this.ColumnConfig = new ColumnConfig { Columns = new List<Column> { new Column { Header = "Name", DataField = "Name" }, new Column { Header = "Attributes", DataField = "Attributes" } } };

      this.PeopleColumnConfig = new ColumnConfig
      {
        Columns = new List<Column>
        {
          new Column { Header = "Name", DataField = "Name" },
          new Column { Header = "Age", DataField = "Age" },
          new Column { Header = "Hobbies", DataField = "Hobbies" },
          new Column { Header = "OtherHalfName", DataField = "OtherHalf.Name" },
          new Column { Header = "OtherHalfAge", DataField = "OtherHalf.Age" },
        }
      };
    }

    public ObservableCollection<Person> People { get; private set; }

    public ColumnConfig PeopleColumnConfig { get; set; }

    public ColumnConfig ColumnConfig { get; set; }

    public IEnumerable<Product> Products { get; set; }
  }
}
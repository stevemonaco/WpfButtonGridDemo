using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfButtonGridDemo.ViewModels;

namespace WpfButtonGridDemo;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private MainViewModel _vm;

    public MainWindow()
    {
        InitializeComponent();
        _vm = new MainViewModel();

        for (int i = 0; i < 50; i++)
            _vm.Numbers.Add(new(i));

        DataContext = _vm;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        var button = (Button)sender;
        var numberViewModel = (NumberViewModel)button.DataContext;

        locationText.Text = $"Item {numberViewModel.Number} clicked";
    }

    private void addButton_Click(object sender, RoutedEventArgs e)
    {
        _vm.Numbers.Add(new(_vm.Numbers.Count));
    }
}

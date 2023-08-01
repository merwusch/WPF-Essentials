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

namespace MessageBoxSample
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow:Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
      MessageBoxResult result = MessageBox.Show("Would you like to greet the world with a \"Hello, world\"?", "My App", MessageBoxButton.YesNoCancel);
      switch( result )
      {
        case MessageBoxResult.Yes:
          MessageBox.Show("Hello to you too!", "My App");
          break;
        case MessageBoxResult.No:
          MessageBox.Show("Oh well, too bad!", "My App");
          break;
        case MessageBoxResult.Cancel:
          MessageBox.Show("Nevermind then...", "My App");
          break;
      }
    }
  }
}

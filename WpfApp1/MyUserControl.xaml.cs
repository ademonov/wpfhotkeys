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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MyUserControl.xaml
    /// </summary>
    public partial class MyUserControl : UserControl
    {
        public MyUserControl()
        {
            InitializeComponent();

            CommandBindings.Add(new CommandBinding());


            var command = new RoutedCommand();
            command.InputGestures.Add(new KeyGesture(Key.V, ModifierKeys.Control | ModifierKeys.Shift));
            CommandBindings.Add(new CommandBinding(command, ComboBox1HotKeyHandler));

            //AccessKeyManager.Register("V", ComboBox1);
            //AccessKeyManager.AddAccessKeyPressedHandler(ComboBox1, ComboBox1SelectionHandler);
        }

        private void ComboBox1HotKeyHandler(object sender, ExecutedRoutedEventArgs executedRoutedEventArgs)
        {
            ComboBox1.IsDropDownOpen = !ComboBox1.IsDropDownOpen;
            ComboBox1.Focus();
        }

        //private void ComboBox1SelectionHandler(object sender, AccessKeyPressedEventArgs accessKeyPressedEventArgs)
        //{
        //    ComboBox1.IsDropDownOpen = !ComboBox1.IsDropDownOpen;
        //}
    }
}

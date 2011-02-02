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
using System.Xml;

namespace XmlTreeView2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        XmlDataProvider xml_provider;
        
        public MainWindow()
        {
            InitializeComponent();
            xml_provider = (XmlDataProvider)this.Resources["ScenarioConfigXML"];

            string appPath = System.IO.Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
            xml_provider.Source = new Uri(appPath + @"\Config\scenario_chemotaxis.xml");
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            string source = xml_provider.Source.LocalPath;
            xml_provider.Document.Save(source);
        }

        private void parameter_tree_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            //XmlElement sel = parameter_tree.SelectedItem as XmlElement;
            //if (sel == null)
            //{
            //    TreeViewItem tvi = parameter_tree.SelectedItem as TreeViewItem;
            //    if (tvi != null)
            //    {
            //        MessageBoxResult re2 = MessageBox.Show(tvi.Header.ToString());
            //    }
            //}
            //else
            //{
            //    MessageBoxResult res = MessageBox.Show(sel.InnerXml);
            //}
        }
    }
}

using GRUDcomEntityFramework.EF;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
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
using System.Windows.Shapes;

namespace GRUDcomEntityFramework.HomePage
{
    /// <summary>
    /// Lógica interna para Index.xaml
    /// </summary>
    public partial class Index : Window
    {
        private Context _context = new Context();
        public Index()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Windows.Data.CollectionViewSource categoryViewSource =
                ((System.Windows.Data.CollectionViewSource)(this.FindResource("categoryViewSource")));
            _context.Users.Load();

            categoryViewSource.Source = _context.Users.Local;

            
        }

 
        private void ColorRow(DataGrid dg)
        {
            for (int i = 0; i < dg.Items.Count; i++)
            {
                DataGridRow row = (DataGridRow)dg.ItemContainerGenerator.ContainerFromIndex(i);

                if (row != null)
                {
                    int index = row.GetIndex();
                    if (index % 2 != 0)
                    {
                        SolidColorBrush brush = new SolidColorBrush(Color.FromRgb(196, 196, 196));
                        row.Background = brush;
                    }
                    else
                    {
                        SolidColorBrush brush = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                        row.Background = brush;
                    }
                }
            }
        }


   

        private void CategoryDataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            ColorRow(categoryDataGrid);
        }

        private void CategoryDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }


}

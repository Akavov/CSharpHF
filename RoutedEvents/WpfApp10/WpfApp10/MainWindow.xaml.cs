﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> outputItems = new ObservableCollection<string>(); 
        public MainWindow()
        {
            InitializeComponent();
            output.ItemsSource = outputItems;
        }

        private void panel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender==e.OriginalSource)
            {
                outputItems.Clear();
            }
            outputItems.Add("The panel was pressed");
            
        }

        private void border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender==e.OriginalSource)
            {
                outputItems.Clear();
            }
            outputItems.Add("The border was pressed");
            if (borderSetsHandled.IsChecked==true)
            {
                e.Handled = true;
            }
        }

        private void grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender==e.OriginalSource)
            {
                outputItems.Clear();
            }
            outputItems.Add("The grid was pressed");
            if (gridSetsHandled.IsChecked==true)
            {
                e.Handled = true;
            }
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender==e.OriginalSource)
            {
                outputItems.Clear();
            }
            outputItems.Add("THe ellipse was pressed");
            if (ellipseSetsHandled.IsChecked==true)
            {
                e.Handled = true;
            }
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender==e.OriginalSource)
            {
                outputItems.Clear();
            }
            outputItems.Add("The rectangle wass pressed");
            if (rectangleSetsHandled.IsChecked==true)
            {
                e.Handled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            grayRectangle.IsHitTestVisible = (bool)newHitTestVisibleValue.IsChecked;
        }

        
    }
}

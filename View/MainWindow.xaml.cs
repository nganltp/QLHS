﻿using System;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace desktop_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Storyboard openMenu;
        Storyboard closeMenu;
        public MainWindow()
        {
            InitializeComponent();

            //openMenu = this.FindResource("OpenMenu") as Storyboard;
            //closeMenu = this.FindResource("CloseMenu") as Storyboard;
        }

    
        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemHome":
                    usc = new UserControlHome();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemCreate":
                    usc = new UserControlCreate();
                    GridMain.Children.Add(usc);
                    break;
                default:
                    break;
            }
        }

        private void ButtonToggleMenu_Click(object sender, RoutedEventArgs e)
        {
            //if(ButtonToggleMenu.IsChecked ?? false)
            //{
            //    openMenu.Begin();
            //}
            //else
            //{
            //    closeMenu.Begin();
            //}
        }
    }
}

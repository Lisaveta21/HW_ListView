﻿using System;
using System.Collections.Generic;
using System.IO;
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

namespace HW_ListView
{
 
    public partial class MainWindow : Window
    {
        #region Constructor
        /// <summary>
        /// Interaction logic for MainWindow.xaml
        /// </summary>

        #region On loaded
        /// <summary>
        /// Interaction logic for MainWindow.xaml
        /// </summary>


        public MainWindow()
        {
            InitializeComponent();

            
        }
      

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var drive in Directory.GetLogicalDrives())
            {
                var item = new TreeViewItem();

                item .Header = drive;
                item.Tag = drive;

                item.Items.Add(null);


                FolderView.Items.Add(item);

            }
        }
        #endregion
    }
}

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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Prog122_S24_L12_ListView_Sal
{
    /// <summary>
    /// Interaction logic for MyNewWindow.xaml
    /// </summary>
    /// 


    public partial class MyNewWindow : Window
    {
        public MyNewWindow()
        {
            InitializeComponent();
            lblBusinessName.Content = Data.BusinessName;
            lbNames.ItemsSource = Data.names;
        }
    }
}

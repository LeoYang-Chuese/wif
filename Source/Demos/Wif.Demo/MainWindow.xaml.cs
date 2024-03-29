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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Frontier.Wif.Utilities.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace Wif.Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel ViewModel { get; set; }

        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            DataContext = ViewModel = viewModel;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TestWPF.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для CompletionRegistUserView.xaml
    /// </summary>
    public partial class CompletionRegistUserView : Window
    {
        public CompletionRegistUserView()
        {
            InitializeComponent();
        }
        private void pnlControlBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove(); // передвижение окна
        }


        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}

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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace chengzhong
{
    /// <summary>
    /// 手动.xaml 的交互逻辑
    /// </summary>
    public partial class 手动 : Page
    {
        private MainWindow _parentWin;
        public MainWindow ParentWindow
        {
            get { return _parentWin; }
            set { _parentWin = value; }
        }
        public 手动()
        {
            InitializeComponent();
        }
        
    }
}

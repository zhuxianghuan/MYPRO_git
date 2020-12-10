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
using System.Data.SQLite;

namespace chengzhong
{

    /// <summary>
    /// 自动.xaml 的交互逻辑
    /// </summary>
    public partial class 自动 : Page 
    {
        private MainWindow _parentWin;
        public MainWindow ParentWindow
        {
            get { return _parentWin; }
            set { _parentWin = value; }
        }
        public 自动()
        {
            InitializeComponent();
        }
        
        private void button_chaxun_Click(object sender, RoutedEventArgs e)
        {
            // SQLite连接字符串
            string connectionString = @"Data Source='" + @"C:\Users\Administrator\Desktop\MYPRO_git\chengzhong\bin\Debug\netcoreapp3.1\test.db3" + "';Version=3;";
            // 获取指定数据库中的所有表名
            StringBuilder tableNames = new StringBuilder();
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                // 获取数据库中的所有表名
                string sqlTableNames = "select * from tab1";
                // 创建命令对象
                SQLiteCommand cmd = new SQLiteCommand(sqlTableNames, conn);
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    this.dataGrid.ItemsSource = dr;

                }
                conn.Close();
            }
            this.ParentWindow.s1200.Write("DB0.10", 99);
        }

        private void button_charu_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = @"Data Source='" + @"C:\Users\Administrator\Desktop\MYPRO_git\chengzhong\bin\Debug\netcoreapp3.1\test.db3" + "';Version=3;";
            // 获取指定数据库中的所有表名
            StringBuilder tableNames = new StringBuilder();
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                // 获取数据库中的所有表名
                // string sqlTableNames = "INSERT INTO tab1 (time,number, value) VALUES ('2020-12-17 00:00:11',19, 20.11)";
                string sqlTableNames = "INSERT INTO tab1 (time,number, value) VALUES (@time,19, 20.11)";

                // 创建命令对象
                SQLiteCommand cmd = new SQLiteCommand(sqlTableNames, conn);
                cmd.Parameters.Add(new SQLiteParameter("@time", DateTime.Now));
                cmd.ExecuteNonQuery();
                MessageBox.Show("done");
                conn.Close();


            }
        }
    }
}

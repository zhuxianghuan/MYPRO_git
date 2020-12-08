using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
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
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using IoTClient.Clients.PLC;
using IoTClient.Common.Enums;
using IoTClient.Common.Helpers;
using IoTClient.Enums;

using System.Data.SQLite;
using System.Threading;
using System.Windows.Threading;

namespace chengzhong
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SiemensClient s1200;
        BinaryFormatter formatter;
       
        static Event ven;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("正在连接设备，请稍后！");
            ven = new Event();
            ven.OntempChange += new Event.tempChange(ven_OntempChange);
            Task.Run(() =>
            {
                try
                {


                    s1200 = new SiemensClient(SiemensVersion.S7_1200, "127.0.0.1", 102);
                    s1200.WarningLog = (msg, ex) =>
                    {
                        //MessageBox.Show(ex.Message);
                    };
                    var result = s1200.Open();
                   // var result = s1200.Close();
                    if (!result.IsSucceed)
                        MessageBox.Show($"连接失败：{result.Err}");
                    else
                    {
                       
                        MessageBox.Show($"连接成功\t\t\t\t耗时：{result.TimeConsuming}ms");
                        //   string asd=
                        //  MessageBox.Show()
                  
                    



                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                   
                }

                string strobg = "hello zhu xianfhuan!";
                FileStream stream = new FileStream("testaaa.dat", FileMode.Create, FileAccess.Write, FileShare.None);
                 formatter = new BinaryFormatter();
                formatter.Serialize(stream, strobg);
                stream.Close();
                printHighscores();

            });

        }


        private void Window_Closing_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            FileStream fileStream = new FileStream("C:\\strobg.dat", FileMode.Open, FileAccess.Read, FileShare.Read);
            string readdata = (string)formatter.Deserialize(fileStream);
            MessageBox.Show(readdata);
            s1200.Close();
        }
        public class Usermanager 
        
        {
            public Usermanager()
            {

            }
            public int MyProperty { get; set; }


        }
        void printHighscores()

        {

        }
          //查询记录
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            s1200.Write("DB0.10", 99);
            //  Thread thread = new Thread(readtag);
            //  thread.Start();
            readtag();
        }

        //插入记录
        private void button_charu_Click_1(object sender, RoutedEventArgs e)
        {
            string connectionString = @"Data Source='" + @"C:\Users\Administrator\Desktop\MYPRO\chengzhong\bin\Debug\netcoreapp3.1\test.db3" + "';Version=3;";
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
        class Event
        {
            public delegate void tempChange(object sender, EventArgs e);
            public event tempChange OntempChange;
            string temp;
            public string Temp
            {
                get
                {
                    return temp;
                }
                set
                {
                    if (temp != value)
                    {
                        OntempChange(this, new EventArgs());
                    }
                    temp = value;
                }
            }
        }
        static void ven_OntempChange(object sender, EventArgs e)
        {
            MessageBox.Show("事件测试成功！"+ven.Temp);
        }

        public void Test()   //变量触发事件  测试
        {
            for (int i = 0; i < 10; i++)
            {
                ven.Temp = i + "aaa";
                Thread.Sleep(1000);
            }


        }

        public void readtag()
        {
            Dictionary<string, DataTypeEnum> addresses = new Dictionary<string, DataTypeEnum>();
            addresses.Add("DB0.10", DataTypeEnum.Int32);
            addresses.Add("DB1.0", DataTypeEnum.Int32);
            addresses.Add("DB2.0", DataTypeEnum.Int32);
            addresses.Add("DB4.10", DataTypeEnum.Int32);
            addresses.Add("DB8.10", DataTypeEnum.Int32);
            addresses.Add("DB12.10", DataTypeEnum.Int32);


           
               
                var result = s1200.BatchRead(addresses);
            
                this.Dispatcher.Invoke(DispatcherPriority.Normal, (ThreadStart)delegate
                {

                    this.dataGrid1.ItemsSource = result.Value;
                });
            


            



        }

        private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

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

        自动 p1;
        手动 p2;
        报表 p3;
        public SiemensClient s1200;
        BinaryFormatter formatter;
       
        static Event ven;
        DispatcherTimer timer = new DispatcherTimer();
        int read_tag = 0;
        public Dictionary<string,dynamic> read_res ;
        public MainWindow()
        {
            InitializeComponent();
            p1 = new 自动();
            p2 = new 手动();
            p3 = new 报表(); 
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            
            Dictionary<string, DataTypeEnum> addresses = new Dictionary<string, DataTypeEnum>();
            addresses.Add("m10", DataTypeEnum.Int32);
            addresses.Add("m20", DataTypeEnum.Int32);
            addresses.Add("m30", DataTypeEnum.Int32);
            addresses.Add("m40", DataTypeEnum.Int32);
            addresses.Add("m50", DataTypeEnum.Int32);
            addresses.Add("DB0.10", DataTypeEnum.Int32);
            var result = s1200.BatchRead(addresses);
            if (result.IsSucceed)
            {
                // this.dataGrid1.ItemsSource = result.Value;
                read_res = result.Value;
                 read_tag = read_tag + 1;
                 this.Title = read_tag.ToString();
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.frame.Content = p1;
            p1.ParentWindow = this;

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
                        timer.Tick += new EventHandler(timer_Tick);
                        timer.Interval = TimeSpan.FromSeconds(1);   //设置刷新的间隔时间
                        timer.Start();
                        MessageBox.Show("定时读取启动！");
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
           

            });

        }
        private void Window_Closing_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            FileStream fileStream = new FileStream("C:\\strobg.dat", FileMode.Open, FileAccess.Read, FileShare.Read);
            string readdata = (string)formatter.Deserialize(fileStream);
            MessageBox.Show(readdata);
            s1200.Close();
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
        

        private void button_auto_Click(object sender, RoutedEventArgs e)
        {
            this.frame.Content = p1;
            p1.ParentWindow = this;
        }

        private void button_manul_Click(object sender, RoutedEventArgs e)
        {
            this.frame.Content = p2;
            p2.ParentWindow = this;

        }

        private void button_report_Click(object sender, RoutedEventArgs e)
        {
            this.frame.Content = p3;
            p3.ParentWindow = this;
        }
    }
}

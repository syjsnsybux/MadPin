
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;


namespace Hostlink
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private NotifyIcon notifyIcon;
        public SerialPort sp1 = new SerialPort();
        public string startPerfix = "@00FA00000000001023100AA00000101";
        public string endPerfix =   "@00FA00000000001023100AA00000100";
        public string pcsPerfix =   "@00FA0000000000102B100AB000001";//后接4位数量
        public string whichPerfix = "@00FA0000000000102B100AC000001";
        public string pcsString;
        public string whichString;
        public string startString;
        public string endString;
        public string readStringcmd = "@00FA00000000001013100AA00000174*\r";
        public string readStringpcscmd = "@00FA0000000000101B100AB00000106*\r";
        public string readStringwhichcmd = "@00FA0000000000101B100AC00000107*\r";
        public string readstr;
        public MainWindow()
        {
            InitializeComponent();

            this.notifyIcon = new NotifyIcon();
            this.notifyIcon.BalloonTipText = "系统监控中... ...";
            this.notifyIcon.ShowBalloonTip(2000);
            this.notifyIcon.Text = "系统监控中... ...";
            if (sp1.IsOpen == false) { this.notifyIcon.Icon = new System.Drawing.Icon("yellow.ico"); this.notifyIcon.Text = "AOI抽检软件串口为关闭状态"; }
            this.notifyIcon.Visible = true;
            //打开菜单项
            System.Windows.Forms.MenuItem open = new System.Windows.Forms.MenuItem("Open");
            open.Click += new EventHandler(Show);
            //隐藏菜单项
            //System.Windows.Forms.MenuItem hide = new System.Windows.Forms.MenuItem("hidden");
            //open.Click += new EventHandler(Hide);
            //退出菜单项
            System.Windows.Forms.MenuItem exit = new System.Windows.Forms.MenuItem("Exit");
            exit.Click += new EventHandler(Close);
            //关联托盘控件
            System.Windows.Forms.MenuItem[] childen = new System.Windows.Forms.MenuItem[] { open,exit };
            notifyIcon.ContextMenu = new System.Windows.Forms.ContextMenu(childen);

            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler((o, e) =>
            {
                if (e.Button == MouseButtons.Left) this.Show(o, e);
            });

       




        string[] str = SerialPort.GetPortNames();
            if (str == null)
            {
                System.Windows.MessageBox.Show("本机没有串口！", "Error");
                return;
            }
            startString = startPerfix + GetFCS(startPerfix) +"*\r";
            endString= endPerfix + GetFCS(endPerfix) +"*\r";
            //添加串口项目
            cbpcsNum.Items.Add("0");
            cbpcsNum.Items.Add("1");
            cbpcsNum.Items.Add("2");
            cbpcsNum.Items.Add("3");
            cbpcsNum.Items.Add("4");
            cbpcsNum.Items.Add("5");
            cbpcsNum.Items.Add("6");
            cbpcsNum.Items.Add("7");
            cbpcsNum.Items.Add("8");
            cbpcsNum.Items.Add("9");
            cbpcsNum.Items.Add("10");
            cbpcsNum.Items.Add("11");
            cbpcsNum.Items.Add("12");
            cbpcsNum.Items.Add("13");
            cbpcsNum.Items.Add("14");
            cbpcsNum.Items.Add("15");
            cbpcsNum.Items.Add("16");
            cbpcsNum.Items.Add("17");
            cbpcsNum.Items.Add("18");
            cbpcsNum.Items.Add("19");
            cbpcsNum.Items.Add("20");
            cbpcsNum.Items.Add("21");
            cbpcsNum.Items.Add("22");
            cbpcsNum.Items.Add("23");
            cbpcsNum.Items.Add("24");
            cbpcsNum.Items.Add("25");
            cbpcsNum.Items.Add("26");
            cbpcsNum.Items.Add("27");
            cbpcsNum.Items.Add("28");
            cbpcsNum.Items.Add("29");
            cbpcsNum.Items.Add("30");
            cbpcsNum.Items.Add("31");
            cbpcsNum.Items.Add("32");
            cbpcsNum.Items.Add("33");
            cbpcsNum.Items.Add("34");
            cbpcsNum.Items.Add("35");
            cbpcsNum.Items.Add("36");
            cbpcsNum.Items.Add("37");
            cbpcsNum.Items.Add("38");
            cbpcsNum.Items.Add("39");
            cbpcsNum.Items.Add("40");
            cbpcsNum.Items.Add("41");
            cbpcsNum.Items.Add("42");
            cbpcsNum.Items.Add("43");
            cbpcsNum.Items.Add("44");
            cbpcsNum.Items.Add("45");
            cbpcsNum.Items.Add("46");
            cbpcsNum.Items.Add("47");
            cbpcsNum.Items.Add("48");
            cbpcsNum.Items.Add("49");
            cbpcsNum.Items.Add("50");
            cbpcsNum.SelectedIndex = 0;

            cbwhichNum.Items.Add("0");
            cbwhichNum.Items.Add("1");
            cbwhichNum.Items.Add("2");
            cbwhichNum.Items.Add("3");
            cbwhichNum.Items.Add("4");
            cbwhichNum.Items.Add("5");
            cbwhichNum.Items.Add("6");
            cbwhichNum.Items.Add("7");
            cbwhichNum.Items.Add("8");
            cbwhichNum.Items.Add("9");
            cbwhichNum.Items.Add("10");
            cbwhichNum.Items.Add("11");
            cbwhichNum.Items.Add("12");
            cbwhichNum.Items.Add("13");
            cbwhichNum.Items.Add("14");
            cbwhichNum.Items.Add("15");
            cbwhichNum.Items.Add("16");
            cbwhichNum.Items.Add("17");
            cbwhichNum.Items.Add("18");
            cbwhichNum.Items.Add("19");
            cbwhichNum.Items.Add("20");
            cbwhichNum.Items.Add("21");
            cbwhichNum.Items.Add("22");
            cbwhichNum.Items.Add("23");
            cbwhichNum.Items.Add("24");
            cbwhichNum.Items.Add("25");
            cbwhichNum.Items.Add("26");
            cbwhichNum.Items.Add("27");
            cbwhichNum.Items.Add("28");
            cbwhichNum.Items.Add("29");
            cbwhichNum.Items.Add("30");
            cbwhichNum.Items.Add("31");
            cbwhichNum.Items.Add("32");
            cbwhichNum.Items.Add("33");
            cbwhichNum.Items.Add("34");
            cbwhichNum.Items.Add("35");
            cbwhichNum.Items.Add("36");
            cbwhichNum.Items.Add("37");
            cbwhichNum.Items.Add("38");
            cbwhichNum.Items.Add("39");
            cbwhichNum.Items.Add("40");
            cbwhichNum.Items.Add("41");
            cbwhichNum.Items.Add("42");
            cbwhichNum.Items.Add("43");
            cbwhichNum.Items.Add("44");
            cbwhichNum.Items.Add("45");
            cbwhichNum.Items.Add("46");
            cbwhichNum.Items.Add("47");
            cbwhichNum.Items.Add("48");
            cbwhichNum.Items.Add("49");
            cbwhichNum.Items.Add("50");
            cbwhichNum.SelectedIndex = 0;

            cbSerial.Items.Add("COM1");
            cbSerial.Items.Add("COM2");
            cbSerial.Items.Add("COM3");
            cbSerial.Items.Add("COM4");
            cbSerial.SelectedIndex = 0;

            cbBoundRate.Items.Add("1200");
            cbBoundRate.Items.Add("2400");
            cbBoundRate.Items.Add("4800");
            cbBoundRate.Items.Add("9600");
            cbBoundRate.Items.Add("19200");
            cbBoundRate.Items.Add("38400");
            cbBoundRate.Items.Add("43000");
            cbBoundRate.Items.Add("56000");
            cbBoundRate.Items.Add("57600");
            cbBoundRate.Items.Add("115200");
            cbBoundRate.Items.Add("117600");
            cbBoundRate.Items.Add("240000");
            cbBoundRate.SelectedIndex = 9;

            cbDataBits.Items.Add("5");
            cbDataBits.Items.Add("6");
            cbDataBits.Items.Add("7");
            cbDataBits.Items.Add("8");
            cbDataBits.SelectedIndex = 2;

            cbStop.Items.Add("0");
            cbStop.Items.Add("1");
            cbStop.Items.Add("1.5");
            cbStop.Items.Add("2");
            cbStop.SelectedIndex = 3;

            cbParity.Items.Add("无");
            cbParity.Items.Add("奇校验");
            cbParity.Items.Add("偶校验");
            cbParity.SelectedIndex = 2;
        }
        private string GetFCS(string str)
        {
            if (str == null || str.Count() <= 0)
            {
                return null;
            }
            int[] buf = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
               
                buf[i]= Convert.ToInt32(str[i]);
            }
            var resFCS= buf[0] ^ buf[1];
            for (int j = 2; j < buf.Length; j++)
            {
                resFCS = resFCS ^ buf[j];
            }
            string result = string.Empty;
            result = string.Format("{0:X2}", resFCS);

            return result;
        }


        private void EnableRB_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (enableRB.IsChecked == true)
                {
                    if (!sp1.IsOpen) //如果没打开   
                    {
                        System.Windows.MessageBox.Show("请先打开串口！", "Error");
                        this.enableRB.Dispatcher.Invoke(new Action(() =>
                        {
                            enableRB.IsChecked = null;
                        }));
                        return;
                    }
                    if (startString == null || startString.Length <= 0)
                    {
                        System.Windows.MessageBox.Show("发送字符串异常");
                        return;
                    }
                    string buf = ToHexString(startString,Encoding.Default);
                   

                    byte[] byteArray = stringToBytes(buf);
                    sp1.Write(startString);
                    System.Windows.MessageBox.Show("抽检模式已正常开启");
                    this.notifyIcon.Icon = new System.Drawing.Icon("green.ico"); this.notifyIcon.Text = "AOI抽检模式已开启";

                }
            }
            catch(Exception ex)
            {
                System.Windows.MessageBox.Show("Error: " + ex.ToString());
                return;
            }
           
            
        }
        public  byte[] stringToBytes(string hexString)
        {
            string[] chars = hexString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            byte[] returnBytes = new byte[chars.Length];
            //逐个字符变为16进制字节数据
            for (int i = 0; i < chars.Length; i++)
            {
                 Byte.TryParse(chars[i], System.Globalization.NumberStyles.HexNumber, null, out returnBytes[i]); ;
            }
            return returnBytes;

        }
        public static string ToHexStrFromByte(byte[] byteDatas)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < byteDatas.Length; i++)
            {
                builder.Append(string.Format("{0:X2} ", byteDatas[i]));
            }
            return builder.ToString().Trim();
        }
        public static string ToHexString( string plainString, Encoding encode)
        {
            byte[] byteDatas = encode.GetBytes(plainString);
            return ToHexStrFromByte(byteDatas);
        }
        private void UnableRB_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (unableRB.IsChecked == true)
                {
                    if (!sp1.IsOpen) //如果没打开   
                    {
                        System.Windows.MessageBox.Show("请先打开串口！", "Error");
                        this.unableRB.Dispatcher.Invoke(new Action(() =>
                        {
                            unableRB.IsChecked = null;
                        }));
                        return;
                    }
                    if (endString == null || endString.Length <= 0)
                    {
                        System.Windows.MessageBox.Show("发送字符串异常");
                        return;
                    }
                    string buf = ToHexString(endString, Encoding.Default);

                    byte[] byteArray = stringToBytes(buf);
                   
                    sp1.Write(endString);
                    System.Windows.MessageBox.Show("抽检模式已关闭");
                    this.notifyIcon.Icon = new System.Drawing.Icon("red.ico"); this.notifyIcon.Text = "AOI抽检模式未开启";
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error: " + ex.ToString());
                return;
            }
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sp1.IsOpen == true)//如果打开状态，则先关闭一下  
            {
                sp1.Close();
            }
            if (!sp1.IsOpen)
            {
                try
                {
                    //设置串口  
                    sp1.Open();     //打开串口
                    sp1.Write(readStringcmd);
                    string str = "";
                    int len = 28;
                    Byte[] readBuffer = new Byte[len];
                    System.Threading.Thread.Sleep(500);   
                    sp1.Read(readBuffer, 0, len);
                    str = Encoding.Default.GetString(readBuffer);

                    //如果需要和界面上的控件交互显示数据，使用下面的方法。其中ttt是控件的名称。
                    if (str == "@00FA0040000000010100000142*")
                    {
                        this.enableRB.Dispatcher.Invoke(new Action(() =>
                        {
                            enableRB.IsChecked = true;
                        }));
                        this.notifyIcon.Icon = new System.Drawing.Icon("green.ico"); this.notifyIcon.Text = "AOI抽检模式已开启";
                    }
                    if (str == "@00FA0040000000010100000043*")
                    {
                        this.unableRB.Dispatcher.Invoke(new Action(() =>
                        {
                            unableRB.IsChecked = true;
                        }));
                        this.notifyIcon.Icon = new System.Drawing.Icon("red.ico"); this.notifyIcon.Text = "AOI抽检模式未开启";
                    }
                    sp1.DiscardInBuffer();  //清空接收缓冲区

                    sp1.Write(readStringpcscmd);
                    string str1 = "";
                    string str1a = "";
                    string str1ab = "";
                    int str1ad = 0;
                    int len1 = 29;
                    Byte[] readBuffer1 = new Byte[len1];
                    System.Threading.Thread.Sleep(500);
                    sp1.Read(readBuffer1, 0, len1);
                    str1 = Encoding.Default.GetString(readBuffer1);
                    str1a = "0x"+str1.Substring(23,4);
                    str1ad = System.Convert.ToInt32(str1a, 16);
                    str1ab = str1ad.ToString();
                    if (str1ab != "0")
                    {
                        this.cbpcsNum.Dispatcher.Invoke(new Action(() =>
                        {
                            cbpcsNum.Text = str1ab;
                        }));
                    }
                    sp1.DiscardInBuffer();  //清空接收缓冲区
                    
                    System.Threading.Thread.Sleep(500);

                    sp1.Write(readStringwhichcmd);
                    string str2 = "";
                    string str2a = "";
                    string str2ab = "";
                    int str2ad = 0;
                    int len2 = 29;
                    Byte[] readBuffer2 = new Byte[len2];
                    System.Threading.Thread.Sleep(500);
                    sp1.Read(readBuffer2, 0, len2);
                    str2 = Encoding.Default.GetString(readBuffer2);
                    str2a = "0x"+str2.Substring(23, 4);
                    str2ad = System.Convert.ToInt32(str2a, 16);
                    str2ab = str2ad.ToString();
                    if (str2ab != "0")
                    {
                        this.cbwhichNum.Dispatcher.Invoke(new Action(() =>
                        {
                            cbwhichNum.Text = str2ab;
                        }));
                    }
                    System.Windows.MessageBox.Show("串口已开启，抽检状态已全部读取");
                    sp1.DiscardInBuffer();  //清空接收缓冲区
  
                }
                catch (System.Exception ex)
                {
                    System.Windows.MessageBox.Show("Error:" + ex.Message, "Error");
                    return;
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                SetSerialConfig();
                
            }catch(Exception ex)
            {
                System.Windows.MessageBox.Show("串口打开失败\n" + ex.ToString());
                return;
            }
        }
        private void SetSerialConfig()
        {
            try {
                string serialName = cbSerial.SelectedItem.ToString();
                sp1.PortName = serialName;
                //设置各“串口设置”  
                string strBaudRate = cbBoundRate.Text;
                string strDateBits = cbDataBits.Text;
                string strStopBits = cbStop.Text;
                Int32 iBaudRate = Convert.ToInt32(strBaudRate);
                Int32 iDateBits = Convert.ToInt32(strDateBits);
                sp1.ReadTimeout = Convert.ToInt32(tbReadTimeout.Text);
                sp1.WriteTimeout = Convert.ToInt32(tbWriteTimeout.Text);
                sp1.BaudRate = iBaudRate;       //波特率  
                sp1.DataBits = iDateBits;       //数据位  
                switch (cbStop.Text)            //停止位  
                {
                    case "1":
                        sp1.StopBits = StopBits.One;
                        break;
                    case "1.5":
                        sp1.StopBits = StopBits.OnePointFive;
                        break;
                    case "2":
                        sp1.StopBits = StopBits.Two;
                        break;
                    default:
                        System.Windows.MessageBox.Show("Error：参数不正确!", "Error");
                        break;
                }
                switch (cbParity.Text)             //校验位  
                {
                    case "无":
                        sp1.Parity = Parity.None;
                        break;
                    case "奇校验":
                        sp1.Parity = Parity.Odd;
                        break;
                    case "偶校验":
                        sp1.Parity = Parity.Even;
                        break;
                    default:
                        System.Windows.MessageBox.Show("Error：参数不正确!", "Error");
                        break;
                }

            }
            catch(Exception e)
            {
                System.Windows.MessageBox.Show("设置出错：" + e.ToString());
                return;
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                int pcs = Convert.ToInt32(cbpcsNum.Text);
                pcsString = pcsPerfix + string.Format("{0:X4}", pcs)+GetFCS(pcsPerfix + string.Format("{0:X4}", pcs)) +"*\r";
                int which = Convert.ToInt32(cbwhichNum.Text);
                whichString = whichPerfix + string.Format("{0:X4}", which) + GetFCS(whichPerfix + string.Format("{0:X4}", which)) + "*\r";

                if (!sp1.IsOpen) //如果没打开   
                {
                    System.Windows.MessageBox.Show("请先打开串口！", "Error");
                    return;
                }
                if (pcsString == null || pcsString.Length <= 0 || whichPerfix == null || whichPerfix.Length <= 0|| which==0&pcs==0)
                {
                    System.Windows.MessageBox.Show("输入数据不能同时为Null或者同时为0");
                    return;
                }
                if (which>pcs)
                {
                    System.Windows.MessageBox.Show("第 ？片数不能少于连续 ？片");
                    return;
                }

                string buf = ToHexString(pcsString, Encoding.Default);
                byte[] pcsbyteArray = stringToBytes(buf);
                sp1.Write(pcsString);
                System.Threading.Thread.Sleep(500);

                string buf2 = ToHexString(whichString, Encoding.Default);
                byte[] whichbyteArray = stringToBytes(buf2);
                sp1.Write(whichString);
                System.Threading.Thread.Sleep(500);
                System.Windows.MessageBox.Show("设定数据写入完成");        

            }
            catch(Exception ex)
            {
                System.Windows.MessageBox.Show("Error：" + ex.ToString());
                return;
            }
        }
        public void Button_Click_3(object sender, RoutedEventArgs e)
        {

            if (sp1.IsOpen == true)//如果打开状态，则先关闭一下  
            {
                sp1.Close();

            }
            if (!sp1.IsOpen)
            {
                System.Windows.MessageBox.Show("端口已经关闭");
                this.notifyIcon.Icon = new System.Drawing.Icon("yellow.ico"); this.notifyIcon.Text = "AOI抽检软件串口为关闭状态";
            }
        }


        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = System.Windows.MessageBox.Show("是否已经确认抽检状态并需要退出？", "提示", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                sp1.Close();
                System.Windows.Application.Current.Shutdown();
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void Show(object sender, EventArgs e)
        {
            this.Visibility = System.Windows.Visibility.Visible;
            //this.ShowInTaskbar = true;
            this.WindowState = WindowState.Normal;
            this.Activate();
        }

        //private void Hide(object sender, EventArgs e)
        //{
        //    //this.ShowInTaskbar = false;
        //    //this.Visibility = System.Windows.Visibility.Hidden;
        //    this.WindowState = WindowState.Minimized;
        //}

        private void Close(object sender, EventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }

}

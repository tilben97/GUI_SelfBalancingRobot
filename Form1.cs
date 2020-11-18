using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace filterc
{
    public partial class Form1 : Form
    {
        int thread_value = 93;
        double range3 = 0, range4 = 0;
        double range_pos_min = 0, range_pos_max = 0;
        string[] ports;
        int n = 0;
        int m = 0;
        double reference = 0;
        bool recieve = false;
        static int uart_size = 100;
        static int Rx_size = 36;
        byte[] data_out = new byte[Rx_size];
        byte[] uart_buffer = new byte[uart_size];
        char header1;
        char header2;
        char header3;
        char header4;
        char footer1;
        char footer2;
        char footer3;
        char footer4;
        double roll_average = 0, Sum = 0;
        double filter_average = 0, Sum2 = 0;
        int cnt_average = 0;
        double[] pos = new double[10];
        double[] filter = new double[10];
        double[] rollAcc = new double[10];

        private void disconnect_btn_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            disconnect_btn.Enabled = false;
            connect_btn.Enabled = true;
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            recieve = true;
            start_btn.Enabled = false;
            stop_btn.Enabled = true;
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            recieve = false;
            start_btn.Enabled = true;
            stop_btn.Enabled = false;
            timer1.Stop();
            this.Invoke((MethodInvoker)delegate { delete_charts(); });
        }

        private void delete_charts()
        {
            pos_chart.Series["Position"].Points.Clear();
            pos_chart.Series["Reference"].Points.Clear();
            mpu_chart.Series["Acc"].Points.Clear();
            mpu_chart.Series["Filter"].Points.Clear();
            mpu_chart.Series["Reference"].Points.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (recieve)
            {
                n = 0;
                serialPort1.Read(uart_buffer, 0, uart_size);
                while (n <= uart_size - 36)
                {
                    header1 = (char)uart_buffer[n];
                    header2 = (char)uart_buffer[n + 1];
                    header3 = (char)uart_buffer[n + 2];
                    header4 = (char)uart_buffer[n + 3];
                    if (header1 == 'G' && header2 == 'o' && header3 == 'g' && header4 == 'o')
                    {
                        footer1 = (char)uart_buffer[n + 32];
                        footer2 = (char)uart_buffer[n + 33];
                        footer3 = (char)uart_buffer[n + 34];
                        footer4 = (char)uart_buffer[n + 35];
                        if (footer1 == 'B' && footer2 == 'e' && footer3 == 'b' && footer4 == 'e')
                        {
                            filter[m] = BitConverter.ToDouble(uart_buffer, n + 8);
                            rollAcc[m] = BitConverter.ToDouble(uart_buffer, n + 16);
                            pos[m] = BitConverter.ToDouble(uart_buffer, n + 24);
                            n = n + 35;
                            Sum = Sum + rollAcc[m];
                            Sum2 = Sum2 + filter[m];
                            m++;
                            cnt_average++;
                            if (cnt_average > 99)
                            {
                                roll_average = Sum / 100;
                                filter_average = Sum2 / 100;
                                Acc_Avg.Text = "Acc Avg: " + roll_average.ToString();
                                Filter_Avg.Text = "Filter Avg: " + filter_average.ToString();
                                Sum = 0;
                                Sum2 = 0;
                                cnt_average = 0;
                            }
                            if (m > 9)
                            {
                                m = 0;
                                Thread.Sleep(thread_value);
                                for (int q = 0; q < 9; q++)
                                {
                                    if (range3 < rollAcc[q])
                                    {
                                        range3 = rollAcc[q];
                                    }
                                    else if (range3 < filter[q])
                                    {
                                        range3 = filter[q];
                                    }
                                    if (range4 > rollAcc[q])
                                    {
                                        range4 = rollAcc[q];
                                    }
                                    else if (range4 > filter[q])
                                    {
                                        range4 = filter[q];
                                    }
                                    if (range_pos_min > pos[q])
                                    {
                                        range_pos_min = pos[q];
                                    }
                                    if (range_pos_max < pos[q])
                                    {
                                        range_pos_max = pos[q];
                                    }
                                    mpu_chart.ChartAreas[0].AxisY.Maximum = range3;
                                    mpu_chart.ChartAreas[0].AxisY.Minimum = range4;
                                    pos_chart.ChartAreas[0].AxisY.Minimum = range_pos_min;
                                    pos_chart.ChartAreas[0].AxisY.Maximum = range_pos_max;
                                    pos_chart.Series["Position"].Points.AddY(pos[q]);
                                    pos_chart.Series["Reference"].Points.AddY(reference);
                                    mpu_chart.Series["Acc"].Points.AddY(rollAcc[q]);
                                    mpu_chart.Series["Filter"].Points.AddY(filter[q]);
                                    mpu_chart.Series["Reference"].Points.AddY(reference);
                                    if (mpu_chart.Series[0].Points.Count == 300)
                                    {
                                        mpu_chart.Series[0].Points.RemoveAt(0);
                                    }
                                    if (mpu_chart.Series[1].Points.Count == 300)
                                    {
                                        mpu_chart.Series[1].Points.RemoveAt(0);
                                    }
                                    if (mpu_chart.Series[2].Points.Count == 300)
                                    {
                                        mpu_chart.Series[2].Points.RemoveAt(0);
                                    }
                                    if (pos_chart.Series[0].Points.Count == 300)
                                    {
                                        pos_chart.Series[0].Points.RemoveAt(0);
                                    }
                                    if (pos_chart.Series[1].Points.Count == 300)
                                    {
                                        pos_chart.Series[1].Points.RemoveAt(0);
                                    }
                                }
                                pos_lbl.Text = "Position: " + pos[5].ToString();
                                Acc_lbl.Text = "Acc: " + rollAcc[5].ToString();
                                Filter_lbl.Text = "Filter: " + filter[5].ToString();

                            }

                        }
                        else
                        {
                            n++;
                        }
                    }
                    else
                    {
                        n++;
                    }
                }

            }
            else
            {
                //
            }


        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = Convert.ToInt32(BaudRate_Box.Text);
            serialPort1.PortName = Port_Box.Text;
            serialPort1.ReadBufferSize = uart_size;
            serialPort1.Open();
            if (Convert.ToInt32(BaudRate_Box.Text) == 115200)
            {
                thread_value = 97;
                timer1.Interval = 3;
            }
            else if (Convert.ToInt32(BaudRate_Box.Text) == 9600)
            {
                thread_value = 900;
                timer1.Interval = 10;
            }
            else if (Convert.ToInt32(BaudRate_Box.Text) == 128000)
            {
                thread_value = 29;
                timer1.Interval = 1;
            }
            connect_btn.Enabled = false;
            disconnect_btn.Enabled = true;
            n = 0;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ports = SerialPort.GetPortNames();
            Port_Box.Items.AddRange(ports);
            disconnect_btn.Enabled = false;
            start_btn.Enabled = true;
            stop_btn.Enabled = false;
        }
    }
}

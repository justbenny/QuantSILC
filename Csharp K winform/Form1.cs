using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Csharp_K_winform
{
    public partial class Form1 : Form
    {
        Graphics kLine;
        Graphics amountLine;

        public struct Data
        {
            public DateTime date;
            public double start;
            public double end;
            public double max;
            public double min;
            public long vol;
        }
        public struct Line
        {
            public Point start;
            public Point end;
        }
        bool dataInput = false;
        bool fileselected = false;
        bool chartdrawn = false;
        Data[] dataIn = new Data[400];
        double[] avgPrice = new double[400];
        public Form1()
        {
            InitializeComponent();
            openFileDialog.Filter = "文本文件(*.txt)|*.txt";

            this.SizeChanged += Form1_SizeChanged;
        }

        void Form1_SizeChanged(object sender, EventArgs e)
        {
            KlineGpb.Height = (this.Height - 133) / 2;
            amountGpb.Location = new Point(12, KlineGpb.Location.Y+KlineGpb.Height+5);
            amountGpb.Height = KlineGpb.Height / 2;
            indexTbc.Height = amountGpb.Height;
            indexTbc.Location = new Point(12, amountGpb.Location.Y + amountGpb.Height + 5);
            if (chartdrawn)
            {
                drawKLine();
                drawAvg();
                drawVolume();
            }
            if (chartdrawn)
            {
                drawKLine();
                drawAvg();
                drawVolume();
            }
        }

        private void dateStartDtp_ValueChanged(object sender, EventArgs e)
        {
            
            DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
            dtFormat.ShortDatePattern = "yyyy-MM-dd";
            dateEndDtp.MinDate = Convert.ToDateTime("2015-01-05", dtFormat);
            dateEndDtp.MaxDate = Convert.ToDateTime("2016-04-01", dtFormat);
            dateEndDtp.MinDate = dateStartDtp.Value;
            dateEndDtp.MaxDate = dateStartDtp.Value.AddDays(50); 
        }

        private void fileSearchBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            filePathTbx.Text = openFileDialog.FileName;
            fileselected = true;
        }       

        private void inputBtn_Click(object sender, EventArgs e)
        {
            if (!fileselected)
            {
                MessageBox.Show("请先选择数据文件。");
                return;
            }            
            byte[] byteData = new byte[100];
            char[] charData = new char[100];
            try
            {
                String[] text = File.ReadAllLines(filePathTbx.Text);

                for (int i = 0; i < 304; i++)
                {
                    String T_date = String.Empty, T_start = String.Empty, T_end = String.Empty, 
                        T_max = String.Empty, T_min = String.Empty, T_vol = String.Empty;
                    for (int j = 0; j < 10; j++)
                    {
                        T_date += text[i][j];
                    }
                    for (int j = 11; j < 18; j++)
                    {
                        T_start += text[i][j];
                    }
                    for (int j = 19; j < 26; j++)
                    {
                        T_max += text[i][j];
                    }
                    for (int j = 27; j < 34; j++)
                    {
                        T_min += text[i][j];
                    }
                    for (int j = 35; j < 42; j++)
                    {
                        T_end += text[i][j];
                    }
                    for (int j = 43; j < text[i].Length; j++)
                    {
                        T_vol += text[i][j];
                    }
                    DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
                    dtFormat.ShortDatePattern = "yyyy-MM-dd";
                    dataIn[i].date = Convert.ToDateTime(T_date, dtFormat);

                    dataIn[i].start = Double.Parse(T_start);
                    dataIn[i].max = Double.Parse(T_max);
                    dataIn[i].min = Double.Parse(T_min);
                    dataIn[i].end = Double.Parse(T_end);
                    dataIn[i].vol = long.Parse(T_vol);
                }
                dataInput = true;

                Avg(5);//

            }
            catch (IOException err)
            {
                Console.WriteLine(err.ToString());
            }
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            if (!dataInput)
            {
                MessageBox.Show("请先导入数据。");
                return;
            }
            if ((dateStartDtp.Value.DayOfWeek == DayOfWeek.Saturday) ||
             (dateStartDtp.Value.DayOfWeek == DayOfWeek.Sunday))
            {
                dateStartDtp.Value = dateStartDtp.MinDate;
                MessageBox.Show("周末不是交易日，请重新选择开始日期。");
                return;
            }
            if ((dateEndDtp.Value.DayOfWeek == DayOfWeek.Saturday) ||
           (dateEndDtp.Value.DayOfWeek == DayOfWeek.Sunday))
            {
                dateEndDtp.Value = dateEndDtp.MinDate;
                MessageBox.Show("周末不是交易日，请重新选择结束日期。");
                return;
            }
            
            drawKLine();
            drawVolume();
            drawAvg();
            chartdrawn = true;
        }

        private void dateEndDtp_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void drawKLine()
        {
            int indexStart = 0, indexEnd = 0;
      
            for (int i = 0; i < 304; i++)
            {
                if (dataIn[i].date.CompareTo(dateStartDtp.Value) >= 0)
                {
                    indexStart = i;
                    break;
                }
            }
            for (int i = indexStart; i < 304; i++)
            {
                if (dataIn[i].date.CompareTo(dateEndDtp.Value) >= 0)
                {
                    indexEnd = i;
                    break;
                }
            }
            int rectangleWidth = (KlineGpb.Width - 40) / (indexEnd - indexStart + 1);

            double globalMax = 0, globalMin = Double.MaxValue;
            for (int i = indexStart; i < indexEnd + 1; i++)
            {
                if (avgPrice[i]<dataIn[i].max)//
                {
                    if (globalMax < dataIn[i].max)
                    {
                        globalMax = dataIn[i].max;
                    }
                }
                else
                {
                    if (globalMax < avgPrice[i])
                    {
                        globalMax = avgPrice[i];
                    }
                }

                if (avgPrice[i] > dataIn[i].min)//
                {
                    if (globalMin > dataIn[i].min)
                    {
                        globalMin = dataIn[i].min;
                    }
                }
                else
                {
                    if (globalMin > avgPrice[i])
                    {
                        globalMin = avgPrice[i];
                    }
                }
            }
            double pricePerPixar = (globalMax - globalMin) / (KlineGpb.Height - 40);

            
            kLine = KlineGpb.CreateGraphics();
            KlineGpb.Refresh();

            Pen positive = new Pen(Color.Red, 1);
            Pen negative = new Pen(Color.Green, 1);

            for (int i = indexStart; i < indexEnd + 1; i++)
            {
                int rectangleHeight = (int)Math.Ceiling(Math.Abs(((dataIn[i].start-dataIn[i].end)/pricePerPixar)));
                int rectangleX = 20 + (i - indexStart) * rectangleWidth;
                int rectangleY = 0;
                int maxY = (int)Math.Ceiling((dataIn[i].max - globalMin) / pricePerPixar) + 20;
                maxY = KlineGpb.Height - maxY;
                int minY = (int)Math.Ceiling((dataIn[i].min - globalMin) / pricePerPixar) + 20;
                minY = KlineGpb.Height - minY;

                Line max = new Line(), min = new Line();  
                max.start.X = (int)Math.Ceiling((0.5 + i - indexStart) * rectangleWidth) + 20;
                max.start.Y = KlineGpb.Height - ((int)Math.Ceiling((dataIn[i].max - globalMin) / pricePerPixar) + 20);
                max.end.X = (int)Math.Ceiling((0.5 + i - indexStart) * rectangleWidth) + 20;

                min.start.X = (int)Math.Ceiling((0.5 + i - indexStart) * rectangleWidth) + 20;
                min.end.X = (int)Math.Ceiling((0.5 + i - indexStart) * rectangleWidth) + 20;


                if (dataIn[i].start >= dataIn[i].end)
                {
                    rectangleY = (int)Math.Round((dataIn[i].start-globalMin) / pricePerPixar) +  20;
                    rectangleY = KlineGpb.Height  - rectangleY + rectangleHeight;
                    kLine.DrawRectangle(negative, rectangleX + 1, rectangleY, rectangleWidth - 2, rectangleHeight);

                    SolidBrush green = new SolidBrush(Color.Green);
                    kLine.FillRectangle(green, rectangleX + 1, rectangleY, rectangleWidth - 2, rectangleHeight);

                    max.end.Y = rectangleY;
                    kLine.DrawLine(negative,max.start,max.end);

                    min.start.Y = rectangleY+rectangleHeight;
                    int length = (int)Math.Round((Math.Min(dataIn[i].start, dataIn[i].end) - dataIn[i].min) / pricePerPixar);
                    min.end.Y = min.start.Y + length;
                    kLine.DrawLine(negative, min.start, min.end);

                }
                else
                {
                    rectangleY = (int)Math.Round((dataIn[i].end-globalMin) / pricePerPixar) +  20;
                    rectangleY = KlineGpb.Height  - rectangleY + rectangleHeight;
                    kLine.DrawRectangle(positive, rectangleX + 1, rectangleY, rectangleWidth - 2, rectangleHeight);

                    max.end.Y = rectangleY;
                    kLine.DrawLine(positive, max.start, max.end);

                    min.start.Y = rectangleY+rectangleHeight;
                    int length = (int)Math.Round((Math.Min(dataIn[i].start, dataIn[i].end) - dataIn[i].min) / pricePerPixar);
                    min.end.Y = min.start.Y + length;
                    kLine.DrawLine(positive, min.start, min.end);

                }
            }
            chartdrawn = true;
        }

        private void AvgLine(int n, Color linecolor)
        {
            Avg(n);

            int indexStart = 0, indexEnd = 0;

            for (int i = 0; i < 304; i++)
            {
                if (dataIn[i].date.CompareTo(dateStartDtp.Value) >= 0)
                {
                    indexStart = i;
                    break;
                }
            }
            for (int i = indexStart; i < 304; i++)
            {
                if (dataIn[i].date.CompareTo(dateEndDtp.Value) >= 0)
                {
                    indexEnd = i;
                    break;
                }
            }
            int rectangleWidth = (KlineGpb.Width - 40) / (indexEnd - indexStart + 1);

            double globalMax = 0, globalMin = Double.MaxValue;
            for (int i = indexStart; i < indexEnd + 1; i++)
            {
                if (avgPrice[i] < dataIn[i].max)//
                {
                    if (globalMax < dataIn[i].max)
                    {
                        globalMax = dataIn[i].max;
                    }
                }
                else
                {
                    if (globalMax < avgPrice[i])
                    {
                        globalMax = avgPrice[i];
                    }
                }

                if (avgPrice[i] > dataIn[i].min)//
                {
                    if (globalMin > dataIn[i].min)
                    {
                        globalMin = dataIn[i].min;
                    }
                }
                else
                {
                    if (globalMin > avgPrice[i])
                    {
                        globalMin = avgPrice[i];
                    }
                }
            }
            double pricePerPixar = (globalMax - globalMin) / (KlineGpb.Height - 40);

            Pen avg = new Pen(linecolor, 1);//

            for (int i = indexStart; i < indexEnd + 1; i++)
            {
                Line avgP = new Line();//

                avgP.start.X = (int)Math.Ceiling((0.5 + i - indexStart) * rectangleWidth) + 20;//
                avgP.start.Y = KlineGpb.Height - ((int)Math.Ceiling((avgPrice[i] - globalMin) / pricePerPixar) + 20);//
                avgP.end.X = (int)Math.Ceiling((1.5 + i - indexStart) * rectangleWidth) + 20;//
                avgP.end.Y = KlineGpb.Height - ((int)Math.Ceiling((avgPrice[i + 1] - globalMin) / pricePerPixar) + 20);//

                if (dataIn[i].start >= dataIn[i].end)
                {
                    kLine.DrawLine(avg, avgP.start, avgP.end);//
                }
                else
                {
                    kLine.DrawLine(avg, avgP.start, avgP.end);//
                }
            }
            chartdrawn = true;
        }

        private void Avg(int n)//
        {
            for (int i = 0; i < avgPrice.Length; i++)
            {
                avgPrice[i] = 0;
            }
                for (int i = 303; i > n; i--)
                {
                    double T_sum = 0;

                    for (int j = 0; j < n; j++)
                    {
                        T_sum += dataIn[i - j].end;//n日求和
                    }
                    avgPrice[i] = T_sum / n;
                }
        }
        private void drawAvg()
        {
            Color[] linecolors = new Color[6];
            linecolors[0] = Color.Black;
            linecolors[1] = Color.Orange;
            linecolors[2] = Color.Violet;
            linecolors[3] = Color.Green;
            linecolors[4] = Color.Blue;
            linecolors[5] = Color.Purple;
            bool[] linesToDraw = new bool[6];
            linesToDraw[0] = five_Cbx.Checked;
            linesToDraw[1] = ten_Cbx.Checked;
            linesToDraw[2] = twenty_Cbx.Checked;
            linesToDraw[3] = thrity_Cbx.Checked;
            linesToDraw[4] = default1_Cbx.Checked;
            linesToDraw[5] = default2_Cbx.Checked;
            int[] daysToDraw = { 5, 10, 20, 30, 0, 0 };
            if (linesToDraw[4]) daysToDraw[4] = Convert.ToInt32(default1_Tbx.Text);
            if (linesToDraw[5]) daysToDraw[5] = Convert.ToInt32(default2_Tbx.Text);
            for (int i = 0; i < 6; i++)
            {
                if (linesToDraw[i]) AvgLine(daysToDraw[i], linecolors[i]);
            }
        }
        private void drawVolume()
        {
            int indexStart = 0, indexEnd = 0;
            for (int i = 0; i < 304; i++)
            {
                if (dataIn[i].date.CompareTo(dateStartDtp.Value) >= 0)
                {
                    indexStart = i;
                    break;
                }
            }
            for (int i = indexStart; i < 211; i++)
            {
                if (dataIn[i].date.CompareTo(dateEndDtp.Value) >= 0)
                {
                    indexEnd = i;
                    break;
                }
            }

            int rectangle_width = (amountGpb.Width - 40) / (indexEnd - indexStart + 1);

            long rectangle_min = 0, rectangle_max = 0;
            long temp;

            for (int i = indexStart; i <= indexEnd; i++)    //得到最大值和最小值
            {
                if (rectangle_max < dataIn[i].vol)
                {
                    temp = dataIn[i].vol;
                    rectangle_max = temp;
                }
                if (rectangle_min > dataIn[i].vol)
                {
                    temp = dataIn[i].vol;
                    rectangle_min = temp;
                }
            }
            double volPerPixar = (rectangle_max - rectangle_min) / (amountGpb.Height - 40);   //每个像素代表多少成交量
            amountLine = amountGpb.CreateGraphics();
            amountGpb.Refresh();
            Pen increase = new Pen(Color.Red, 1);
            Pen decrease = new Pen(Color.Green, 1);

            for (int i = indexStart; i <= indexEnd; i++)
            {
                int rectangleHeight = (int)Math.Ceiling(Math.Abs((dataIn[i].vol / volPerPixar)));   //算出高度
                int rectangleX = 20 + (i - indexStart) * rectangle_width;
                int rectangleY = amountGpb.Height - rectangleHeight;

                if (dataIn[i].end >= dataIn[i - 1].end)

                    amountLine.DrawRectangle(increase, rectangleX + 1, rectangleY, rectangle_width - 2, rectangleHeight);
                else
                {
                    amountLine.DrawRectangle(decrease, rectangleX + 1, rectangleY, rectangle_width - 2, rectangleHeight);
                    SolidBrush green = new SolidBrush(Color.Green);
                    amountLine.FillRectangle(green, rectangleX + 1, rectangleY, rectangle_width - 2, rectangleHeight);
                }
            }
        }

    }
}
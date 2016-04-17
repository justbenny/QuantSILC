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
        double globalMax = 0, globalMin = Double.MaxValue;
        double pricePerPixar = 0;
        int rectangleWidth = 0;
        int roundDifference = 0;
        int indexStart = 0;
        int indexEnd = 0;
        bool[] linesToDraw = new bool[9];
        Color[] linecolors = new Color[9];
        int[] daysToDraw = new int[9];
        double[] kdata = new double[400];

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

        private void setColor()
        {
            linecolors[0] = Color.Black;
            linecolors[1] = Color.Orange;
            linecolors[2] = Color.Violet;
            linecolors[3] = Color.Green;
            linecolors[4] = Color.Blue;
            linecolors[5] = Color.Purple;
            linecolors[6] = Color.Brown;
            linecolors[7] = Color.BurlyWood;
            linecolors[8] = Color.Cyan;
        }

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
            dateEndDtp.MaxDate = dateStartDtp.Value.AddDays(300); 
            if (dateEndDtp.MaxDate.CompareTo(Convert.ToDateTime("2016-04-01", dtFormat))>0)
                dateEndDtp.MaxDate = Convert.ToDateTime("2016-04-01", dtFormat);
            findGlobal();
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
            checkDate();
            findGlobal();
            drawKLine();
            drawVolume();
            drawAvg();
            Knum();
            chartdrawn = true;
        }

        private void dateEndDtp_ValueChanged(object sender, EventArgs e)
        {
            findGlobal();
        }

        private void findGlobal()
        {
            for (int j = 0; j < 9; j++)
            {
                if (!linesToDraw[j])
                    continue;
                Avg(daysToDraw[j]);
                rectangleWidth = (KlineGpb.Width - 40) / (indexEnd - indexStart + 1);
                roundDifference = KlineGpb.Width - 40 - (rectangleWidth * (indexEnd - indexStart + 1));

                globalMax = 0;
                globalMin = Double.MaxValue;
                for (int i = indexStart; i < indexEnd + 1; i++)
                {
                    if (globalMax < avgPrice[i])
                        globalMax = avgPrice[i];
                    if (globalMax < dataIn[i].max)
                        globalMax = dataIn[i].max;
                    if ((globalMin > avgPrice[i]) && (avgPrice[i] != 0))
                        globalMin = avgPrice[i];
                    if (globalMin > dataIn[i].min)
                        globalMin = dataIn[i].min;
                }
                pricePerPixar = (globalMax - globalMin) / (KlineGpb.Height - 40);
            }
        }

        private void drawKLine()
        {           
            kLine = KlineGpb.CreateGraphics();
            KlineGpb.Refresh();

            Pen positive = new Pen(Color.Red, 1);
            Pen negative = new Pen(Color.Green, 1);

            int diffTemp = 0;
            for (int i = indexStart; i < indexEnd + 1; i++)
            {
                if (roundDifference > 0)
                {
                    diffTemp++;
                    roundDifference--;
                }
                int rectangleHeight = (int)Math.Ceiling(Math.Abs(((dataIn[i].start-dataIn[i].end)/pricePerPixar)));
                int rectangleX = 20 + (i - indexStart) * rectangleWidth + diffTemp;
               
                int rectangleY = 0;


                Line max = new Line(), min = new Line();  
                max.start.X = (int)Math.Ceiling((0.5 + i - indexStart) * rectangleWidth) + 20 +diffTemp;
                max.start.Y = KlineGpb.Height - (int)Math.Ceiling((dataIn[i].max - globalMin) / pricePerPixar) - 20;
                max.end.X = (int)Math.Ceiling((0.5 + i - indexStart) * rectangleWidth) + 20 + diffTemp;

                min.start.X = (int)Math.Ceiling((0.5 + i - indexStart) * rectangleWidth) + 20 + diffTemp;
                min.end.X = (int)Math.Ceiling((0.5 + i - indexStart) * rectangleWidth) + 20 + diffTemp;               

                if (dataIn[i].start >= dataIn[i].end)
                {
                    rectangleY = (int)Math.Round((dataIn[i].start-globalMin) / pricePerPixar);
                    rectangleY = KlineGpb.Height  - rectangleY - 20;
                    kLine.DrawRectangle(negative, rectangleX + 1, rectangleY, rectangleWidth - 2, rectangleHeight);
                     
                    SolidBrush green = new SolidBrush(Color.Green);
                    kLine.FillRectangle(green, rectangleX + 1, rectangleY, rectangleWidth - 2, rectangleHeight);

                    max.end.Y = rectangleY;
                    kLine.DrawLine(negative,max.start,max.end);

                    min.start.Y = rectangleY+rectangleHeight;
                    int length = (int)Math.Round((dataIn[i].end - dataIn[i].min) / pricePerPixar);
                    min.end.Y = min.start.Y + length;
                    kLine.DrawLine(negative, min.start, min.end);

                }
                else
                {
                    rectangleY = (int)Math.Round((dataIn[i].end-globalMin) / pricePerPixar);
                    rectangleY = KlineGpb.Height  - rectangleY - 20;
                    kLine.DrawRectangle(positive, rectangleX + 1, rectangleY, rectangleWidth - 2, rectangleHeight);

                    max.end.Y = rectangleY;
                    kLine.DrawLine(positive, max.start, max.end);

                    min.start.Y = rectangleY+rectangleHeight;
                    int length = (int)Math.Round((dataIn[i].start - dataIn[i].min) / pricePerPixar);
                    min.end.Y = min.start.Y + length;
                    kLine.DrawLine(positive, min.start, min.end);

                }
            }
            chartdrawn = true;
        }

        private void AvgLine(int n, Color linecolor)
        {
            Avg(n);
            Pen avg = new Pen(linecolor, 1);
            int diff = 0;
            for (int i = indexStart; i < indexEnd; i++)
            {
                if (avgPrice[i] == 0)
                    continue;
                Line avgP = new Line();
                
                avgP.start.X = (int)Math.Ceiling((0.5 + i - indexStart) * rectangleWidth) + 20 + diff;
                avgP.start.Y = KlineGpb.Height - (int)Math.Ceiling((avgPrice[i] - globalMin) / pricePerPixar) - 20;
                 if (roundDifference > 0)
                {
                    diff++;
                    roundDifference--;
                }
                avgP.end.X = (int)Math.Ceiling((1.5 + i - indexStart) * rectangleWidth) + 20 + diff;
                avgP.end.Y = KlineGpb.Height - (int)Math.Ceiling((avgPrice[i + 1] - globalMin) / pricePerPixar) - 20;
               
                if (dataIn[i].start >= dataIn[i].end)
                {
                    kLine.DrawLine(avg, avgP.start, avgP.end);
                }
                else
                {
                    kLine.DrawLine(avg, avgP.start, avgP.end);
                }
            }
            chartdrawn = true;
        }
        private void Avg(int n)
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
            for (int j = 0; j < 9; j++)
            {
                if (linesToDraw[j]) AvgLine(daysToDraw[j], linecolors[j]);
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
            for (int i = indexStart; i < 304; i++)
            {
                if (dataIn[i].date.CompareTo(dateEndDtp.Value) >= 0)
                {
                    indexEnd = i;
                    break;
                }
            }

            int rectangle_width = (amountGpb.Width - 40) / (indexEnd - indexStart + 1);
            int roundDifference = amountGpb.Width - 40 - (rectangle_width * (indexEnd - indexStart + 1));

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

            int diff = 0;
            for (int i = indexStart; i <= indexEnd; i++)
            {
                int rectangleHeight = (int)Math.Ceiling(dataIn[i].vol / volPerPixar);   //算出高度
                if (roundDifference > 0)
                {
                    diff++;
                    roundDifference--;
                }
                int rectangleX = 20 + (i - indexStart) * rectangle_width + diff ;
                int rectangleY = amountGpb.Height - rectangleHeight;

                if (i == 0)
                {
                    amountLine.DrawRectangle(increase, rectangleX + 1, rectangleY, rectangle_width - 2, rectangleHeight);
                    continue;
                }
                if (dataIn[i].end >= dataIn[i - 1].end)
                {
                    amountLine.DrawRectangle(increase, rectangleX + 1, rectangleY, rectangle_width - 2, rectangleHeight);
                }
                else
                {
                    amountLine.DrawRectangle(decrease, rectangleX + 1, rectangleY, rectangle_width - 2, rectangleHeight);
                    SolidBrush green = new SolidBrush(Color.Green);
                    amountLine.FillRectangle(green, rectangleX + 1, rectangleY, rectangle_width - 2, rectangleHeight);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setColor();
            checkToDraw();
            checkDays();
            KlineGpb.MouseDown += KlineGpb_MouseDown;
        }

        void KlineGpb_MouseDown(object sender, MouseEventArgs e)
        {
            if (!chartdrawn)
                return;
            KlineGpb.Refresh();            
            drawKLine();
            drawAvg();            
            Line horizontal = new Line();
            if (e.Y < 20)
            {
                horizontal.start = new Point(20, 20);
                horizontal.end = new Point(KlineGpb.Width - 20, 20);
            }
            else if (e.Y > (KlineGpb.Height - 20))
            {
                horizontal.start = new Point(20, (KlineGpb.Height - 20));
                horizontal.end = new Point(KlineGpb.Width - 20, (KlineGpb.Height - 20));
            }
            else
            {
                horizontal.start = new Point(20, e.Y);
                horizontal.end = new Point(KlineGpb.Width - 20, e.Y);
            }
            kLine = KlineGpb.CreateGraphics();
            kLine.DrawLine(new Pen(new SolidBrush(Color.Black)), horizontal.start, horizontal.end);
        }

        private void default0_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            linesToDraw[0] = default0_Cbx.Checked;
            findGlobal();
        }

        private void default1_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            linesToDraw[1] = default1_Cbx.Checked;
            findGlobal();
        }

        private void default2_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            linesToDraw[2] = default2_Cbx.Checked;
            findGlobal();
        }

        private void default3_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            linesToDraw[3] = default3_Cbx.Checked;
            findGlobal();
        }

        private void default4_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            linesToDraw[4] = default4_Cbx.Checked;
            findGlobal();
        }

        private void default5_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            linesToDraw[5] = default5_Cbx.Checked;
            findGlobal();
        }

        private void default6_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            linesToDraw[6] = default6_Cbx.Checked;
            findGlobal();
        }

        private void default7_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            linesToDraw[7] = default7_Cbx.Checked;
            findGlobal();
        }

        private void default8_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            linesToDraw[8] = default8_Cbx.Checked;
            findGlobal();
        }

        private void default0_Tbx_TextChanged(object sender, EventArgs e)
        {
            daysToDraw[0] = Convert.ToInt32(default0_Tbx.Text);
        }

        private void default1_Tbx_TextChanged(object sender, EventArgs e)
        {
            daysToDraw[1] = Convert.ToInt32(default1_Tbx.Text);
        }

        private void default2_Tbx_TextChanged(object sender, EventArgs e)
        {
            daysToDraw[2] = Convert.ToInt32(default2_Tbx.Text);
        }

        private void default3_Tbx_TextChanged(object sender, EventArgs e)
        {
            daysToDraw[3] = Convert.ToInt32(default3_Tbx.Text);
        }

        private void default4_Tbx_TextChanged(object sender, EventArgs e)
        {
            daysToDraw[4] = Convert.ToInt32(default4_Tbx.Text);
        }

        private void default5_Tbx_TextChanged(object sender, EventArgs e)
        {
            daysToDraw[5] = Convert.ToInt32(default5_Tbx.Text);
        }

        private void default6_Tbx_TextChanged(object sender, EventArgs e)
        {
            daysToDraw[6] = Convert.ToInt32(default6_Tbx.Text);
        }

        private void default7_Tbx_TextChanged(object sender, EventArgs e)
        {
            daysToDraw[7] = Convert.ToInt32(default7_Tbx.Text);
        }

        private void default8_Tbx_TextChanged(object sender, EventArgs e)
        {
            daysToDraw[8] = Convert.ToInt32(default8_Tbx.Text);
        }

        private void checkToDraw()
        {
            linesToDraw[0] = default0_Cbx.Checked;
            linesToDraw[1] = default1_Cbx.Checked;
            linesToDraw[2] = default2_Cbx.Checked;
            linesToDraw[3] = default3_Cbx.Checked;
            linesToDraw[4] = default4_Cbx.Checked;
            linesToDraw[5] = default5_Cbx.Checked;
            linesToDraw[6] = default6_Cbx.Checked;
            linesToDraw[7] = default7_Cbx.Checked;
            linesToDraw[8] = default8_Cbx.Checked;
        }

        private void checkDate()
        {
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
        }

        private void checkDays()
        {
            if (linesToDraw[0]) daysToDraw[0] = Convert.ToInt32(default0_Tbx.Text);
            if (linesToDraw[1]) daysToDraw[1] = Convert.ToInt32(default1_Tbx.Text);
            if (linesToDraw[2]) daysToDraw[2] = Convert.ToInt32(default2_Tbx.Text);
            if (linesToDraw[3]) daysToDraw[3] = Convert.ToInt32(default3_Tbx.Text);
            if (linesToDraw[4]) daysToDraw[4] = Convert.ToInt32(default4_Tbx.Text);
            if (linesToDraw[5]) daysToDraw[5] = Convert.ToInt32(default5_Tbx.Text);
            if (linesToDraw[6]) daysToDraw[6] = Convert.ToInt32(default6_Tbx.Text);
            if (linesToDraw[7]) daysToDraw[7] = Convert.ToInt32(default7_Tbx.Text);
            if (linesToDraw[8]) daysToDraw[8] = Convert.ToInt32(default8_Tbx.Text);
        }

        private double RSV(int dayIndex, int n)
        {
            double high = 0, low = Double.MaxValue;
            if (dayIndex >= n)
            {
                for (int i = n; i >= 0; i--)
                {
                    if (high < dataIn[dayIndex - i].max)
                    {
                        high = dataIn[dayIndex - i].max;
                    }
                    if (low > dataIn[dayIndex - i].min)
                    {
                        low = dataIn[dayIndex - i].min;
                    }
                }
            }
            else
            {
                for (int i = dayIndex; i >= 0; i--)
                {
                    if (high < dataIn[dayIndex - i].max)
                    {
                        high = dataIn[dayIndex - i].max;
                    }
                    if (low > dataIn[dayIndex - i].min)
                    {
                        low = dataIn[dayIndex - i].min;
                    }
                }
            }
            return (dataIn[dayIndex].end - low) / (high - low) * 100;
        }

        private void Knum()
        {
            kdata[0] = 100 / 3.0 + RSV(0, 9) / 3;
            for (int i = 1; i < 304; i++)
            {
                kdata[i] = (kdata[i - 1] * 2 / 3) + (RSV(i, 9) / 3);
            }
        }
    }
}
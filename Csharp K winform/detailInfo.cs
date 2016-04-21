using System;
using System.Windows.Forms;

namespace Csharp_K_winform
{
    public partial class detailInfo : Form
    {
        public detailInfo()
        {
            InitializeComponent();
        }

        private void detailInfo_Load(object sender, EventArgs e)
        {
            dateInfoLbl.Text = Form1.dataIn[Form1.infoIndex].date.ToString();
            highInfoLbl.Text = Form1.dataIn[Form1.infoIndex].max.ToString();
            lowInfoLbl.Text= Form1.dataIn[Form1.infoIndex].min.ToString();
            startInfoLbl.Text= Form1.dataIn[Form1.infoIndex].start.ToString();
            endInfoLbl.Text= Form1.dataIn[Form1.infoIndex].end.ToString();
            volInfoLbl.Text= Form1.dataIn[Form1.infoIndex].vol.ToString();
            LostFocus += DetailInfo_LostFocus;
        }

        private void DetailInfo_LostFocus(object sender, EventArgs e)
        {
            Close();
        }
    }
}

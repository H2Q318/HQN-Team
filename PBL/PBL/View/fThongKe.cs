using PBL.BLL;
using System;
using System.Windows.Forms;

namespace PBL
{
    public partial class fThongKe : Form
    {
        public fThongKe()
        {
            InitializeComponent();
            SetGUI();
        }

        private void SetGUI()
        {
            cbType.SelectedIndex = 0;
        }
        private void fillChart(int month)
        {
            chartRevenue.Series["Doanh thu"].Points.Clear();
            if (month == 0)
            {
                chartRevenue.ChartAreas[0].AxisX.Minimum = 1;
                chartRevenue.ChartAreas[0].AxisX.Maximum = 12;
                decimal[] data = BLL_QLBill.Instance.GetRevenueDataInYear();
                for (int i = 0; i < data.Length; i++)
                {
                    chartRevenue.Series["Doanh thu"].Points.AddXY(i + 1, data[i]);
                }
            }
            else
            {
                decimal[] data = BLL_QLBill.Instance.GetRevenueDataInMonth(cbType.SelectedIndex);
                chartRevenue.ChartAreas[0].AxisX.Minimum = 1;
                chartRevenue.ChartAreas[0].AxisX.Maximum = data.Length;
                chartRevenue.ChartAreas[0].AxisX.Interval = 1;
                for (int i = 0; i < data.Length; i++)
                {
                    chartRevenue.Series["Doanh thu"].Points.AddXY(i + 1, data[i]);
                }
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            const string titleChart = "Biểu đồ thống kê doanh thu";
            chartRevenue.Titles[0].Text = titleChart + " " + cbType.SelectedItem.ToString().ToLower();
            fillChart(cbType.SelectedIndex);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            chartRevenue.Printing.PrintPreview();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Syncfusion.Windows.Forms.Chart;
using WinChart = System.Windows.Forms.DataVisualization.Charting;
using TheMatchaClub.WinForms.Helpers;

namespace TheMatchaClub.Winforms
{
    public partial class SalesReportForm: Form
    {
        private WinChart.Chart _chart = new();


        public SalesReportForm()
        {
            InitializeComponent();
            Load += SalesReportForm_Load;
            SetupChart();
        }
        private void SetupChart()
        {
            _chart.Dock = DockStyle.Fill;

            var area = new WinChart.ChartArea("Main");

            _chart.ChartAreas.Add(area);

            Controls.Add(_chart);
        }
        private async void SalesReportForm_Load(object? sender, EventArgs e)
        {
            using var context = DbContextHelper.Create();

            var sessions = await context.BusinessSessions
                .OrderBy(x => x.StartDateTime)
                .Select(x => new
                {
                    x.SessionName,
                    x.TotalSales
                })
                .ToListAsync();

            _chart.Series.Clear();

            var series = new WinChart.Series("Sales")
            {
                ChartType = WinChart.SeriesChartType.Column
            };


            foreach (var s in sessions)
            {
                series.Points.AddXY(s.SessionName, s.TotalSales);
            }

            _chart.Series.Add(series);
        }
    }
}

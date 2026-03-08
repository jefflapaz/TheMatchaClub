using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheMatchaClub.Winforms.Forms;
using TheMatchaClub.WinForms.Helpers;
using WinChart = System.Windows.Forms.DataVisualization.Charting;

namespace TheMatchaClub.Winforms
{
    public partial class SalesReportControl : UserControl
    {
        private WinChart.Chart _chart = new();

        public SalesReportControl()
        {
            InitializeComponent();
            this.Load += SalesReportControl_Load;
            SetupChart();
        }

        private void SetupChart()
        {
            _chart.Dock = DockStyle.Fill;
            _chart.BackColor = Color.White;

            var area = new WinChart.ChartArea("Main")
            {
                BackColor = Color.FromArgb(250, 250, 240) // Light matcha cream
            };

            // Clean up the grid lines for a modern look
            area.AxisX.MajorGrid.LineColor = Color.LightGray;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9);
            area.AxisY.LabelStyle.Format = "₱{0}";

            _chart.ChartAreas.Clear();
            _chart.ChartAreas.Add(area);

            // Add a title
            var title = new WinChart.Title("Session Sales Performance")
            {
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(53, 108, 27)
            };
            _chart.Titles.Add(title);

            Controls.Add(_chart);
        }

        private async void SalesReportControl_Load(object? sender, EventArgs e)
        {
            await RefreshChartData();
        }

        public async Task RefreshChartData()
        {
            try
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

                if (sessions == null || !sessions.Any())
                {
                    MyUniversalBox.Show("No session data available to generate a report.", "Analytics", isError: false);
                    return;
                }

                var series = new WinChart.Series("Sales")
                {
                    ChartType = WinChart.SeriesChartType.Column,
                    Color = Color.FromArgb(120, 160, 80), // Matcha Green
                    BorderColor = Color.FromArgb(53, 108, 27),
                    BorderWidth = 1
                };

                foreach (var s in sessions)
                {
                    series.Points.AddXY(s.SessionName, s.TotalSales);
                }

                _chart.Series.Add(series);
            }
            catch (Exception ex)
            {
                MyUniversalBox.Show($"Failed to load sales chart: {ex.Message}", "Report Error", isError: true);
            }
        }
    }
}
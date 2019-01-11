using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace milionerzy
{
    public partial class Statystyki : UserControl
    {
        public Statystyki()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            JiPP2018Z502Entities JippEntities = new JiPP2018Z502Entities();
            rankingGrid.DataSource = JippEntities.Historia_Gier.ToList();
            rankingGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            narysujWykresPunktów();
            narysujWykresPytan();
            narysujWykresKolRatunkowych();
        }

        private void wygenerujWykres(Chart chart, string seriesName, SeriesChartType type)
        {
            chart.Series.Clear();
            chart.Legends.Clear();

            chart.Legends.Add("Legenda");
            chart.Legends[0].LegendStyle = LegendStyle.Table;
            chart.Legends[0].Docking = Docking.Bottom;
            chart.Legends[0].Alignment = StringAlignment.Center;
            chart.Legends[0].Title = "Legenda";
            chart.Legends[0].BorderColor = Color.Black;

            chart.Series.Add(seriesName);

            chart.Series[seriesName].ChartType = type;
        }

        private void narysujWykresPunktów()
        {
            wygenerujWykres(punktyChart, "wartość wygranej", SeriesChartType.Pie);

            int[,] result = new int[7, 2] { { 250, 0 }, { 2000, 0 }, { 20000, 0 }, { 100000, 0 }, { 250000, 0 }, { 500000, 0 }, { 1000000, 0 } };


            int index = 1;
            using (JiPP2018Z502Entities JippEntities = new JiPP2018Z502Entities())
            {
                foreach (Historia_Gier p in JippEntities.Historia_Gier)
                {
                    for (int i = 0; i < result.Length / 2; i++)
                    {
                        if (p.Wynik == result[i, 0])
                            result[i, 1]++;
                    }
                }
            }

            for (int i = 0; i < result.Length / 2; i++)
                punktyChart.Series["wartość wygranej"].Points.AddXY(result[i, 0], result[i, 1]);
        }

        private void narysujWykresPytan()
        {
            wygenerujWykres(pytaniaChart, "pytania", SeriesChartType.Area);

            int[,] result = new int[7, 2] { { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 }, { 6, 0 }, { 7, 0 } };

            int index = 1;
            using (JiPP2018Z502Entities JippEntities = new JiPP2018Z502Entities())
            {
                foreach (Historia_Gier p in JippEntities.Historia_Gier)
                {
                    for (int i = 0; i < result.Length / 2; i++)
                    {
                        if (p.Pytanie_koncowe == result[i, 0])
                            result[i, 1]++;
                    }
                }
            }

            for (int i = 0; i < result.Length / 2; i++)
                pytaniaChart.Series["pytania"].Points.AddXY(result[i, 0], result[i, 1]);
        }

        private void narysujWykresKolRatunkowych()
        {
            wygenerujWykres(kolaChart, "kola", SeriesChartType.RangeColumn);

            int[,] result = new int[3, 2] { { 1, 0 }, { 2, 0 }, { 3, 0 } };

            int index = 1;
            using (JiPP2018Z502Entities JippEntities = new JiPP2018Z502Entities())
            {
                foreach (Historia_Gier p in JippEntities.Historia_Gier)
                {
                    for (int i = 0; i < result.Length / 2; i++)
                    {
                        if (p.Uzyte_kola == result[i, 0])
                            result[i, 1]++;
                    }
                }
            }

            for (int i = 0; i < result.Length / 2; i++)
                kolaChart.Series["kola"].Points.AddXY(result[i, 0], result[i, 1]);
        }

    }
}


namespace milionerzy
{
    partial class Statystyki
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statystyki));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PunktyLabel = new System.Windows.Forms.Label();
            this.PytaniaLabel = new System.Windows.Forms.Label();
            this.kolaLabel = new System.Windows.Forms.Label();
            this.punktyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pytaniaChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.kolaChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rankingGrid = new System.Windows.Forms.DataGridView();
            this.RankingLabel = new System.Windows.Forms.Label();
            this.wyswietlRankingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nickDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wynikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uzytekolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pytaniekoncoweDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.punktyChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pytaniaChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolaChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankingGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyswietlRankingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.Controls.Add(this.PunktyLabel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.PytaniaLabel, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.kolaLabel, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.punktyChart, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.pytaniaChart, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.kolaChart, 3, 11);
            this.tableLayoutPanel1.Controls.Add(this.rankingGrid, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.RankingLabel, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(748, 443);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PunktyLabel
            // 
            this.PunktyLabel.AutoSize = true;
            this.PunktyLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PunktyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PunktyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PunktyLabel.Location = new System.Drawing.Point(413, 17);
            this.PunktyLabel.Name = "PunktyLabel";
            this.PunktyLabel.Size = new System.Drawing.Size(308, 22);
            this.PunktyLabel.TabIndex = 0;
            this.PunktyLabel.Text = "PUNKTY";
            this.PunktyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PytaniaLabel
            // 
            this.PytaniaLabel.AutoSize = true;
            this.PytaniaLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PytaniaLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PytaniaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PytaniaLabel.Location = new System.Drawing.Point(413, 157);
            this.PytaniaLabel.Name = "PytaniaLabel";
            this.PytaniaLabel.Size = new System.Drawing.Size(308, 22);
            this.PytaniaLabel.TabIndex = 1;
            this.PytaniaLabel.Text = "PYTANIA";
            this.PytaniaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kolaLabel
            // 
            this.kolaLabel.AutoSize = true;
            this.kolaLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.kolaLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kolaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kolaLabel.Location = new System.Drawing.Point(413, 297);
            this.kolaLabel.Name = "kolaLabel";
            this.kolaLabel.Size = new System.Drawing.Size(308, 22);
            this.kolaLabel.TabIndex = 2;
            this.kolaLabel.Text = "KOŁA RATUNKOWE";
            this.kolaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // punktyChart
            // 
            chartArea1.Name = "ChartArea1";
            this.punktyChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.punktyChart.Legends.Add(legend1);
            this.punktyChart.Location = new System.Drawing.Point(413, 55);
            this.punktyChart.Name = "punktyChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.punktyChart.Series.Add(series1);
            this.punktyChart.Size = new System.Drawing.Size(300, 82);
            this.punktyChart.TabIndex = 3;
            this.punktyChart.Text = "chart1";
            // 
            // pytaniaChart
            // 
            chartArea2.Name = "ChartArea1";
            this.pytaniaChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.pytaniaChart.Legends.Add(legend2);
            this.pytaniaChart.Location = new System.Drawing.Point(413, 195);
            this.pytaniaChart.Name = "pytaniaChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.pytaniaChart.Series.Add(series2);
            this.pytaniaChart.Size = new System.Drawing.Size(300, 82);
            this.pytaniaChart.TabIndex = 4;
            this.pytaniaChart.Text = "chart2";
            // 
            // kolaChart
            // 
            chartArea3.Name = "ChartArea1";
            this.kolaChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.kolaChart.Legends.Add(legend3);
            this.kolaChart.Location = new System.Drawing.Point(413, 335);
            this.kolaChart.Name = "kolaChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.kolaChart.Series.Add(series3);
            this.kolaChart.Size = new System.Drawing.Size(300, 82);
            this.kolaChart.TabIndex = 5;
            this.kolaChart.Text = "chart3";
            // 
            // rankingGrid
            // 
            this.rankingGrid.AllowUserToAddRows = false;
            this.rankingGrid.AllowUserToDeleteRows = false;
            this.rankingGrid.AutoGenerateColumns = false;
            this.rankingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rankingGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nickDataGridViewTextBoxColumn,
            this.wynikDataGridViewTextBoxColumn,
            this.uzytekolaDataGridViewTextBoxColumn,
            this.pytaniekoncoweDataGridViewTextBoxColumn});
            this.rankingGrid.DataSource = this.wyswietlRankingBindingSource;
            this.rankingGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rankingGrid.Location = new System.Drawing.Point(25, 55);
            this.rankingGrid.Name = "rankingGrid";
            this.rankingGrid.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.rankingGrid, 9);
            this.rankingGrid.Size = new System.Drawing.Size(345, 362);
            this.rankingGrid.TabIndex = 6;
            // 
            // RankingLabel
            // 
            this.RankingLabel.AutoSize = true;
            this.RankingLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RankingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RankingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RankingLabel.Location = new System.Drawing.Point(25, 17);
            this.RankingLabel.Name = "RankingLabel";
            this.RankingLabel.Size = new System.Drawing.Size(345, 22);
            this.RankingLabel.TabIndex = 7;
            this.RankingLabel.Text = "RANKING";
            this.RankingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nickDataGridViewTextBoxColumn
            // 
            this.nickDataGridViewTextBoxColumn.DataPropertyName = "Nick";
            this.nickDataGridViewTextBoxColumn.HeaderText = "Nick";
            this.nickDataGridViewTextBoxColumn.Name = "nickDataGridViewTextBoxColumn";
            this.nickDataGridViewTextBoxColumn.ReadOnly = true;
            this.nickDataGridViewTextBoxColumn.Width = 60;
            // 
            // wynikDataGridViewTextBoxColumn
            // 
            this.wynikDataGridViewTextBoxColumn.DataPropertyName = "Wynik";
            this.wynikDataGridViewTextBoxColumn.HeaderText = "Wynik";
            this.wynikDataGridViewTextBoxColumn.Name = "wynikDataGridViewTextBoxColumn";
            this.wynikDataGridViewTextBoxColumn.ReadOnly = true;
            this.wynikDataGridViewTextBoxColumn.Width = 80;
            // 
            // uzytekolaDataGridViewTextBoxColumn
            // 
            this.uzytekolaDataGridViewTextBoxColumn.DataPropertyName = "Uzyte_kola";
            this.uzytekolaDataGridViewTextBoxColumn.HeaderText = "Użyte Koła";
            this.uzytekolaDataGridViewTextBoxColumn.Name = "uzytekolaDataGridViewTextBoxColumn";
            this.uzytekolaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pytaniekoncoweDataGridViewTextBoxColumn
            // 
            this.pytaniekoncoweDataGridViewTextBoxColumn.DataPropertyName = "Pytanie_koncowe";
            this.pytaniekoncoweDataGridViewTextBoxColumn.HeaderText = "Pytanie Końcowe";
            this.pytaniekoncoweDataGridViewTextBoxColumn.Name = "pytaniekoncoweDataGridViewTextBoxColumn";
            this.pytaniekoncoweDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Statystyki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Statystyki";
            this.Size = new System.Drawing.Size(748, 443);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.punktyChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pytaniaChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolaChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankingGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyswietlRankingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label PunktyLabel;
        private System.Windows.Forms.Label PytaniaLabel;
        private System.Windows.Forms.Label kolaLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart punktyChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart pytaniaChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart kolaChart;
        private System.Windows.Forms.Label RankingLabel;
        private System.Windows.Forms.DataGridView rankingGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nickDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wynikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uzytekolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pytaniekoncoweDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource wyswietlRankingBindingSource;
    }
}

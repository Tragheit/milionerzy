namespace milionerzy
{
    partial class KoniecGry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KoniecGry));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nickLabel = new System.Windows.Forms.Label();
            this.wynikLabel = new System.Windows.Forms.Label();
            this.pytanieLabel = new System.Windows.Forms.Label();
            this.kołaLabel = new System.Windows.Forms.Label();
            this.telefonPB = new System.Windows.Forms.PictureBox();
            this.publikaPB = new System.Windows.Forms.PictureBox();
            this.polowaPB = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telefonPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publikaPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polowaPB)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.nickLabel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.wynikLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pytanieLabel, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.kołaLabel, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.publikaPB, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.telefonPB, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.polowaPB, 5, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(891, 389);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // nickLabel
            // 
            this.nickLabel.AutoSize = true;
            this.nickLabel.BackColor = System.Drawing.Color.YellowGreen;
            this.nickLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nickLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nickLabel.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nickLabel.Location = new System.Drawing.Point(313, 19);
            this.nickLabel.Name = "nickLabel";
            this.nickLabel.Size = new System.Drawing.Size(261, 58);
            this.nickLabel.TabIndex = 0;
            this.nickLabel.Text = "label1";
            this.nickLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wynikLabel
            // 
            this.wynikLabel.AutoSize = true;
            this.wynikLabel.BackColor = System.Drawing.Color.YellowGreen;
            this.wynikLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wynikLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wynikLabel.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynikLabel.Location = new System.Drawing.Point(47, 96);
            this.wynikLabel.Name = "wynikLabel";
            this.wynikLabel.Size = new System.Drawing.Size(216, 58);
            this.wynikLabel.TabIndex = 1;
            this.wynikLabel.Text = "WYNIK";
            this.wynikLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pytanieLabel
            // 
            this.pytanieLabel.AutoSize = true;
            this.pytanieLabel.BackColor = System.Drawing.Color.YellowGreen;
            this.pytanieLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pytanieLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pytanieLabel.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pytanieLabel.Location = new System.Drawing.Point(624, 96);
            this.pytanieLabel.Name = "pytanieLabel";
            this.pytanieLabel.Size = new System.Drawing.Size(216, 58);
            this.pytanieLabel.TabIndex = 2;
            this.pytanieLabel.Text = "PYTANIE";
            this.pytanieLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kołaLabel
            // 
            this.kołaLabel.AutoSize = true;
            this.kołaLabel.BackColor = System.Drawing.Color.YellowGreen;
            this.kołaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kołaLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kołaLabel.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kołaLabel.Location = new System.Drawing.Point(313, 173);
            this.kołaLabel.Name = "kołaLabel";
            this.kołaLabel.Size = new System.Drawing.Size(261, 58);
            this.kołaLabel.TabIndex = 3;
            this.kołaLabel.Text = "WYKORZYSTANE KOŁA RATUNKOWE";
            this.kołaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // telefonPB
            // 
            this.telefonPB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("telefonPB.BackgroundImage")));
            this.telefonPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.telefonPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.telefonPB.InitialImage = null;
            this.telefonPB.Location = new System.Drawing.Point(47, 253);
            this.telefonPB.Name = "telefonPB";
            this.telefonPB.Size = new System.Drawing.Size(216, 110);
            this.telefonPB.TabIndex = 4;
            this.telefonPB.TabStop = false;
            // 
            // publikaPB
            // 
            this.publikaPB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("publikaPB.BackgroundImage")));
            this.publikaPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.publikaPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.publikaPB.Location = new System.Drawing.Point(313, 253);
            this.publikaPB.Name = "publikaPB";
            this.publikaPB.Size = new System.Drawing.Size(261, 110);
            this.publikaPB.TabIndex = 5;
            this.publikaPB.TabStop = false;
            // 
            // polowaPB
            // 
            this.polowaPB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("polowaPB.BackgroundImage")));
            this.polowaPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.polowaPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.polowaPB.Location = new System.Drawing.Point(624, 253);
            this.polowaPB.Name = "polowaPB";
            this.polowaPB.Size = new System.Drawing.Size(216, 110);
            this.polowaPB.TabIndex = 6;
            this.polowaPB.TabStop = false;
            // 
            // KoniecGry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "KoniecGry";
            this.Size = new System.Drawing.Size(891, 389);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telefonPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publikaPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polowaPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label nickLabel;
        private System.Windows.Forms.Label wynikLabel;
        private System.Windows.Forms.Label pytanieLabel;
        private System.Windows.Forms.Label kołaLabel;
        private System.Windows.Forms.PictureBox publikaPB;
        private System.Windows.Forms.PictureBox telefonPB;
        private System.Windows.Forms.PictureBox polowaPB;
    }
}

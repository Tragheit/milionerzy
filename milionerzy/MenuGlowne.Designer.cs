namespace milionerzy
{
    partial class MenuGlowne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuGlowne));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nowGraButton = new System.Windows.Forms.Button();
            this.wyjdzButton = new System.Windows.Forms.Button();
            this.statystykiButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.nowGraButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.wyjdzButton, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.statystykiButton, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.347826F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.13044F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.347826F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.347826F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.347826F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.347826F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(736, 424);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // nowGraButton
            // 
            this.nowGraButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.nowGraButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nowGraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nowGraButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nowGraButton.ForeColor = System.Drawing.Color.Gold;
            this.nowGraButton.Location = new System.Drawing.Point(260, 204);
            this.nowGraButton.Name = "nowGraButton";
            this.nowGraButton.Size = new System.Drawing.Size(214, 49);
            this.nowGraButton.TabIndex = 1;
            this.nowGraButton.Text = "NOWA GRA";
            this.nowGraButton.UseVisualStyleBackColor = false;
            this.nowGraButton.Click += new System.EventHandler(this.nowaGraClicked);
            // 
            // wyjdzButton
            // 
            this.wyjdzButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.wyjdzButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wyjdzButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wyjdzButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyjdzButton.ForeColor = System.Drawing.Color.Gold;
            this.wyjdzButton.Location = new System.Drawing.Point(260, 350);
            this.wyjdzButton.Name = "wyjdzButton";
            this.wyjdzButton.Size = new System.Drawing.Size(214, 49);
            this.wyjdzButton.TabIndex = 2;
            this.wyjdzButton.Text = "WYJDŹ";
            this.wyjdzButton.UseVisualStyleBackColor = false;
            this.wyjdzButton.Click += new System.EventHandler(this.koniecGryClicked);
            // 
            // statystykiButton
            // 
            this.statystykiButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.statystykiButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statystykiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statystykiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statystykiButton.ForeColor = System.Drawing.Color.Gold;
            this.statystykiButton.Location = new System.Drawing.Point(260, 277);
            this.statystykiButton.Name = "statystykiButton";
            this.statystykiButton.Size = new System.Drawing.Size(214, 49);
            this.statystykiButton.TabIndex = 3;
            this.statystykiButton.Text = "STATYSTYKI";
            this.statystykiButton.UseVisualStyleBackColor = false;
            this.statystykiButton.Click += new System.EventHandler(this.statystykiClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(113, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 165);
            this.label1.TabIndex = 4;
            this.label1.Text = "MILIONERZY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MenuGlowne";
            this.Size = new System.Drawing.Size(736, 424);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button nowGraButton;
        private System.Windows.Forms.Button statystykiButton;
        private System.Windows.Forms.Button wyjdzButton;
        private System.Windows.Forms.Label label1;
    }
}

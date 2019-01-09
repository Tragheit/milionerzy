namespace milionerzy
{
    partial class PodajNick
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.podajNickLabel = new System.Windows.Forms.Label();
            this.podajNickTextBox = new System.Windows.Forms.TextBox();
            this.podajNickButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Wheat;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.347826F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.47826F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.347826F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.47826F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.347826F));
            this.tableLayoutPanel1.Controls.Add(this.podajNickLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.podajNickTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.podajNickButton, 3, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(321, 215);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // podajNickLabel
            // 
            this.podajNickLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.podajNickLabel, 3);
            this.podajNickLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.podajNickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.podajNickLabel.Location = new System.Drawing.Point(16, 21);
            this.podajNickLabel.Name = "podajNickLabel";
            this.podajNickLabel.Size = new System.Drawing.Size(285, 43);
            this.podajNickLabel.TabIndex = 0;
            this.podajNickLabel.Text = "Wprowadź nazwę gracza";
            // 
            // podajNickTextBox
            // 
            this.podajNickTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.podajNickTextBox.Location = new System.Drawing.Point(16, 88);
            this.podajNickTextBox.Name = "podajNickTextBox";
            this.podajNickTextBox.Size = new System.Drawing.Size(133, 20);
            this.podajNickTextBox.TabIndex = 1;
            // 
            // podajNickButton
            // 
            this.podajNickButton.BackColor = System.Drawing.Color.Chartreuse;
            this.podajNickButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.podajNickButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.podajNickButton.Location = new System.Drawing.Point(168, 152);
            this.podajNickButton.Name = "podajNickButton";
            this.podajNickButton.Size = new System.Drawing.Size(133, 37);
            this.podajNickButton.TabIndex = 2;
            this.podajNickButton.Text = "Start";
            this.podajNickButton.UseVisualStyleBackColor = false;
            this.podajNickButton.Click += new System.EventHandler(this.startButtonClicked);
            // 
            // PodajNick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PodajNick";
            this.Size = new System.Drawing.Size(321, 215);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label podajNickLabel;
        private System.Windows.Forms.TextBox podajNickTextBox;
        private System.Windows.Forms.Button podajNickButton;
    }
}

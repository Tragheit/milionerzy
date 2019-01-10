namespace milionerzy
{
    partial class Milionerzy
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuGlowne1 = new milionerzy.MenuGlowne();
            this.menuGlowne2 = new milionerzy.MenuGlowne();
            this.SuspendLayout();
            // 
            // menuGlowne1
            // 
            this.menuGlowne1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuGlowne1.Location = new System.Drawing.Point(0, 0);
            this.menuGlowne1.Name = "menuGlowne1";
            this.menuGlowne1.Size = new System.Drawing.Size(761, 436);
            this.menuGlowne1.TabIndex = 0;
            // 
            // menuGlowne2
            // 
            this.menuGlowne2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuGlowne2.Location = new System.Drawing.Point(0, 0);
            this.menuGlowne2.Name = "menuGlowne2";
            this.menuGlowne2.Size = new System.Drawing.Size(761, 436);
            this.menuGlowne2.TabIndex = 0;
            // 
            // Milionerzy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 436);
            this.Controls.Add(this.menuGlowne2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Milionerzy";
            this.Text = "Milionerzy";
            this.ResumeLayout(false);

        }

        #endregion

        private MenuGlowne menuGlowne1;
        private NowaGra nowaGra1;
        private MenuGlowne menuGlowne2;
    }
}


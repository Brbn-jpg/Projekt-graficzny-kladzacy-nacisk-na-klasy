namespace ProjektNr3_Kuźnicki61961
{
    partial class KokpitProjektuNr3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProjektIndywidualnyNr3 = new System.Windows.Forms.Button();
            this.btnLaboratoriumNr3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProjektIndywidualnyNr3
            // 
            this.btnProjektIndywidualnyNr3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProjektIndywidualnyNr3.Location = new System.Drawing.Point(506, 193);
            this.btnProjektIndywidualnyNr3.Name = "btnProjektIndywidualnyNr3";
            this.btnProjektIndywidualnyNr3.Size = new System.Drawing.Size(147, 76);
            this.btnProjektIndywidualnyNr3.TabIndex = 0;
            this.btnProjektIndywidualnyNr3.Text = "Projekt Indywidualny Nr3 (Wielościany)";
            this.btnProjektIndywidualnyNr3.UseVisualStyleBackColor = true;
            this.btnProjektIndywidualnyNr3.Click += new System.EventHandler(this.btnProjektIndywidualnyNr3_Click);
            // 
            // btnLaboratoriumNr3
            // 
            this.btnLaboratoriumNr3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLaboratoriumNr3.Location = new System.Drawing.Point(172, 193);
            this.btnLaboratoriumNr3.Name = "btnLaboratoriumNr3";
            this.btnLaboratoriumNr3.Size = new System.Drawing.Size(147, 76);
            this.btnLaboratoriumNr3.TabIndex = 1;
            this.btnLaboratoriumNr3.Text = "Laboratorium Nr 3 (Bryły obrotowe)";
            this.btnLaboratoriumNr3.UseVisualStyleBackColor = true;
            this.btnLaboratoriumNr3.Click += new System.EventHandler(this.btnLaboratoriumNr3_Click);
            // 
            // KokpitProjektuNr3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLaboratoriumNr3);
            this.Controls.Add(this.btnProjektIndywidualnyNr3);
            this.Name = "KokpitProjektuNr3";
            this.Text = "Kokpit Projektu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KokpitProjektuNr3_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProjektIndywidualnyNr3;
        private System.Windows.Forms.Button btnLaboratoriumNr3;
    }
}


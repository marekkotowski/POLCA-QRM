
namespace ZAPR_POLCA.Kontrolki
{
    partial class StanowiskoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StanowiskoView));
            this.pKartyOczekujace = new System.Windows.Forms.FlowLayoutPanel();
            this.pRealizowana = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnWykonano = new System.Windows.Forms.PictureBox();
            this.btnRozpocznij = new System.Windows.Forms.PictureBox();
            this.stanowiskoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kartaPolcaModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operacjaModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnWykonano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRozpocznij)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanowiskoModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartaPolcaModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacjaModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pKartyOczekujace
            // 
            this.pKartyOczekujace.Location = new System.Drawing.Point(6, 31);
            this.pKartyOczekujace.Name = "pKartyOczekujace";
            this.pKartyOczekujace.Size = new System.Drawing.Size(200, 195);
            this.pKartyOczekujace.TabIndex = 6;
            this.pKartyOczekujace.Click += new System.EventHandler(this.pKartyOczekujace_Click);
            this.pKartyOczekujace.Paint += new System.Windows.Forms.PaintEventHandler(this.pKartyOczekujace_Paint);
            // 
            // pRealizowana
            // 
            this.pRealizowana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pRealizowana.Location = new System.Drawing.Point(232, 20);
            this.pRealizowana.Name = "pRealizowana";
            this.pRealizowana.Size = new System.Drawing.Size(221, 45);
            this.pRealizowana.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Operacja w trakcie realizacji:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Karty oczekujące:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnWykonano
            // 
            this.btnWykonano.Image = ((System.Drawing.Image)(resources.GetObject("btnWykonano.Image")));
            this.btnWykonano.Location = new System.Drawing.Point(459, 20);
            this.btnWykonano.Name = "btnWykonano";
            this.btnWykonano.Size = new System.Drawing.Size(48, 45);
            this.btnWykonano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnWykonano.TabIndex = 10;
            this.btnWykonano.TabStop = false;
            this.btnWykonano.Click += new System.EventHandler(this.btnWykonano_Click);
            // 
            // btnRozpocznij
            // 
            this.btnRozpocznij.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnRozpocznij.Image = global::QRM_POLCA.Properties.Resources.przenies;
            this.btnRozpocznij.Location = new System.Drawing.Point(147, 0);
            this.btnRozpocznij.Name = "btnRozpocznij";
            this.btnRozpocznij.Size = new System.Drawing.Size(59, 25);
            this.btnRozpocznij.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnRozpocznij.TabIndex = 11;
            this.btnRozpocznij.TabStop = false;
            this.btnRozpocznij.Click += new System.EventHandler(this.button1_Click);
            // 
            // stanowiskoModelBindingSource
            // 
            this.stanowiskoModelBindingSource.DataSource = typeof(ZAPR_POLCA.MODELE.StanowiskoModel);
            // 
            // kartaPolcaModelBindingSource
            // 
            this.kartaPolcaModelBindingSource.DataSource = typeof(ZAPR_POLCA.MODELE.KartaPolcaModel);
            // 
            // operacjaModelBindingSource
            // 
            this.operacjaModelBindingSource.DataSource = typeof(ZAPR_POLCA.MODELE.OperacjaModel);
            // 
            // StanowiskoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRozpocznij);
            this.Controls.Add(this.btnWykonano);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pRealizowana);
            this.Controls.Add(this.pKartyOczekujace);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StanowiskoView";
            this.Size = new System.Drawing.Size(515, 232);
            this.Load += new System.EventHandler(this.StanowiskoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnWykonano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRozpocznij)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanowiskoModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartaPolcaModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacjaModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource stanowiskoModelBindingSource;
        private System.Windows.Forms.BindingSource kartaPolcaModelBindingSource;
        private System.Windows.Forms.BindingSource operacjaModelBindingSource;
        private System.Windows.Forms.FlowLayoutPanel pKartyOczekujace;
        private System.Windows.Forms.Panel pRealizowana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnWykonano;
        private System.Windows.Forms.PictureBox btnRozpocznij;
    }
}


namespace ZAPR_POLCA.Kontrolki
{
    partial class KartaPOLCAView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lDoWykonania = new System.Windows.Forms.Label();
            this.lNrOperacji = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lNexStanowisko = new System.Windows.Forms.Label();
            this.bindingKartaPOLCA = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingKartaPOLCA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingKartaPOLCA, "NumerZlecenia", true));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingKartaPOLCA, "TerminWykonania", true));
            this.label2.Location = new System.Drawing.Point(89, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lDoWykonania
            // 
            this.lDoWykonania.AutoSize = true;
            this.lDoWykonania.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDoWykonania.Location = new System.Drawing.Point(2, 13);
            this.lDoWykonania.Name = "lDoWykonania";
            this.lDoWykonania.Size = new System.Drawing.Size(57, 21);
            this.lDoWykonania.TabIndex = 0;
            this.lDoWykonania.Text = "label3";
            // 
            // lNrOperacji
            // 
            this.lNrOperacji.AutoSize = true;
            this.lNrOperacji.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingKartaPOLCA, "NumerPierwszejOperacji", true));
            this.lNrOperacji.Location = new System.Drawing.Point(89, 0);
            this.lNrOperacji.Name = "lNrOperacji";
            this.lNrOperacji.Size = new System.Drawing.Size(22, 13);
            this.lNrOperacji.TabIndex = 3;
            this.lNrOperacji.Text = "NR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingKartaPOLCA, "OczekujaceNaNastepnymStanowisku", true));
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(182, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "IL";
            // 
            // lNexStanowisko
            // 
            this.lNexStanowisko.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingKartaPOLCA, "StanowiskoDrugiejOperacji", true));
            this.lNexStanowisko.Location = new System.Drawing.Point(131, 0);
            this.lNexStanowisko.Name = "lNexStanowisko";
            this.lNexStanowisko.Size = new System.Drawing.Size(45, 15);
            this.lNexStanowisko.TabIndex = 5;
            this.lNexStanowisko.Text = "000-000";
            // 
            // bindingKartaPOLCA
            // 
            this.bindingKartaPOLCA.DataSource = typeof(ZAPR_POLCA.MODELE.KartaPolcaModel);
            // 
            // KartaPOLCAView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lNexStanowisko);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lNrOperacji);
            this.Controls.Add(this.lDoWykonania);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "KartaPOLCAView";
            this.Size = new System.Drawing.Size(199, 30);
            this.Load += new System.EventHandler(this.KartaPOLCAView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingKartaPOLCA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingKartaPOLCA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lDoWykonania;
        private System.Windows.Forms.Label lNrOperacji;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lNexStanowisko;
    }
}

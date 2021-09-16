
namespace ZAPR_POLCA.OKNA
{
    partial class ZlecenieForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bindingZlecenie = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dPlanDataRozpoczecia = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dPlanDataZakonczenia = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.nIlosc = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lNrRysunku = new System.Windows.Forms.Label();
            this.wyrobModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lNazwaWyrobu = new System.Windows.Forms.Label();
            this.btnAnuluj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingZlecenie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIlosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyrobModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numer Zlecenia:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingZlecenie, "NumerZlecenia", true));
            this.textBox1.Location = new System.Drawing.Point(140, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(392, 25);
            this.textBox1.TabIndex = 1;
            // 
            // bindingZlecenie
            // 
            this.bindingZlecenie.DataSource = typeof(ZAPR_POLCA.MODELE.ZlecenieModel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Planowana data rozp:";
            // 
            // dPlanDataRozpoczecia
            // 
            this.dPlanDataRozpoczecia.CustomFormat = "yyyy-MM-dd";
            this.dPlanDataRozpoczecia.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingZlecenie, "PlanowanaDataRozpoczecia", true));
            this.dPlanDataRozpoczecia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dPlanDataRozpoczecia.Location = new System.Drawing.Point(168, 92);
            this.dPlanDataRozpoczecia.Name = "dPlanDataRozpoczecia";
            this.dPlanDataRozpoczecia.Size = new System.Drawing.Size(92, 25);
            this.dPlanDataRozpoczecia.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Planowana data zak.:";
            // 
            // dPlanDataZakonczenia
            // 
            this.dPlanDataZakonczenia.CustomFormat = "yyyy-MM-dd";
            this.dPlanDataZakonczenia.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingZlecenie, "PlanowanaDataZakonczenia", true));
            this.dPlanDataZakonczenia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dPlanDataZakonczenia.Location = new System.Drawing.Point(168, 131);
            this.dPlanDataZakonczenia.Name = "dPlanDataZakonczenia";
            this.dPlanDataZakonczenia.Size = new System.Drawing.Size(92, 25);
            this.dPlanDataZakonczenia.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ilość:";
            // 
            // nIlosc
            // 
            this.nIlosc.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingZlecenie, "IloscZamowiona", true));
            this.nIlosc.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nIlosc.Location = new System.Drawing.Point(423, 129);
            this.nIlosc.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nIlosc.Name = "nIlosc";
            this.nIlosc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nIlosc.Size = new System.Drawing.Size(107, 25);
            this.nIlosc.TabIndex = 7;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(20, 198);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(224, 34);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "Utwórz";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Numer rysunku:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nazwa wyrobu:";
            // 
            // lNrRysunku
            // 
            this.lNrRysunku.AutoSize = true;
            this.lNrRysunku.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wyrobModelBindingSource, "NumerRysunku", true));
            this.lNrRysunku.Location = new System.Drawing.Point(137, 46);
            this.lNrRysunku.Name = "lNrRysunku";
            this.lNrRysunku.Size = new System.Drawing.Size(43, 17);
            this.lNrRysunku.TabIndex = 11;
            this.lNrRysunku.Text = "label7";
            // 
            // wyrobModelBindingSource
            // 
            this.wyrobModelBindingSource.DataSource = typeof(ZAPR_POLCA.MODELE.WyrobModel);
            // 
            // lNazwaWyrobu
            // 
            this.lNazwaWyrobu.AutoSize = true;
            this.lNazwaWyrobu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wyrobModelBindingSource, "NazwaWyrobu", true));
            this.lNazwaWyrobu.Location = new System.Drawing.Point(137, 72);
            this.lNazwaWyrobu.Name = "lNazwaWyrobu";
            this.lNazwaWyrobu.Size = new System.Drawing.Size(43, 17);
            this.lNazwaWyrobu.TabIndex = 12;
            this.lNazwaWyrobu.Text = "label7";
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnuluj.Location = new System.Drawing.Point(306, 198);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(224, 34);
            this.btnAnuluj.TabIndex = 13;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // ZlecenieForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnuluj;
            this.ClientSize = new System.Drawing.Size(544, 244);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.lNazwaWyrobu);
            this.Controls.Add(this.lNrRysunku);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.nIlosc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dPlanDataZakonczenia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dPlanDataRozpoczecia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ZlecenieForm";
            this.Text = "Zlecenie";
            this.Load += new System.EventHandler(this.Zlecenie_Load);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.ZlecenieForm_Validating);
            ((System.ComponentModel.ISupportInitialize)(this.bindingZlecenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIlosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyrobModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dPlanDataRozpoczecia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dPlanDataZakonczenia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nIlosc;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lNrRysunku;
        private System.Windows.Forms.Label lNazwaWyrobu;
        private System.Windows.Forms.BindingSource wyrobModelBindingSource;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.BindingSource bindingZlecenie;
    }
}
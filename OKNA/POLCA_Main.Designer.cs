
namespace ZAPR_POLCA.OKNA
{
    partial class POLCA_Main
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
            this.btnZamknij = new System.Windows.Forms.Button();
            this.listWyroby = new System.Windows.Forms.ListBox();
            this.wyrobModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnUtworzZlecenie = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.zlecenieModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingZlecenie = new System.Windows.Forms.BindingSource(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operacjaModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kartaPolcaModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cListaStanowisk1 = new System.Windows.Forms.ComboBox();
            this.stanowiskoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.vStanowisko1 = new ZAPR_POLCA.Kontrolki.StanowiskoView();
            this.pListaZlecen = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.cListaStanowisk2 = new System.Windows.Forms.ComboBox();
            this.vStanowisko2 = new ZAPR_POLCA.Kontrolki.StanowiskoView();
            ((System.ComponentModel.ISupportInitialize)(this.wyrobModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zlecenieModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingZlecenie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacjaModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartaPolcaModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanowiskoModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(878, 3);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(75, 23);
            this.btnZamknij.TabIndex = 3;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // listWyroby
            // 
            this.listWyroby.DataSource = this.wyrobModelBindingSource;
            this.listWyroby.DisplayMember = "NumerRysunku";
            this.listWyroby.FormattingEnabled = true;
            this.listWyroby.Location = new System.Drawing.Point(12, 28);
            this.listWyroby.Name = "listWyroby";
            this.listWyroby.Size = new System.Drawing.Size(239, 82);
            this.listWyroby.TabIndex = 4;
            this.listWyroby.ValueMember = "NumerRysunku";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wyroby";
            // 
            // btnUtworzZlecenie
            // 
            this.btnUtworzZlecenie.Location = new System.Drawing.Point(12, 116);
            this.btnUtworzZlecenie.Name = "btnUtworzZlecenie";
            this.btnUtworzZlecenie.Size = new System.Drawing.Size(239, 23);
            this.btnUtworzZlecenie.TabIndex = 6;
            this.btnUtworzZlecenie.Text = "Nowe Zlecenie";
            this.btnUtworzZlecenie.UseVisualStyleBackColor = true;
            this.btnUtworzZlecenie.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Zlecenia";
            // 
            // zlecenieModelBindingSource
            // 
            this.zlecenieModelBindingSource.DataSource = typeof(ZAPR_POLCA.MODELE.ZlecenieModel);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(91, 145);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(160, 21);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Uruchom zlecenie";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn1.HeaderText = "Status";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // operacjaModelBindingSource
            // 
            this.operacjaModelBindingSource.DataSource = typeof(ZAPR_POLCA.MODELE.OperacjaModel);
            // 
            // kartaPolcaModelBindingSource
            // 
            this.kartaPolcaModelBindingSource.DataSource = typeof(ZAPR_POLCA.MODELE.KartaPolcaModel);
            // 
            // cListaStanowisk1
            // 
            this.cListaStanowisk1.FormattingEnabled = true;
            this.cListaStanowisk1.Location = new System.Drawing.Point(356, 25);
            this.cListaStanowisk1.Name = "cListaStanowisk1";
            this.cListaStanowisk1.Size = new System.Drawing.Size(271, 21);
            this.cListaStanowisk1.TabIndex = 13;
            this.cListaStanowisk1.SelectedIndexChanged += new System.EventHandler(this.cListaStanowisk_SelectedIndexChanged);
            // 
            // stanowiskoModelBindingSource
            // 
            this.stanowiskoModelBindingSource.DataSource = typeof(ZAPR_POLCA.MODELE.StanowiskoModel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Stanowisko:";
            // 
            // vStanowisko1
            // 
            this.vStanowisko1.BackColor = System.Drawing.Color.White;
            this.vStanowisko1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vStanowisko1.Location = new System.Drawing.Point(283, 53);
            this.vStanowisko1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vStanowisko1.Name = "vStanowisko1";
            this.vStanowisko1.Size = new System.Drawing.Size(518, 214);
            this.vStanowisko1.TabIndex = 15;
            // 
            // pListaZlecen
            // 
            this.pListaZlecen.Location = new System.Drawing.Point(11, 169);
            this.pListaZlecen.Name = "pListaZlecen";
            this.pListaZlecen.Size = new System.Drawing.Size(240, 511);
            this.pListaZlecen.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Stanowisko:";
            // 
            // cListaStanowisk2
            // 
            this.cListaStanowisk2.FormattingEnabled = true;
            this.cListaStanowisk2.Location = new System.Drawing.Point(356, 291);
            this.cListaStanowisk2.Name = "cListaStanowisk2";
            this.cListaStanowisk2.Size = new System.Drawing.Size(271, 21);
            this.cListaStanowisk2.TabIndex = 17;
            this.cListaStanowisk2.SelectedIndexChanged += new System.EventHandler(this.cListaStanowisk2_SelectedIndexChanged);
            // 
            // vStanowisko2
            // 
            this.vStanowisko2.BackColor = System.Drawing.Color.White;
            this.vStanowisko2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vStanowisko2.Location = new System.Drawing.Point(283, 319);
            this.vStanowisko2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vStanowisko2.Name = "vStanowisko2";
            this.vStanowisko2.Size = new System.Drawing.Size(518, 214);
            this.vStanowisko2.TabIndex = 19;
            // 
            // POLCA_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(999, 709);
            this.Controls.Add(this.vStanowisko2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cListaStanowisk2);
            this.Controls.Add(this.pListaZlecen);
            this.Controls.Add(this.vStanowisko1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cListaStanowisk1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUtworzZlecenie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listWyroby);
            this.Controls.Add(this.btnZamknij);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "POLCA_Main";
            this.Text = "Symulacja działania QRM-POLCA";
            this.Load += new System.EventHandler(this.POLCA_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wyrobModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zlecenieModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingZlecenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacjaModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartaPolcaModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanowiskoModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.ListBox listWyroby;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUtworzZlecenie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource wyrobModelBindingSource;
        private System.Windows.Forms.BindingSource bindingZlecenie;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerZleceniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planowanaDataRozpoczeciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planowanaDataZakonczeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscZamowionaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrZleceniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrOperacjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn czasOperacjiMinutyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource operacjaModelBindingSource;
        private System.Windows.Forms.BindingSource zlecenieModelBindingSource;
        private System.Windows.Forms.BindingSource kartaPolcaModelBindingSource;
        private System.Windows.Forms.ComboBox cListaStanowisk1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource stanowiskoModelBindingSource;
        private Kontrolki.StanowiskoView vStanowisko1;
        private System.Windows.Forms.FlowLayoutPanel pListaZlecen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cListaStanowisk2;
        private Kontrolki.StanowiskoView vStanowisko2;
    }
}
namespace combo_box_ex1
{
    partial class countCentro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.cboNorte = new System.Windows.Forms.ComboBox();
            this.cboNordeste = new System.Windows.Forms.ComboBox();
            this.cboCentro = new System.Windows.Forms.ComboBox();
            this.cboSudeste = new System.Windows.Forms.ComboBox();
            this.cboSul = new System.Windows.Forms.ComboBox();
            this.btnRemoverAdd = new System.Windows.Forms.Button();
            this.btnRemoverNorte = new System.Windows.Forms.Button();
            this.btnRemoverNordeste = new System.Windows.Forms.Button();
            this.btnRemoverCentro = new System.Windows.Forms.Button();
            this.btnRemoverSudeste = new System.Windows.Forms.Button();
            this.btnRemoverSul = new System.Windows.Forms.Button();
            this.countEstados = new System.Windows.Forms.Label();
            this.countNorte = new System.Windows.Forms.Label();
            this.countNordeste = new System.Windows.Forms.Label();
            this.countCentroOeste = new System.Windows.Forms.Label();
            this.countSudeste = new System.Windows.Forms.Label();
            this.countSul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Todos os Estados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Região Norte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Região Nordeste";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Região Centro Oeste";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Região Sudeste";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Região Sul";
            // 
            // cboEstados
            // 
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins",
            "Distrito Federal"});
            this.cboEstados.Location = new System.Drawing.Point(211, 35);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(376, 21);
            this.cboEstados.TabIndex = 6;
            this.cboEstados.SelectedIndexChanged += new System.EventHandler(this.cboEstados_SelectedIndexChanged);
            // 
            // cboNorte
            // 
            this.cboNorte.FormattingEnabled = true;
            this.cboNorte.Items.AddRange(new object[] {
            "..."});
            this.cboNorte.Location = new System.Drawing.Point(211, 108);
            this.cboNorte.Name = "cboNorte";
            this.cboNorte.Size = new System.Drawing.Size(376, 21);
            this.cboNorte.TabIndex = 7;
            // 
            // cboNordeste
            // 
            this.cboNordeste.FormattingEnabled = true;
            this.cboNordeste.Location = new System.Drawing.Point(211, 191);
            this.cboNordeste.Name = "cboNordeste";
            this.cboNordeste.Size = new System.Drawing.Size(376, 21);
            this.cboNordeste.TabIndex = 8;
            // 
            // cboCentro
            // 
            this.cboCentro.FormattingEnabled = true;
            this.cboCentro.Location = new System.Drawing.Point(212, 269);
            this.cboCentro.Name = "cboCentro";
            this.cboCentro.Size = new System.Drawing.Size(375, 21);
            this.cboCentro.TabIndex = 9;
            // 
            // cboSudeste
            // 
            this.cboSudeste.FormattingEnabled = true;
            this.cboSudeste.Location = new System.Drawing.Point(211, 360);
            this.cboSudeste.Name = "cboSudeste";
            this.cboSudeste.Size = new System.Drawing.Size(374, 21);
            this.cboSudeste.TabIndex = 10;
            // 
            // cboSul
            // 
            this.cboSul.FormattingEnabled = true;
            this.cboSul.Location = new System.Drawing.Point(212, 454);
            this.cboSul.Name = "cboSul";
            this.cboSul.Size = new System.Drawing.Size(375, 21);
            this.cboSul.TabIndex = 11;
            // 
            // btnRemoverAdd
            // 
            this.btnRemoverAdd.Location = new System.Drawing.Point(613, 19);
            this.btnRemoverAdd.Name = "btnRemoverAdd";
            this.btnRemoverAdd.Size = new System.Drawing.Size(48, 37);
            this.btnRemoverAdd.TabIndex = 12;
            this.btnRemoverAdd.Text = "-";
            this.btnRemoverAdd.UseVisualStyleBackColor = true;
            this.btnRemoverAdd.Click += new System.EventHandler(this.btnRemoverAdd_Click);
            // 
            // btnRemoverNorte
            // 
            this.btnRemoverNorte.Location = new System.Drawing.Point(613, 92);
            this.btnRemoverNorte.Name = "btnRemoverNorte";
            this.btnRemoverNorte.Size = new System.Drawing.Size(48, 37);
            this.btnRemoverNorte.TabIndex = 13;
            this.btnRemoverNorte.Text = "-";
            this.btnRemoverNorte.UseVisualStyleBackColor = true;
            this.btnRemoverNorte.Click += new System.EventHandler(this.btnRemoverNorte_Click);
            // 
            // btnRemoverNordeste
            // 
            this.btnRemoverNordeste.Location = new System.Drawing.Point(613, 175);
            this.btnRemoverNordeste.Name = "btnRemoverNordeste";
            this.btnRemoverNordeste.Size = new System.Drawing.Size(48, 37);
            this.btnRemoverNordeste.TabIndex = 14;
            this.btnRemoverNordeste.Text = "-";
            this.btnRemoverNordeste.UseVisualStyleBackColor = true;
            this.btnRemoverNordeste.Click += new System.EventHandler(this.btnRemoverNordeste_Click);
            // 
            // btnRemoverCentro
            // 
            this.btnRemoverCentro.Location = new System.Drawing.Point(613, 253);
            this.btnRemoverCentro.Name = "btnRemoverCentro";
            this.btnRemoverCentro.Size = new System.Drawing.Size(48, 37);
            this.btnRemoverCentro.TabIndex = 15;
            this.btnRemoverCentro.Text = "-";
            this.btnRemoverCentro.UseVisualStyleBackColor = true;
            this.btnRemoverCentro.Click += new System.EventHandler(this.btnRemoverCentro_Click);
            // 
            // btnRemoverSudeste
            // 
            this.btnRemoverSudeste.Location = new System.Drawing.Point(613, 344);
            this.btnRemoverSudeste.Name = "btnRemoverSudeste";
            this.btnRemoverSudeste.Size = new System.Drawing.Size(48, 37);
            this.btnRemoverSudeste.TabIndex = 16;
            this.btnRemoverSudeste.Text = "-";
            this.btnRemoverSudeste.UseVisualStyleBackColor = true;
            this.btnRemoverSudeste.Click += new System.EventHandler(this.btnRemoverSudeste_Click);
            // 
            // btnRemoverSul
            // 
            this.btnRemoverSul.Location = new System.Drawing.Point(613, 445);
            this.btnRemoverSul.Name = "btnRemoverSul";
            this.btnRemoverSul.Size = new System.Drawing.Size(48, 37);
            this.btnRemoverSul.TabIndex = 17;
            this.btnRemoverSul.Text = "-";
            this.btnRemoverSul.UseVisualStyleBackColor = true;
            this.btnRemoverSul.Click += new System.EventHandler(this.btnRemoverSul_Click);
            // 
            // countEstados
            // 
            this.countEstados.AutoSize = true;
            this.countEstados.Location = new System.Drawing.Point(706, 35);
            this.countEstados.Name = "countEstados";
            this.countEstados.Size = new System.Drawing.Size(35, 13);
            this.countEstados.TabIndex = 18;
            this.countEstados.Text = "label7";
            // 
            // countNorte
            // 
            this.countNorte.AutoSize = true;
            this.countNorte.Location = new System.Drawing.Point(706, 104);
            this.countNorte.Name = "countNorte";
            this.countNorte.Size = new System.Drawing.Size(35, 13);
            this.countNorte.TabIndex = 19;
            this.countNorte.Text = "label8";
            // 
            // countNordeste
            // 
            this.countNordeste.AutoSize = true;
            this.countNordeste.Location = new System.Drawing.Point(706, 187);
            this.countNordeste.Name = "countNordeste";
            this.countNordeste.Size = new System.Drawing.Size(35, 13);
            this.countNordeste.TabIndex = 20;
            this.countNordeste.Text = "label9";
            // 
            // countCentroOeste
            // 
            this.countCentroOeste.AutoSize = true;
            this.countCentroOeste.Location = new System.Drawing.Point(700, 265);
            this.countCentroOeste.Name = "countCentroOeste";
            this.countCentroOeste.Size = new System.Drawing.Size(41, 13);
            this.countCentroOeste.TabIndex = 21;
            this.countCentroOeste.Text = "label10";
            // 
            // countSudeste
            // 
            this.countSudeste.AutoSize = true;
            this.countSudeste.Location = new System.Drawing.Point(700, 356);
            this.countSudeste.Name = "countSudeste";
            this.countSudeste.Size = new System.Drawing.Size(41, 13);
            this.countSudeste.TabIndex = 22;
            this.countSudeste.Text = "label11";
            // 
            // countSul
            // 
            this.countSul.AutoSize = true;
            this.countSul.Location = new System.Drawing.Point(700, 457);
            this.countSul.Name = "countSul";
            this.countSul.Size = new System.Drawing.Size(41, 13);
            this.countSul.TabIndex = 23;
            this.countSul.Text = "label12";
            // 
            // countCentro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 604);
            this.Controls.Add(this.countSul);
            this.Controls.Add(this.countSudeste);
            this.Controls.Add(this.countCentroOeste);
            this.Controls.Add(this.countNordeste);
            this.Controls.Add(this.countNorte);
            this.Controls.Add(this.countEstados);
            this.Controls.Add(this.btnRemoverSul);
            this.Controls.Add(this.btnRemoverSudeste);
            this.Controls.Add(this.btnRemoverCentro);
            this.Controls.Add(this.btnRemoverNordeste);
            this.Controls.Add(this.btnRemoverNorte);
            this.Controls.Add(this.btnRemoverAdd);
            this.Controls.Add(this.cboSul);
            this.Controls.Add(this.cboSudeste);
            this.Controls.Add(this.cboCentro);
            this.Controls.Add(this.cboNordeste);
            this.Controls.Add(this.cboNorte);
            this.Controls.Add(this.cboEstados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "countCentro";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.ComboBox cboNorte;
        private System.Windows.Forms.ComboBox cboNordeste;
        private System.Windows.Forms.ComboBox cboCentro;
        private System.Windows.Forms.ComboBox cboSudeste;
        private System.Windows.Forms.ComboBox cboSul;
        private System.Windows.Forms.Button btnRemoverAdd;
        private System.Windows.Forms.Button btnRemoverNorte;
        private System.Windows.Forms.Button btnRemoverNordeste;
        private System.Windows.Forms.Button btnRemoverCentro;
        private System.Windows.Forms.Button btnRemoverSudeste;
        private System.Windows.Forms.Button btnRemoverSul;
        private System.Windows.Forms.Label countEstados;
        private System.Windows.Forms.Label countNorte;
        private System.Windows.Forms.Label countNordeste;
        private System.Windows.Forms.Label countCentroOeste;
        private System.Windows.Forms.Label countSudeste;
        private System.Windows.Forms.Label countSul;
    }
}


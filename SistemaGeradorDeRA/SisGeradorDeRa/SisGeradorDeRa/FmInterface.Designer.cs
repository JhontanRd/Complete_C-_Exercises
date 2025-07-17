namespace SisGeradorDeRa
{
    partial class FmGerador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmGerador));
            this.LblQuantNum = new System.Windows.Forms.Label();
            this.BtnGerarRa = new System.Windows.Forms.Button();
            this.LblRa = new System.Windows.Forms.Label();
            this.TxtRaGerado = new System.Windows.Forms.TextBox();
            this.LblPergunta = new System.Windows.Forms.Label();
            this.RdbSim = new System.Windows.Forms.RadioButton();
            this.RdbNao = new System.Windows.Forms.RadioButton();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblMarca = new System.Windows.Forms.Label();
            this.NumQuantLetras = new System.Windows.Forms.NumericUpDown();
            this.NumQuantNumeros = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantLetras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // LblQuantNum
            // 
            this.LblQuantNum.AutoSize = true;
            this.LblQuantNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.LblQuantNum.Location = new System.Drawing.Point(12, 72);
            this.LblQuantNum.Name = "LblQuantNum";
            this.LblQuantNum.Size = new System.Drawing.Size(187, 17);
            this.LblQuantNum.TabIndex = 0;
            this.LblQuantNum.Text = "Quantidade de números:";
            // 
            // BtnGerarRa
            // 
            this.BtnGerarRa.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BtnGerarRa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGerarRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.BtnGerarRa.Location = new System.Drawing.Point(193, 161);
            this.BtnGerarRa.Name = "BtnGerarRa";
            this.BtnGerarRa.Size = new System.Drawing.Size(90, 30);
            this.BtnGerarRa.TabIndex = 4;
            this.BtnGerarRa.Text = "Gerar RA";
            this.BtnGerarRa.UseVisualStyleBackColor = false;
            this.BtnGerarRa.Click += new System.EventHandler(this.BtnGerarRa_Click);
            this.BtnGerarRa.MouseEnter += new System.EventHandler(this.BtnGerarRa_MouseEnter);
            this.BtnGerarRa.MouseLeave += new System.EventHandler(this.BtnGerarRa_MouseLeave);
            // 
            // LblRa
            // 
            this.LblRa.AutoSize = true;
            this.LblRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.LblRa.Location = new System.Drawing.Point(12, 210);
            this.LblRa.Name = "LblRa";
            this.LblRa.Size = new System.Drawing.Size(88, 17);
            this.LblRa.TabIndex = 5;
            this.LblRa.Text = "RA Gerado";
            // 
            // TxtRaGerado
            // 
            this.TxtRaGerado.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.TxtRaGerado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.TxtRaGerado.Location = new System.Drawing.Point(106, 207);
            this.TxtRaGerado.MaxLength = 15;
            this.TxtRaGerado.Name = "TxtRaGerado";
            this.TxtRaGerado.ReadOnly = true;
            this.TxtRaGerado.Size = new System.Drawing.Size(350, 38);
            this.TxtRaGerado.TabIndex = 6;
            this.TxtRaGerado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblPergunta
            // 
            this.LblPergunta.AutoSize = true;
            this.LblPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.LblPergunta.Location = new System.Drawing.Point(12, 98);
            this.LblPergunta.Name = "LblPergunta";
            this.LblPergunta.Size = new System.Drawing.Size(107, 17);
            this.LblPergunta.TabIndex = 7;
            this.LblPergunta.Text = "Incluir letras?";
            // 
            // RdbSim
            // 
            this.RdbSim.AutoSize = true;
            this.RdbSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.RdbSim.Location = new System.Drawing.Point(125, 98);
            this.RdbSim.Name = "RdbSim";
            this.RdbSim.Size = new System.Drawing.Size(52, 21);
            this.RdbSim.TabIndex = 8;
            this.RdbSim.Text = "Sim";
            this.RdbSim.UseVisualStyleBackColor = true;
            // 
            // RdbNao
            // 
            this.RdbNao.AutoSize = true;
            this.RdbNao.Checked = true;
            this.RdbNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.RdbNao.Location = new System.Drawing.Point(178, 98);
            this.RdbNao.Name = "RdbNao";
            this.RdbNao.Size = new System.Drawing.Size(55, 21);
            this.RdbNao.TabIndex = 9;
            this.RdbNao.TabStop = true;
            this.RdbNao.Text = "Não";
            this.RdbNao.UseVisualStyleBackColor = true;
            this.RdbNao.CheckedChanged += new System.EventHandler(this.RdbNao_CheckedChanged);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.LblTitulo.Location = new System.Drawing.Point(153, 19);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(155, 25);
            this.LblTitulo.TabIndex = 10;
            this.LblTitulo.Text = "Gerador de RA";
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.LblMarca.Location = new System.Drawing.Point(371, 259);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(81, 13);
            this.LblMarca.TabIndex = 11;
            this.LblMarca.Text = "By: Jhon.DevBr";
            // 
            // NumQuantLetras
            // 
            this.NumQuantLetras.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.NumQuantLetras.Enabled = false;
            this.NumQuantLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.NumQuantLetras.Location = new System.Drawing.Point(239, 98);
            this.NumQuantLetras.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumQuantLetras.Name = "NumQuantLetras";
            this.NumQuantLetras.ReadOnly = true;
            this.NumQuantLetras.Size = new System.Drawing.Size(50, 23);
            this.NumQuantLetras.TabIndex = 14;
            // 
            // NumQuantNumeros
            // 
            this.NumQuantNumeros.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.NumQuantNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.NumQuantNumeros.Location = new System.Drawing.Point(205, 72);
            this.NumQuantNumeros.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumQuantNumeros.Name = "NumQuantNumeros";
            this.NumQuantNumeros.ReadOnly = true;
            this.NumQuantNumeros.Size = new System.Drawing.Size(50, 23);
            this.NumQuantNumeros.TabIndex = 15;
            // 
            // FmGerador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.Controls.Add(this.NumQuantNumeros);
            this.Controls.Add(this.NumQuantLetras);
            this.Controls.Add(this.LblMarca);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.RdbNao);
            this.Controls.Add(this.RdbSim);
            this.Controls.Add(this.LblPergunta);
            this.Controls.Add(this.TxtRaGerado);
            this.Controls.Add(this.LblRa);
            this.Controls.Add(this.BtnGerarRa);
            this.Controls.Add(this.LblQuantNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 320);
            this.MinimumSize = new System.Drawing.Size(480, 320);
            this.Name = "FmGerador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de RA";
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantLetras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantNumeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblQuantNum;
        private System.Windows.Forms.Button BtnGerarRa;
        private System.Windows.Forms.Label LblRa;
        private System.Windows.Forms.TextBox TxtRaGerado;
        private System.Windows.Forms.Label LblPergunta;
        private System.Windows.Forms.RadioButton RdbSim;
        private System.Windows.Forms.RadioButton RdbNao;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.NumericUpDown NumQuantLetras;
        private System.Windows.Forms.NumericUpDown NumQuantNumeros;
    }
}


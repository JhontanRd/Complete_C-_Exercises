namespace ValidadorDeCpf
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblAtencao = new System.Windows.Forms.Label();
            this.LblMensagem01 = new System.Windows.Forms.Label();
            this.LblMensagem02 = new System.Windows.Forms.Label();
            this.LblCpf = new System.Windows.Forms.Label();
            this.BtnValidar = new System.Windows.Forms.Button();
            this.LblResultado = new System.Windows.Forms.Label();
            this.LblBy = new System.Windows.Forms.Label();
            this.MskCpf = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LblTitulo.Location = new System.Drawing.Point(148, 43);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(285, 31);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Autenticador de CPF";
            // 
            // LblAtencao
            // 
            this.LblAtencao.AutoSize = true;
            this.LblAtencao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblAtencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.LblAtencao.ForeColor = System.Drawing.Color.Red;
            this.LblAtencao.Location = new System.Drawing.Point(12, 99);
            this.LblAtencao.Name = "LblAtencao";
            this.LblAtencao.Size = new System.Drawing.Size(81, 17);
            this.LblAtencao.TabIndex = 1;
            this.LblAtencao.Text = "ATENÇÃO";
            // 
            // LblMensagem01
            // 
            this.LblMensagem01.AutoSize = true;
            this.LblMensagem01.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblMensagem01.Location = new System.Drawing.Point(12, 116);
            this.LblMensagem01.Name = "LblMensagem01";
            this.LblMensagem01.Size = new System.Drawing.Size(393, 17);
            this.LblMensagem01.TabIndex = 2;
            this.LblMensagem01.Text = "Esta aplicação apenas diz se o CPF inserido é válido ou não.";
            // 
            // LblMensagem02
            // 
            this.LblMensagem02.AutoSize = true;
            this.LblMensagem02.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblMensagem02.Location = new System.Drawing.Point(12, 133);
            this.LblMensagem02.Name = "LblMensagem02";
            this.LblMensagem02.Size = new System.Drawing.Size(331, 17);
            this.LblMensagem02.TabIndex = 3;
            this.LblMensagem02.Text = "Isso não significa que o CPF inserido exista de fato!";
            // 
            // LblCpf
            // 
            this.LblCpf.AutoSize = true;
            this.LblCpf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.LblCpf.Location = new System.Drawing.Point(67, 184);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.Size = new System.Drawing.Size(458, 31);
            this.LblCpf.TabIndex = 4;
            this.LblCpf.Text = "Informe um CPF para ser válidado";
            // 
            // BtnValidar
            // 
            this.BtnValidar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.BtnValidar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnValidar.Location = new System.Drawing.Point(254, 286);
            this.BtnValidar.Name = "BtnValidar";
            this.BtnValidar.Size = new System.Drawing.Size(100, 40);
            this.BtnValidar.TabIndex = 6;
            this.BtnValidar.Text = "Validar";
            this.BtnValidar.UseVisualStyleBackColor = false;
            this.BtnValidar.Click += new System.EventHandler(this.BtnValidar_Click);
            this.BtnValidar.MouseEnter += new System.EventHandler(this.BtnValidar_MouseEnter);
            this.BtnValidar.MouseLeave += new System.EventHandler(this.BtnValidar_MouseLeave);
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.LblResultado.Location = new System.Drawing.Point(224, 354);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(0, 31);
            this.LblResultado.TabIndex = 7;
            // 
            // LblBy
            // 
            this.LblBy.AutoSize = true;
            this.LblBy.Location = new System.Drawing.Point(531, 409);
            this.LblBy.Name = "LblBy";
            this.LblBy.Size = new System.Drawing.Size(61, 13);
            this.LblBy.TabIndex = 8;
            this.LblBy.Text = "By: Jr Tech";
            // 
            // MskCpf
            // 
            this.MskCpf.BackColor = System.Drawing.SystemColors.Info;
            this.MskCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.MskCpf.Location = new System.Drawing.Point(73, 236);
            this.MskCpf.Mask = "000,000,000-00";
            this.MskCpf.Name = "MskCpf";
            this.MskCpf.Size = new System.Drawing.Size(452, 30);
            this.MskCpf.TabIndex = 9;
            this.MskCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(604, 431);
            this.Controls.Add(this.MskCpf);
            this.Controls.Add(this.LblBy);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.BtnValidar);
            this.Controls.Add(this.LblCpf);
            this.Controls.Add(this.LblMensagem02);
            this.Controls.Add(this.LblMensagem01);
            this.Controls.Add(this.LblAtencao);
            this.Controls.Add(this.LblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(620, 470);
            this.MinimumSize = new System.Drawing.Size(620, 470);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autenticador de CPF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblAtencao;
        private System.Windows.Forms.Label LblMensagem01;
        private System.Windows.Forms.Label LblMensagem02;
        private System.Windows.Forms.Label LblCpf;
        private System.Windows.Forms.Button BtnValidar;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Label LblBy;
        private System.Windows.Forms.MaskedTextBox MskCpf;
    }
}


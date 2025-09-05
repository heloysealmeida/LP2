namespace Pvolume
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtRaio = new TextBox();
            txtAltura = new TextBox();
            txtVolume = new TextBox();
            lblRaio = new Label();
            lblAltura = new Label();
            lblVolume = new Label();
            btnCalcular = new Button();
            btnLimpar = new Button();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // txtRaio
            // 
            txtRaio.Font = new Font("Century Gothic", 13.8F);
            txtRaio.Location = new Point(459, 52);
            txtRaio.Name = "txtRaio";
            txtRaio.Size = new Size(172, 36);
            txtRaio.TabIndex = 1;
            txtRaio.Validated += textBox1_Validated;
            // 
            // txtAltura
            // 
            txtAltura.Font = new Font("Century Gothic", 13.8F);
            txtAltura.Location = new Point(459, 119);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(172, 36);
            txtAltura.TabIndex = 2;
            txtAltura.TextChanged += txtAltura_TextChanged;
            // 
            // txtVolume
            // 
            txtVolume.Enabled = false;
            txtVolume.Font = new Font("Century Gothic", 13.8F);
            txtVolume.Location = new Point(459, 203);
            txtVolume.Name = "txtVolume";
            txtVolume.Size = new Size(172, 36);
            txtVolume.TabIndex = 3;
            // 
            // lblRaio
            // 
            lblRaio.AutoSize = true;
            lblRaio.Font = new Font("Century Gothic", 13.8F);
            lblRaio.Location = new Point(320, 61);
            lblRaio.Name = "lblRaio";
            lblRaio.Size = new Size(75, 27);
            lblRaio.TabIndex = 3;
            lblRaio.Text = "RAIO:";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Font = new Font("Century Gothic", 13.8F);
            lblAltura.Location = new Point(320, 128);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(104, 27);
            lblAltura.TabIndex = 4;
            lblAltura.Text = "ALTURA:";
            lblAltura.Click += label2_Click;
            // 
            // lblVolume
            // 
            lblVolume.AutoSize = true;
            lblVolume.Font = new Font("Century Gothic", 13.8F);
            lblVolume.Location = new Point(320, 212);
            lblVolume.Name = "lblVolume";
            lblVolume.Size = new Size(117, 27);
            lblVolume.TabIndex = 5;
            lblVolume.Text = "VOLUME:";
            lblVolume.Click += label3_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = SystemColors.GrayText;
            btnCalcular.Font = new Font("Copperplate Gothic Light", 13.8F);
            btnCalcular.ForeColor = SystemColors.ActiveCaptionText;
            btnCalcular.Location = new Point(223, 325);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(187, 58);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = SystemColors.GrayText;
            btnLimpar.Font = new Font("Copperplate Gothic Light", 13.8F);
            btnLimpar.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpar.Location = new Point(444, 325);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(187, 58);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += button2_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = SystemColors.GrayText;
            btnFechar.Font = new Font("Copperplate Gothic Light", 13.8F);
            btnFechar.ForeColor = SystemColors.ActiveCaptionText;
            btnFechar.Location = new Point(666, 325);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(187, 58);
            btnFechar.TabIndex = 7;
            btnFechar.Tag = "fechar";
            btnFechar.Text = "FECHAR";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 463);
            Controls.Add(btnFechar);
            Controls.Add(btnLimpar);
            Controls.Add(btnCalcular);
            Controls.Add(lblVolume);
            Controls.Add(lblAltura);
            Controls.Add(lblRaio);
            Controls.Add(txtVolume);
            Controls.Add(txtAltura);
            Controls.Add(txtRaio);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRaio;
        private TextBox txtAltura;
        private TextBox txtVolume;
        private Label lblRaio;
        private Label lblAltura;
        private Label lblVolume;
        private Button btnCalcular;
        private Button btnLimpar;
        private Button btnFechar;
    }
}

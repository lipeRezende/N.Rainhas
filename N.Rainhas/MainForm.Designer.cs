namespace N.Rainhas
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.panelTabuleiro = new System.Windows.Forms.Panel();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.populationSizeBox = new System.Windows.Forms.TextBox();
            this.iterationsBox = new System.Windows.Forms.TextBox();
            this.nRainhasBox = new System.Windows.Forms.TextBox();
            this.crossoverRateBox = new System.Windows.Forms.TextBox();
            this.motacaoRateBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.selecaoBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.paradaBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelTabuleiro
            // 
            this.panelTabuleiro.AutoScroll = true;
            this.panelTabuleiro.AutoSize = true;
            this.panelTabuleiro.Location = new System.Drawing.Point(13, 124);
            this.panelTabuleiro.Name = "panelTabuleiro";
            this.panelTabuleiro.Size = new System.Drawing.Size(739, 629);
            this.panelTabuleiro.TabIndex = 2;
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(13, 22);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(351, 83);
            this.logBox.TabIndex = 3;
            this.logBox.Text = "";
            // 
            // populationSizeBox
            // 
            this.populationSizeBox.Location = new System.Drawing.Point(697, 12);
            this.populationSizeBox.Name = "populationSizeBox";
            this.populationSizeBox.Size = new System.Drawing.Size(55, 20);
            this.populationSizeBox.TabIndex = 4;
            this.populationSizeBox.Text = "12";
            // 
            // iterationsBox
            // 
            this.iterationsBox.Location = new System.Drawing.Point(697, 38);
            this.iterationsBox.Name = "iterationsBox";
            this.iterationsBox.Size = new System.Drawing.Size(55, 20);
            this.iterationsBox.TabIndex = 5;
            this.iterationsBox.Text = "750";
            // 
            // nRainhasBox
            // 
            this.nRainhasBox.Location = new System.Drawing.Point(481, 8);
            this.nRainhasBox.Name = "nRainhasBox";
            this.nRainhasBox.Size = new System.Drawing.Size(56, 20);
            this.nRainhasBox.TabIndex = 6;
            this.nRainhasBox.Text = "8";
            // 
            // crossoverRateBox
            // 
            this.crossoverRateBox.Location = new System.Drawing.Point(481, 34);
            this.crossoverRateBox.Name = "crossoverRateBox";
            this.crossoverRateBox.Size = new System.Drawing.Size(56, 20);
            this.crossoverRateBox.TabIndex = 7;
            this.crossoverRateBox.Text = "0.75";
            // 
            // motacaoRateBox
            // 
            this.motacaoRateBox.Location = new System.Drawing.Point(481, 60);
            this.motacaoRateBox.Name = "motacaoRateBox";
            this.motacaoRateBox.Size = new System.Drawing.Size(55, 20);
            this.motacaoRateBox.TabIndex = 8;
            this.motacaoRateBox.Text = "0.01";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(603, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "População Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(603, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "N. Gerações";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Taxa de Mutação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(405, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "N. Rainhas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Taxa de Cruzamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Log";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tabuleiro";
            // 
            // selecaoBox
            // 
            this.selecaoBox.DisplayMember = "1";
            this.selecaoBox.FormattingEnabled = true;
            this.selecaoBox.Items.AddRange(new object[] {
            "Roleta",
            "Elite",
            "Rank"});
            this.selecaoBox.Location = new System.Drawing.Point(641, 64);
            this.selecaoBox.Name = "selecaoBox";
            this.selecaoBox.Size = new System.Drawing.Size(111, 21);
            this.selecaoBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(589, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Seleção";
            // 
            // paradaBox
            // 
            this.paradaBox.Location = new System.Drawing.Point(520, 95);
            this.paradaBox.Name = "paradaBox";
            this.paradaBox.Size = new System.Drawing.Size(42, 20);
            this.paradaBox.TabIndex = 17;
            this.paradaBox.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(399, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Para a Cada Gerações";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 765);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.paradaBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.selecaoBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.crossoverRateBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nRainhasBox);
            this.Controls.Add(this.iterationsBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.populationSizeBox);
            this.Controls.Add(this.motacaoRateBox);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.panelTabuleiro);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "N Rainhas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelTabuleiro;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.TextBox populationSizeBox;
        private System.Windows.Forms.TextBox iterationsBox;
        private System.Windows.Forms.TextBox nRainhasBox;
        private System.Windows.Forms.TextBox crossoverRateBox;
        private System.Windows.Forms.TextBox motacaoRateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox selecaoBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox paradaBox;
        private System.Windows.Forms.Label label9;
    }
}


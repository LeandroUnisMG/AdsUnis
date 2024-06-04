namespace CalcularIMC
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
            label1 = new Label();
            label2 = new Label();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            bntCalcular = new Button();
            label3 = new Label();
            lbIMC = new Label();
            lbClassificacao = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 43);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Peso(Kg)";  
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 112);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 1;
            label2.Text = "Altura(Cm)";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(149, 40);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(125, 27);
            txtPeso.TabIndex = 2;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(149, 112);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(125, 27);
            txtAltura.TabIndex = 3;
            // 
            // bntCalcular
            // 
            bntCalcular.Location = new Point(149, 194);
            bntCalcular.Name = "bntCalcular";
            bntCalcular.Size = new Size(115, 29);
            bntCalcular.TabIndex = 4;
            bntCalcular.Text = "CalcularIMC";
            bntCalcular.UseVisualStyleBackColor = true;
            bntCalcular.Click += bntCalcular_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(171, 267);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 5;
            label3.Text = "Resultado";
            // 
            // lbIMC
            // 
            lbIMC.AutoSize = true;
            lbIMC.Location = new Point(186, 316);
            lbIMC.Name = "lbIMC";
            lbIMC.Size = new Size(35, 20);
            lbIMC.TabIndex = 6;
            lbIMC.Text = "IMC";
            lbIMC.Visible = false;
            // 
            // lbClassificacao
            // 
            lbClassificacao.AutoSize = true;
            lbClassificacao.Location = new Point(170, 360);
            lbClassificacao.Name = "lbClassificacao";
            lbClassificacao.Size = new Size(94, 20);
            lbClassificacao.TabIndex = 7;
            lbClassificacao.Text = "Classificação";
            lbClassificacao.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 436);
            Controls.Add(lbClassificacao);
            Controls.Add(lbIMC);
            Controls.Add(label3);
            Controls.Add(bntCalcular);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Button bntCalcular;
        private Label label3;
        private Label lbIMC;
        private Label lbClassificacao;
    }
}

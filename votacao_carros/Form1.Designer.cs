namespace votacao_carros
{
    partial class frmCarros
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
            lbl_titulo = new Label();
            btn_carro1 = new Button();
            btn_carro2 = new Button();
            pic_carros = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            btn_limpar = new Button();
            lbl_civic = new Label();
            lbl_corolla = new Label();
            btn_votar = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_carros).BeginInit();
            SuspendLayout();
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_titulo.Location = new Point(29, 27);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(145, 23);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "Escolha um carro:";
            // 
            // btn_carro1
            // 
            btn_carro1.Location = new Point(29, 75);
            btn_carro1.Name = "btn_carro1";
            btn_carro1.Size = new Size(121, 40);
            btn_carro1.TabIndex = 1;
            btn_carro1.Text = "Honda Civic";
            btn_carro1.UseVisualStyleBackColor = true;
            btn_carro1.Click += btn_carro1_Click;
            // 
            // btn_carro2
            // 
            btn_carro2.Location = new Point(169, 75);
            btn_carro2.Name = "btn_carro2";
            btn_carro2.Size = new Size(121, 40);
            btn_carro2.TabIndex = 2;
            btn_carro2.Text = "Toyota Corolla";
            btn_carro2.UseVisualStyleBackColor = true;
            btn_carro2.Click += btn_carro2_Click;
            // 
            // pic_carros
            // 
            pic_carros.Image = Properties.Resources.carros1;
            pic_carros.Location = new Point(29, 132);
            pic_carros.Name = "pic_carros";
            pic_carros.Size = new Size(256, 168);
            pic_carros.SizeMode = PictureBoxSizeMode.Zoom;
            pic_carros.TabIndex = 3;
            pic_carros.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 391);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 4;
            label2.Text = "Votos Civic:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 427);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 5;
            label3.Text = "Votos Corolla:";
            // 
            // btn_limpar
            // 
            btn_limpar.Location = new Point(29, 457);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(261, 38);
            btn_limpar.TabIndex = 6;
            btn_limpar.Text = "Limpar Tudo";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // lbl_civic
            // 
            lbl_civic.AutoSize = true;
            lbl_civic.Location = new Point(150, 391);
            lbl_civic.Name = "lbl_civic";
            lbl_civic.Size = new Size(17, 20);
            lbl_civic.TabIndex = 7;
            lbl_civic.Text = "0";
            // 
            // lbl_corolla
            // 
            lbl_corolla.AutoSize = true;
            lbl_corolla.Location = new Point(150, 427);
            lbl_corolla.Name = "lbl_corolla";
            lbl_corolla.Size = new Size(17, 20);
            lbl_corolla.TabIndex = 8;
            lbl_corolla.Text = "0";
            // 
            // btn_votar
            // 
            btn_votar.Location = new Point(29, 317);
            btn_votar.Name = "btn_votar";
            btn_votar.Size = new Size(261, 40);
            btn_votar.TabIndex = 9;
            btn_votar.Text = "Votar";
            btn_votar.UseVisualStyleBackColor = true;
            btn_votar.Click += btn_votar_Click;
            // 
            // frmCarros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 520);
            Controls.Add(btn_votar);
            Controls.Add(lbl_corolla);
            Controls.Add(lbl_civic);
            Controls.Add(btn_limpar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pic_carros);
            Controls.Add(btn_carro2);
            Controls.Add(btn_carro1);
            Controls.Add(lbl_titulo);
            Name = "frmCarros";
            Text = "Votação de Carros";
            ((System.ComponentModel.ISupportInitialize)pic_carros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titulo;
        private Button btn_carro1;
        private Button btn_carro2;
        private PictureBox pic_carros;
        private Label label2;
        private Label label3;
        private Button btn_limpar;
        private Label lbl_civic;
        private Label lbl_corolla;
        private Button btn_votar;
    }
}

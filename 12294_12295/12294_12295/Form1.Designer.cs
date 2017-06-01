namespace _12294_12295
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnChecaCEP = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.picCPFStatus = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pcbUsuario = new System.Windows.Forms.PictureBox();
            this.Foto = new System.Windows.Forms.Label();
            this.btnArquivoFoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.btnImgLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCPFStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(121, 108);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(246, 20);
            this.txtNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "CEP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Logradouro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Bairro:";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(121, 213);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(70, 20);
            this.txtCEP.TabIndex = 5;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(121, 74);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 1;
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // btnChecaCEP
            // 
            this.btnChecaCEP.Location = new System.Drawing.Point(197, 211);
            this.btnChecaCEP.Name = "btnChecaCEP";
            this.btnChecaCEP.Size = new System.Drawing.Size(86, 23);
            this.btnChecaCEP.TabIndex = 10;
            this.btnChecaCEP.Text = "Checar CEP";
            this.btnChecaCEP.UseVisualStyleBackColor = true;
            this.btnChecaCEP.Click += new System.EventHandler(this.btnChecaCEP_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(121, 143);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(246, 20);
            this.txtTelefone.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(121, 176);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(246, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // picCPFStatus
            // 
            this.picCPFStatus.Location = new System.Drawing.Point(228, 74);
            this.picCPFStatus.Name = "picCPFStatus";
            this.picCPFStatus.Size = new System.Drawing.Size(24, 20);
            this.picCPFStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCPFStatus.TabIndex = 13;
            this.picCPFStatus.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "UF:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(121, 251);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(246, 20);
            this.txtLogradouro.TabIndex = 6;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(121, 286);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(246, 20);
            this.txtBairro.TabIndex = 7;
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(306, 322);
            this.txtUF.MaxLength = 2;
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(61, 20);
            this.txtUF.TabIndex = 9;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(121, 322);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(60, 20);
            this.txtComplemento.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Complemento:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(396, 72);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 20;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(396, 143);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 21;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(396, 179);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(258, 72);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 23;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(396, 106);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 24;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Sobre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pcbUsuario
            // 
            this.pcbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbUsuario.Location = new System.Drawing.Point(496, 100);
            this.pcbUsuario.Name = "pcbUsuario";
            this.pcbUsuario.Size = new System.Drawing.Size(237, 209);
            this.pcbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUsuario.TabIndex = 26;
            this.pcbUsuario.TabStop = false;
            // 
            // Foto
            // 
            this.Foto.AutoSize = true;
            this.Foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Foto.Location = new System.Drawing.Point(493, 77);
            this.Foto.Name = "Foto";
            this.Foto.Size = new System.Drawing.Size(36, 17);
            this.Foto.TabIndex = 27;
            this.Foto.Text = "Foto";
            // 
            // btnArquivoFoto
            // 
            this.btnArquivoFoto.Location = new System.Drawing.Point(496, 320);
            this.btnArquivoFoto.Name = "btnArquivoFoto";
            this.btnArquivoFoto.Size = new System.Drawing.Size(128, 23);
            this.btnArquivoFoto.TabIndex = 28;
            this.btnArquivoFoto.Text = "Escolha seu arquivo";
            this.btnArquivoFoto.UseVisualStyleBackColor = true;
            this.btnArquivoFoto.Click += new System.EventHandler(this.btnArquivoFoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Formulário de Cadastro";
            // 
            // btnImgLimpar
            // 
            this.btnImgLimpar.Location = new System.Drawing.Point(658, 322);
            this.btnImgLimpar.Name = "btnImgLimpar";
            this.btnImgLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnImgLimpar.TabIndex = 30;
            this.btnImgLimpar.Text = "Limpar";
            this.btnImgLimpar.UseVisualStyleBackColor = true;
            this.btnImgLimpar.Click += new System.EventHandler(this.btnImgLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 375);
            this.Controls.Add(this.btnImgLimpar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnArquivoFoto);
            this.Controls.Add(this.Foto);
            this.Controls.Add(this.pcbUsuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.picCPFStatus);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.btnChecaCEP);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cadastro de Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.picCPFStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Button btnChecaCEP;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox picCPFStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pcbUsuario;
        private System.Windows.Forms.Label Foto;
        private System.Windows.Forms.Button btnArquivoFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnImgLimpar;
    }
}


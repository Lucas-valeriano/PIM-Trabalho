namespace PIM
{
    partial class Venda
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.insere = new System.Windows.Forms.Button();
            this.txtInsere = new System.Windows.Forms.MaskedTextBox();
            this.finalizar = new System.Windows.Forms.Button();
            this.dt = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.VenCadCep = new System.Windows.Forms.MaskedTextBox();
            this.VenCadCel = new System.Windows.Forms.MaskedTextBox();
            this.VenCadTel = new System.Windows.Forms.MaskedTextBox();
            this.VenCadRg = new System.Windows.Forms.MaskedTextBox();
            this.VenCadCpf = new System.Windows.Forms.MaskedTextBox();
            this.VenCadDtN = new System.Windows.Forms.MaskedTextBox();
            this.btnVenCadLimpar = new System.Windows.Forms.Button();
            this.btnVenCadPesquisar = new System.Windows.Forms.Button();
            this.VenCadPais = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.VenCadEstado = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.VenCadCidade = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.VenCadBairro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.VenCadNum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.VenCadRua = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.VenCadEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.VenCadDDD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.VenCadSexo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VenCadNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVenCadSalvar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.insere);
            this.panel1.Controls.Add(this.txtInsere);
            this.panel1.Controls.Add(this.finalizar);
            this.panel1.Controls.Add(this.dt);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(6, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 575);
            this.panel1.TabIndex = 0;
            // 
            // insere
            // 
            this.insere.Location = new System.Drawing.Point(158, 218);
            this.insere.Name = "insere";
            this.insere.Size = new System.Drawing.Size(113, 20);
            this.insere.TabIndex = 37;
            this.insere.Text = "Inserir Produto";
            this.insere.UseVisualStyleBackColor = true;
            this.insere.Click += new System.EventHandler(this.insere_Click);
            // 
            // txtInsere
            // 
            this.txtInsere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsere.Location = new System.Drawing.Point(5, 218);
            this.txtInsere.Name = "txtInsere";
            this.txtInsere.Size = new System.Drawing.Size(133, 20);
            this.txtInsere.TabIndex = 36;
            // 
            // finalizar
            // 
            this.finalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(54)))));
            this.finalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finalizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(54)))));
            this.finalizar.FlatAppearance.BorderSize = 0;
            this.finalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(54)))));
            this.finalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(54)))));
            this.finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalizar.ForeColor = System.Drawing.Color.White;
            this.finalizar.Location = new System.Drawing.Point(751, 522);
            this.finalizar.Name = "finalizar";
            this.finalizar.Size = new System.Drawing.Size(220, 48);
            this.finalizar.TabIndex = 5;
            this.finalizar.Text = "Finalizar compra";
            this.finalizar.UseVisualStyleBackColor = false;
            this.finalizar.Click += new System.EventHandler(this.finalizar_Click);
            // 
            // dt
            // 
            this.dt.BackgroundColor = System.Drawing.Color.White;
            this.dt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt.Location = new System.Drawing.Point(5, 253);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(966, 258);
            this.dt.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.tipo);
            this.groupBox1.Controls.Add(this.VenCadCep);
            this.groupBox1.Controls.Add(this.VenCadCel);
            this.groupBox1.Controls.Add(this.VenCadTel);
            this.groupBox1.Controls.Add(this.VenCadRg);
            this.groupBox1.Controls.Add(this.VenCadCpf);
            this.groupBox1.Controls.Add(this.VenCadDtN);
            this.groupBox1.Controls.Add(this.btnVenCadLimpar);
            this.groupBox1.Controls.Add(this.btnVenCadPesquisar);
            this.groupBox1.Controls.Add(this.VenCadPais);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.VenCadEstado);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.VenCadCidade);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.VenCadBairro);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.VenCadNum);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.VenCadRua);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.VenCadEmail);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.VenCadDDD);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.VenCadSexo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.VenCadNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnVenCadSalvar);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(3, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(969, 204);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // tipo
            // 
            this.tipo.FormattingEnabled = true;
            this.tipo.Items.AddRange(new object[] {
            "CLIENTE",
            "PARCEIRO DE NEGÓCIO",
            "COLABORADOR"});
            this.tipo.Location = new System.Drawing.Point(533, 170);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(186, 21);
            this.tipo.TabIndex = 68;
            // 
            // VenCadCep
            // 
            this.VenCadCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenCadCep.Location = new System.Drawing.Point(710, 103);
            this.VenCadCep.Name = "VenCadCep";
            this.VenCadCep.Size = new System.Drawing.Size(242, 20);
            this.VenCadCep.TabIndex = 51;
            // 
            // VenCadCel
            // 
            this.VenCadCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenCadCel.Location = new System.Drawing.Point(709, 77);
            this.VenCadCel.Name = "VenCadCel";
            this.VenCadCel.Size = new System.Drawing.Size(242, 20);
            this.VenCadCel.TabIndex = 45;
            // 
            // VenCadTel
            // 
            this.VenCadTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenCadTel.Location = new System.Drawing.Point(382, 80);
            this.VenCadTel.Name = "VenCadTel";
            this.VenCadTel.Size = new System.Drawing.Size(276, 20);
            this.VenCadTel.TabIndex = 44;
            // 
            // VenCadRg
            // 
            this.VenCadRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenCadRg.Location = new System.Drawing.Point(71, 56);
            this.VenCadRg.Name = "VenCadRg";
            this.VenCadRg.Size = new System.Drawing.Size(244, 20);
            this.VenCadRg.TabIndex = 38;
            // 
            // VenCadCpf
            // 
            this.VenCadCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenCadCpf.Location = new System.Drawing.Point(382, 54);
            this.VenCadCpf.Name = "VenCadCpf";
            this.VenCadCpf.Size = new System.Drawing.Size(276, 20);
            this.VenCadCpf.TabIndex = 40;
            // 
            // VenCadDtN
            // 
            this.VenCadDtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenCadDtN.Location = new System.Drawing.Point(382, 28);
            this.VenCadDtN.Name = "VenCadDtN";
            this.VenCadDtN.Size = new System.Drawing.Size(276, 20);
            this.VenCadDtN.TabIndex = 35;
            // 
            // btnVenCadLimpar
            // 
            this.btnVenCadLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.btnVenCadLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.btnVenCadLimpar.FlatAppearance.BorderSize = 0;
            this.btnVenCadLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.btnVenCadLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.btnVenCadLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenCadLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenCadLimpar.ForeColor = System.Drawing.Color.White;
            this.btnVenCadLimpar.Location = new System.Drawing.Point(71, 170);
            this.btnVenCadLimpar.Name = "btnVenCadLimpar";
            this.btnVenCadLimpar.Size = new System.Drawing.Size(106, 22);
            this.btnVenCadLimpar.TabIndex = 59;
            this.btnVenCadLimpar.Text = "Limpar";
            this.btnVenCadLimpar.UseVisualStyleBackColor = false;
            this.btnVenCadLimpar.Click += new System.EventHandler(this.btnVenCadLimpar_Click);
            // 
            // btnVenCadPesquisar
            // 
            this.btnVenCadPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(217)))));
            this.btnVenCadPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVenCadPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(217)))));
            this.btnVenCadPesquisar.FlatAppearance.BorderSize = 0;
            this.btnVenCadPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(217)))));
            this.btnVenCadPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(217)))));
            this.btnVenCadPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenCadPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenCadPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnVenCadPesquisar.Location = new System.Drawing.Point(725, 170);
            this.btnVenCadPesquisar.Name = "btnVenCadPesquisar";
            this.btnVenCadPesquisar.Size = new System.Drawing.Size(115, 22);
            this.btnVenCadPesquisar.TabIndex = 60;
            this.btnVenCadPesquisar.Text = "Pesquisar";
            this.btnVenCadPesquisar.UseVisualStyleBackColor = false;
            this.btnVenCadPesquisar.Click += new System.EventHandler(this.btnVenCadPesquisar_Click);
            // 
            // VenCadPais
            // 
            this.VenCadPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenCadPais.ForeColor = System.Drawing.Color.Black;
            this.VenCadPais.FormattingEnabled = true;
            this.VenCadPais.Items.AddRange(new object[] {
            "Brasil",
            "Paraguai"});
            this.VenCadPais.Location = new System.Drawing.Point(710, 128);
            this.VenCadPais.Name = "VenCadPais";
            this.VenCadPais.Size = new System.Drawing.Size(242, 21);
            this.VenCadPais.TabIndex = 56;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(672, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 67;
            this.label14.Text = "País:";
            // 
            // VenCadEstado
            // 
            this.VenCadEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenCadEstado.ForeColor = System.Drawing.Color.Black;
            this.VenCadEstado.Location = new System.Drawing.Point(382, 132);
            this.VenCadEstado.Name = "VenCadEstado";
            this.VenCadEstado.Size = new System.Drawing.Size(276, 20);
            this.VenCadEstado.TabIndex = 54;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(333, 135);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 66;
            this.label15.Text = "Estado:";
            // 
            // VenCadCidade
            // 
            this.VenCadCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenCadCidade.ForeColor = System.Drawing.Color.Black;
            this.VenCadCidade.Location = new System.Drawing.Point(71, 135);
            this.VenCadCidade.Name = "VenCadCidade";
            this.VenCadCidade.Size = new System.Drawing.Size(244, 20);
            this.VenCadCidade.TabIndex = 53;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(22, 142);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 65;
            this.label16.Text = "Cidade:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(673, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 64;
            this.label13.Text = "CEP:";
            // 
            // VenCadBairro
            // 
            this.VenCadBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenCadBairro.ForeColor = System.Drawing.Color.Black;
            this.VenCadBairro.Location = new System.Drawing.Point(382, 106);
            this.VenCadBairro.Name = "VenCadBairro";
            this.VenCadBairro.Size = new System.Drawing.Size(276, 20);
            this.VenCadBairro.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(339, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 63;
            this.label12.Text = "Bairro:";
            // 
            // VenCadNum
            // 
            this.VenCadNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenCadNum.ForeColor = System.Drawing.Color.Black;
            this.VenCadNum.Location = new System.Drawing.Point(281, 109);
            this.VenCadNum.Name = "VenCadNum";
            this.VenCadNum.Size = new System.Drawing.Size(34, 20);
            this.VenCadNum.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(252, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 62;
            this.label11.Text = "Num:";
            // 
            // VenCadRua
            // 
            this.VenCadRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenCadRua.ForeColor = System.Drawing.Color.Black;
            this.VenCadRua.Location = new System.Drawing.Point(71, 109);
            this.VenCadRua.Name = "VenCadRua";
            this.VenCadRua.Size = new System.Drawing.Size(175, 20);
            this.VenCadRua.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(35, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "Rua:";
            // 
            // VenCadEmail
            // 
            this.VenCadEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenCadEmail.ForeColor = System.Drawing.Color.Black;
            this.VenCadEmail.Location = new System.Drawing.Point(709, 51);
            this.VenCadEmail.Name = "VenCadEmail";
            this.VenCadEmail.Size = new System.Drawing.Size(242, 20);
            this.VenCadEmail.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(665, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 58;
            this.label9.Text = "E-mail:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(678, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Cel:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(346, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Tel:";
            // 
            // VenCadDDD
            // 
            this.VenCadDDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenCadDDD.ForeColor = System.Drawing.Color.Black;
            this.VenCadDDD.Location = new System.Drawing.Point(71, 83);
            this.VenCadDDD.Name = "VenCadDDD";
            this.VenCadDDD.Size = new System.Drawing.Size(244, 20);
            this.VenCadDDD.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(31, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "DDD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(346, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(39, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "RG:";
            // 
            // VenCadSexo
            // 
            this.VenCadSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenCadSexo.ForeColor = System.Drawing.Color.Black;
            this.VenCadSexo.FormattingEnabled = true;
            this.VenCadSexo.Items.AddRange(new object[] {
            "masculino",
            "feminino"});
            this.VenCadSexo.Location = new System.Drawing.Point(709, 24);
            this.VenCadSexo.Name = "VenCadSexo";
            this.VenCadSexo.Size = new System.Drawing.Size(242, 21);
            this.VenCadSexo.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(669, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Sexo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(322, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Dt Nasc:";
            // 
            // VenCadNome
            // 
            this.VenCadNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenCadNome.ForeColor = System.Drawing.Color.Black;
            this.VenCadNome.Location = new System.Drawing.Point(71, 28);
            this.VenCadNome.Name = "VenCadNome";
            this.VenCadNome.Size = new System.Drawing.Size(244, 20);
            this.VenCadNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nome:";
            // 
            // btnVenCadSalvar
            // 
            this.btnVenCadSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(112)))));
            this.btnVenCadSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVenCadSalvar.FlatAppearance.BorderSize = 0;
            this.btnVenCadSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenCadSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenCadSalvar.ForeColor = System.Drawing.Color.White;
            this.btnVenCadSalvar.Location = new System.Drawing.Point(846, 170);
            this.btnVenCadSalvar.Name = "btnVenCadSalvar";
            this.btnVenCadSalvar.Size = new System.Drawing.Size(105, 22);
            this.btnVenCadSalvar.TabIndex = 57;
            this.btnVenCadSalvar.Text = "Cadastrar";
            this.btnVenCadSalvar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PIM.Properties.Resources.cancel1;
            this.pictureBox1.Location = new System.Drawing.Point(954, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(984, 613);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Venda";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button finalizar;
        private System.Windows.Forms.DataGridView dt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox tipo;
        private System.Windows.Forms.MaskedTextBox VenCadCep;
        private System.Windows.Forms.MaskedTextBox VenCadCel;
        private System.Windows.Forms.MaskedTextBox VenCadTel;
        private System.Windows.Forms.MaskedTextBox VenCadRg;
        private System.Windows.Forms.MaskedTextBox VenCadCpf;
        private System.Windows.Forms.MaskedTextBox VenCadDtN;
        private System.Windows.Forms.Button btnVenCadLimpar;
        private System.Windows.Forms.Button btnVenCadPesquisar;
        private System.Windows.Forms.ComboBox VenCadPais;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox VenCadEstado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox VenCadCidade;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox VenCadBairro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox VenCadNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox VenCadRua;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox VenCadEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox VenCadDDD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox VenCadSexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VenCadNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVenCadSalvar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button insere;
        private System.Windows.Forms.MaskedTextBox txtInsere;
    }
}
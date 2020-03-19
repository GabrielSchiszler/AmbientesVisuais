namespace DataGridView
{
    partial class FormCadastro
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNecEspeciais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDataN = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNecessidades = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.mtxtRG = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblExcluido = new System.Windows.Forms.Label();
            this.grpboxCadastro = new System.Windows.Forms.GroupBox();
            this.lblValida = new System.Windows.Forms.Label();
            this.picCadastro = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.grpboxCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colDataNascimento,
            this.colSexo,
            this.colCPF,
            this.colRG,
            this.colNecEspeciais});
            this.dgvClientes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvClientes.Location = new System.Drawing.Point(12, 420);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(643, 179);
            this.dgvClientes.TabIndex = 14;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // colName
            // 
            this.colName.HeaderText = "Nome";
            this.colName.Name = "colName";
            // 
            // colDataNascimento
            // 
            this.colDataNascimento.HeaderText = "Data de Nascimento";
            this.colDataNascimento.Name = "colDataNascimento";
            // 
            // colSexo
            // 
            this.colSexo.HeaderText = "Sexo";
            this.colSexo.Name = "colSexo";
            // 
            // colCPF
            // 
            this.colCPF.HeaderText = "CPF";
            this.colCPF.Name = "colCPF";
            // 
            // colRG
            // 
            this.colRG.HeaderText = "RG";
            this.colRG.Name = "colRG";
            // 
            // colNecEspeciais
            // 
            this.colNecEspeciais.HeaderText = "Necessidades Especiais";
            this.colNecEspeciais.Name = "colNecEspeciais";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(127, 107);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblDataN
            // 
            this.lblDataN.AutoSize = true;
            this.lblDataN.Location = new System.Drawing.Point(58, 145);
            this.lblDataN.Name = "lblDataN";
            this.lblDataN.Size = new System.Drawing.Size(107, 13);
            this.lblDataN.TabIndex = 1;
            this.lblDataN.Text = "Data de Nascimento:\r\n";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(127, 184);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 2;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblNecessidades
            // 
            this.lblNecessidades.AutoSize = true;
            this.lblNecessidades.Location = new System.Drawing.Point(36, 221);
            this.lblNecessidades.Name = "lblNecessidades";
            this.lblNecessidades.Size = new System.Drawing.Size(125, 13);
            this.lblNecessidades.TabIndex = 3;
            this.lblNecessidades.Text = "Necessidades Especiais:";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(139, 265);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(26, 13);
            this.lblRG.TabIndex = 4;
            this.lblRG.Text = "RG:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(135, 317);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 5;
            this.lblCPF.Text = "CPF:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(175, 107);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(432, 20);
            this.txtNome.TabIndex = 6;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(175, 145);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(236, 20);
            this.dtpDataNascimento.TabIndex = 7;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cmbSexo.Location = new System.Drawing.Point(175, 184);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(137, 21);
            this.cmbSexo.TabIndex = 8;
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Location = new System.Drawing.Point(175, 221);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(42, 17);
            this.rbSim.TabIndex = 9;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim\r\n";
            this.rbSim.UseVisualStyleBackColor = true;
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Location = new System.Drawing.Point(248, 221);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(45, 17);
            this.rbNao.TabIndex = 10;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // mtxtRG
            // 
            this.mtxtRG.Location = new System.Drawing.Point(175, 262);
            this.mtxtRG.Mask = "99.999.999.9";
            this.mtxtRG.Name = "mtxtRG";
            this.mtxtRG.Size = new System.Drawing.Size(169, 20);
            this.mtxtRG.TabIndex = 11;
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Location = new System.Drawing.Point(175, 310);
            this.mtxtCPF.Mask = "999.999.999.99";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(169, 20);
            this.mtxtCPF.TabIndex = 12;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(175, 360);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(88, 33);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(269, 360);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(88, 33);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblExcluido
            // 
            this.lblExcluido.AutoSize = true;
            this.lblExcluido.BackColor = System.Drawing.Color.Transparent;
            this.lblExcluido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcluido.ForeColor = System.Drawing.Color.Red;
            this.lblExcluido.Location = new System.Drawing.Point(432, 373);
            this.lblExcluido.Name = "lblExcluido";
            this.lblExcluido.Size = new System.Drawing.Size(165, 20);
            this.lblExcluido.TabIndex = 15;
            this.lblExcluido.Text = "Excluido com sucesso";
            // 
            // grpboxCadastro
            // 
            this.grpboxCadastro.Controls.Add(this.label1);
            this.grpboxCadastro.Controls.Add(this.picCadastro);
            this.grpboxCadastro.Controls.Add(this.lblValida);
            this.grpboxCadastro.Controls.Add(this.lblExcluido);
            this.grpboxCadastro.Controls.Add(this.btnExcluir);
            this.grpboxCadastro.Controls.Add(this.btnCadastrar);
            this.grpboxCadastro.Controls.Add(this.mtxtCPF);
            this.grpboxCadastro.Controls.Add(this.mtxtRG);
            this.grpboxCadastro.Controls.Add(this.rbNao);
            this.grpboxCadastro.Controls.Add(this.rbSim);
            this.grpboxCadastro.Controls.Add(this.cmbSexo);
            this.grpboxCadastro.Controls.Add(this.dtpDataNascimento);
            this.grpboxCadastro.Controls.Add(this.txtNome);
            this.grpboxCadastro.Controls.Add(this.lblCPF);
            this.grpboxCadastro.Controls.Add(this.lblRG);
            this.grpboxCadastro.Controls.Add(this.lblNecessidades);
            this.grpboxCadastro.Controls.Add(this.lblSexo);
            this.grpboxCadastro.Controls.Add(this.lblDataN);
            this.grpboxCadastro.Controls.Add(this.lblNome);
            this.grpboxCadastro.Location = new System.Drawing.Point(12, 12);
            this.grpboxCadastro.Name = "grpboxCadastro";
            this.grpboxCadastro.Size = new System.Drawing.Size(643, 405);
            this.grpboxCadastro.TabIndex = 0;
            this.grpboxCadastro.TabStop = false;
            this.grpboxCadastro.Text = "Cadastro de Pessoas";
            // 
            // lblValida
            // 
            this.lblValida.AutoSize = true;
            this.lblValida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValida.ForeColor = System.Drawing.Color.Red;
            this.lblValida.Location = new System.Drawing.Point(366, 335);
            this.lblValida.Name = "lblValida";
            this.lblValida.Size = new System.Drawing.Size(261, 20);
            this.lblValida.TabIndex = 16;
            this.lblValida.Text = "* Todos os campos são obrigatórios";
            // 
            // picCadastro
            // 
            this.picCadastro.BackColor = System.Drawing.Color.Transparent;
            this.picCadastro.Image = global::DataGridView.Properties.Resources.img;
            this.picCadastro.Location = new System.Drawing.Point(6, 19);
            this.picCadastro.Name = "picCadastro";
            this.picCadastro.Size = new System.Drawing.Size(104, 117);
            this.picCadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCadastro.TabIndex = 15;
            this.picCadastro.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Formulario de Cadastro";
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(677, 594);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.grpboxCadastro);
            this.Name = "FormCadastro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.grpboxCadastro.ResumeLayout(false);
            this.grpboxCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCadastro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNecEspeciais;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDataN;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblNecessidades;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.MaskedTextBox mtxtRG;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblExcluido;
        private System.Windows.Forms.GroupBox grpboxCadastro;
        private System.Windows.Forms.Label lblValida;
        private System.Windows.Forms.PictureBox picCadastro;
        private System.Windows.Forms.Label label1;
    }
}


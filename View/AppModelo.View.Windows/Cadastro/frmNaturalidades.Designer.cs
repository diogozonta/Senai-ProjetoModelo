namespace AppModelo.View.Windows.Cadastro
{
    partial class frmNaturalidades
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.RadioButton rbAtivo;
            System.Windows.Forms.RadioButton rbDesativo;
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gvNaturalidades = new System.Windows.Forms.DataGridView();
            this.dtpDataCriacao = new System.Windows.Forms.DateTimePicker();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gbSituacao = new System.Windows.Forms.GroupBox();
            rbAtivo = new System.Windows.Forms.RadioButton();
            rbDesativo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvNaturalidades)).BeginInit();
            this.gbSituacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(32, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(32, 74);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(100, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de criação";
            // 
            // gvNaturalidades
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvNaturalidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.gvNaturalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvNaturalidades.DefaultCellStyle = dataGridViewCellStyle17;
            this.gvNaturalidades.Location = new System.Drawing.Point(32, 157);
            this.gvNaturalidades.Name = "gvNaturalidades";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvNaturalidades.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.gvNaturalidades.Size = new System.Drawing.Size(435, 269);
            this.gvNaturalidades.TabIndex = 6;
            // 
            // dtpDataCriacao
            // 
            this.dtpDataCriacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCriacao.Location = new System.Drawing.Point(151, 32);
            this.dtpDataCriacao.Name = "dtpDataCriacao";
            this.dtpDataCriacao.Size = new System.Drawing.Size(100, 20);
            this.dtpDataCriacao.TabIndex = 7;
            this.dtpDataCriacao.Value = new System.DateTime(2022, 10, 20, 19, 44, 27, 0);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(312, 45);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(114, 49);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // rbAtivo
            // 
            rbAtivo.AutoSize = true;
            rbAtivo.Location = new System.Drawing.Point(15, 19);
            rbAtivo.Name = "rbAtivo";
            rbAtivo.Size = new System.Drawing.Size(49, 17);
            rbAtivo.TabIndex = 0;
            rbAtivo.Text = "Ativo";
            rbAtivo.UseVisualStyleBackColor = true;
            // 
            // rbDesativo
            // 
            rbDesativo.AutoSize = true;
            rbDesativo.Location = new System.Drawing.Point(15, 42);
            rbDesativo.Name = "rbDesativo";
            rbDesativo.Size = new System.Drawing.Size(67, 17);
            rbDesativo.TabIndex = 1;
            rbDesativo.Text = "Desativo";
            rbDesativo.UseVisualStyleBackColor = true;
            // 
            // gbSituacao
            // 
            this.gbSituacao.Controls.Add(rbDesativo);
            this.gbSituacao.Controls.Add(rbAtivo);
            this.gbSituacao.Location = new System.Drawing.Point(151, 58);
            this.gbSituacao.Name = "gbSituacao";
            this.gbSituacao.Size = new System.Drawing.Size(100, 70);
            this.gbSituacao.TabIndex = 11;
            this.gbSituacao.TabStop = false;
            this.gbSituacao.Text = "Situação";
            // 
            // frmNaturalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 438);
            this.Controls.Add(this.gbSituacao);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dtpDataCriacao);
            this.Controls.Add(this.gvNaturalidades);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "frmNaturalidades";
            this.Text = "frmNaturalidades";
            ((System.ComponentModel.ISupportInitialize)(this.gvNaturalidades)).EndInit();
            this.gbSituacao.ResumeLayout(false);
            this.gbSituacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gvNaturalidades;
        private System.Windows.Forms.DateTimePicker dtpDataCriacao;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox gbSituacao;
    }
}
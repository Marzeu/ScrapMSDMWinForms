namespace ScrapMSDMWinForms
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
            dataGridView1 = new DataGridView();
            Titulo = new DataGridViewTextBoxColumn();
            Postagem = new DataGridViewTextBoxColumn();
            Exibicao = new DataGridViewTextBoxColumn();
            Resposta = new DataGridViewTextBoxColumn();
            Link = new DataGridViewLinkColumn();
            AtualizarBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Titulo, Postagem, Exibicao, Resposta, Link });
            dataGridView1.Location = new Point(37, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(795, 701);
            dataGridView1.TabIndex = 0;
            //dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Titulo
            // 
            Titulo.HeaderText = "Título";
            Titulo.Name = "Titulo";
            Titulo.Width = 300;
            // 
            // Postagem
            // 
            Postagem.HeaderText = "Postagem";
            Postagem.Name = "Postagem";
            Postagem.Width = 150;
            // 
            // Exibicao
            // 
            Exibicao.HeaderText = "Exibição";
            Exibicao.Name = "Exibicao";
            // 
            // Resposta
            // 
            Resposta.HeaderText = "Respostas";
            Resposta.Name = "Resposta";
            // 
            // Link
            // 
            Link.HeaderText = "Link";
            Link.Name = "Link";
            // 
            // AtualizarBtn
            // 
            AtualizarBtn.Location = new Point(37, 31);
            AtualizarBtn.Name = "AtualizarBtn";
            AtualizarBtn.Size = new Size(75, 23);
            AtualizarBtn.TabIndex = 1;
            AtualizarBtn.Text = "Atualizar Lista";
            AtualizarBtn.UseVisualStyleBackColor = true;
            AtualizarBtn.Click += AtualizarBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 808);
            Controls.Add(AtualizarBtn);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "MSDN";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Postagem;
        private DataGridViewTextBoxColumn Exibicao;
        private DataGridViewTextBoxColumn Resposta;
        private DataGridViewLinkColumn Link;
        private Button AtualizarBtn;
    }
}
namespace Biblioteca.UI.Forms
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
            dataGridView1 = new DataGridView();
            btnAggiungiLibro = new Button();
            btnAggiungiUtente = new Button();
            btnAggiungiPrestito = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(566, 150);
            dataGridView1.TabIndex = 0;
            // 
            // btnAggiungiLibro
            // 
            btnAggiungiLibro.Location = new Point(622, 23);
            btnAggiungiLibro.Name = "btnAggiungiLibro";
            btnAggiungiLibro.Size = new Size(113, 33);
            btnAggiungiLibro.TabIndex = 1;
            btnAggiungiLibro.Text = "Aggiungi libro";
            btnAggiungiLibro.UseVisualStyleBackColor = true;
            btnAggiungiLibro.Click += btn_AggiungiLibro_Click;
            // 
            // btnAggiungiUtente
            // 
            btnAggiungiUtente.Location = new Point(622, 62);
            btnAggiungiUtente.Name = "btnAggiungiUtente";
            btnAggiungiUtente.Size = new Size(113, 33);
            btnAggiungiUtente.TabIndex = 2;
            btnAggiungiUtente.Text = "Aggiungi utente";
            btnAggiungiUtente.UseVisualStyleBackColor = true;
            btnAggiungiUtente.Click += btn_AggiungiUtente_Click;
            // 
            // btnAggiungiPrestito
            // 
            btnAggiungiPrestito.Location = new Point(622, 101);
            btnAggiungiPrestito.Name = "btnAggiungiPrestito";
            btnAggiungiPrestito.Size = new Size(113, 33);
            btnAggiungiPrestito.TabIndex = 3;
            btnAggiungiPrestito.Text = "Prestito";
            btnAggiungiPrestito.UseVisualStyleBackColor = true;
            btnAggiungiPrestito.Click += btn_AggiungiPrestito_Click;
            // 
            // button1
            // 
            button1.Location = new Point(622, 140);
            button1.Name = "button1";
            button1.Size = new Size(113, 33);
            button1.TabIndex = 4;
            button1.Text = "Chiuidi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnAggiungiPrestito);
            Controls.Add(btnAggiungiUtente);
            Controls.Add(btnAggiungiLibro);
            Controls.Add(dataGridView1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAggiungiLibro;
        private Button btnAggiungiUtente;
        private Button btnAggiungiPrestito;
        private Button button1;
    }
}
namespace Biblioteca.UI.Forms
{
    partial class LibriForm
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
            label1 = new Label();
            txtTitolo = new TextBox();
            label2 = new Label();
            txtAutore = new TextBox();
            label3 = new Label();
            txtISBN = new TextBox();
            chkDisponibile = new CheckBox();
            btnSalva = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 54);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Titolo";
            // 
            // txtTitolo
            // 
            txtTitolo.Location = new Point(128, 46);
            txtTitolo.Name = "txtTitolo";
            txtTitolo.Size = new Size(100, 23);
            txtTitolo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 102);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Autore";
            // 
            // txtAutore
            // 
            txtAutore.Location = new Point(128, 94);
            txtAutore.Name = "txtAutore";
            txtAutore.Size = new Size(100, 23);
            txtAutore.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 141);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 4;
            label3.Text = "ISBN";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(128, 138);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(100, 23);
            txtISBN.TabIndex = 5;
            // 
            // chkDisponibile
            // 
            chkDisponibile.AutoSize = true;
            chkDisponibile.Location = new Point(51, 181);
            chkDisponibile.Name = "chkDisponibile";
            chkDisponibile.Size = new Size(85, 19);
            chkDisponibile.TabIndex = 6;
            chkDisponibile.Text = "Disponibile";
            chkDisponibile.UseVisualStyleBackColor = true;
            // 
            // btnSalva
            // 
            btnSalva.Location = new Point(293, 38);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(82, 37);
            btnSalva.TabIndex = 7;
            btnSalva.Text = "Salva";
            btnSalva.UseVisualStyleBackColor = true;
            btnSalva.Click += btnSalva_Click;
            // 
            // LibriForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 239);
            Controls.Add(btnSalva);
            Controls.Add(chkDisponibile);
            Controls.Add(txtISBN);
            Controls.Add(label3);
            Controls.Add(txtAutore);
            Controls.Add(label2);
            Controls.Add(txtTitolo);
            Controls.Add(label1);
            Name = "LibriForm";
            Text = "LibriForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTitolo;
        private Label label2;
        private TextBox txtAutore;
        private Label label3;
        private TextBox txtISBN;
        private CheckBox chkDisponibile;
        private Button btnSalva;
    }
}
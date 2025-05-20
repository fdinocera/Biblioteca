namespace Biblioteca.UI.Forms
{
    partial class PrestitoForm
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
            textBox1 = new TextBox();
            label2 = new Label();
            labelTitolo = new Label();
            label3 = new Label();
            labelAutore = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 97);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Isbn libro";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 57);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "Titolo";
            // 
            // labelTitolo
            // 
            labelTitolo.AutoSize = true;
            labelTitolo.Location = new Point(121, 57);
            labelTitolo.Name = "labelTitolo";
            labelTitolo.Size = new Size(38, 15);
            labelTitolo.TabIndex = 3;
            labelTitolo.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 76);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Autore";
            // 
            // labelAutore
            // 
            labelAutore.AutoSize = true;
            labelAutore.Location = new Point(121, 76);
            labelAutore.Name = "labelAutore";
            labelAutore.Size = new Size(38, 15);
            labelAutore.TabIndex = 5;
            labelAutore.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 97);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 6;
            label4.Text = "email utente";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(328, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(246, 57);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 8;
            label5.Text = "Nome utente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(329, 57);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 9;
            label6.Text = "label6";
            // 
            // button1
            // 
            button1.Location = new Point(538, 24);
            button1.Name = "button1";
            button1.Size = new Size(91, 35);
            button1.TabIndex = 10;
            button1.Text = "Prestito";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PrestitoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 287);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(labelAutore);
            Controls.Add(label3);
            Controls.Add(labelTitolo);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "PrestitoForm";
            Text = "PrestitiForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label labelTitolo;
        private Label label3;
        private Label labelAutore;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private Button button1;
    }
}
namespace Agente
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
            Agente = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // Agente
            // 
            Agente.BackColor = SystemColors.ActiveCaption;
            Agente.ForeColor = Color.Red;
            Agente.Location = new Point(113, 33);
            Agente.Name = "Agente";
            Agente.Size = new Size(152, 54);
            Agente.TabIndex = 0;
            Agente.Text = "Buscar Rep";
            Agente.UseVisualStyleBackColor = false;
            Agente.Click += Agente_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(480, 196);
            dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.ForeColor = Color.Coral;
            button1.Location = new Point(708, 33);
            button1.Name = "button1";
            button1.Size = new Size(156, 54);
            button1.TabIndex = 2;
            button1.Text = "Buscar Carro";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(532, 121);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(458, 196);
            dataGridView2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1002, 450);
            Controls.Add(dataGridView2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(Agente);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Agente;
        private DataGridView dataGridView1;
        private Button button1;
        private DataGridView dataGridView2;
    }
}

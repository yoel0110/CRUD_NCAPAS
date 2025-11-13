namespace PresentationLayer
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            txtDesc = new TextBox();
            txtMarca = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 45;
            dataGridView1.Size = new Size(669, 484);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(22, 514);
            button1.Name = "button1";
            button1.Size = new Size(180, 56);
            button1.TabIndex = 1;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(226, 514);
            button2.Name = "button2";
            button2.Size = new Size(180, 56);
            button2.TabIndex = 2;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18.3396225F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(750, 37);
            label1.Name = "label1";
            label1.Size = new Size(128, 37);
            label1.TabIndex = 3;
            label1.Text = "Nombre: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18.3396225F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(719, 97);
            label2.Name = "label2";
            label2.Size = new Size(161, 37);
            label2.TabIndex = 4;
            label2.Text = "Descripcion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18.3396225F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(775, 154);
            label3.Name = "label3";
            label3.Size = new Size(103, 37);
            label3.TabIndex = 5;
            label3.Text = "Marca: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18.3396225F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(775, 208);
            label4.Name = "label4";
            label4.Size = new Size(96, 37);
            label4.TabIndex = 6;
            label4.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18.3396225F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(785, 270);
            label5.Name = "label5";
            label5.Size = new Size(86, 37);
            label5.TabIndex = 7;
            label5.Text = "Stock:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(884, 37);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(279, 37);
            txtNombre.TabIndex = 8;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(884, 97);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(279, 37);
            txtDesc.TabIndex = 9;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(884, 154);
            txtMarca.Multiline = true;
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(279, 37);
            txtMarca.TabIndex = 10;
            txtMarca.TextChanged += textBox3_TextChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(884, 208);
            txtPrecio.Multiline = true;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(279, 37);
            txtPrecio.TabIndex = 11;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(884, 270);
            txtStock.Multiline = true;
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(279, 37);
            txtStock.TabIndex = 12;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(921, 343);
            button3.Name = "button3";
            button3.Size = new Size(220, 61);
            button3.TabIndex = 13;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 594);
            Controls.Add(button3);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtMarca);
            Controls.Add(txtDesc);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtDesc;
        private TextBox txtMarca;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Button button3;
    }
}

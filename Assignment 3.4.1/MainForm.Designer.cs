namespace Assignment_3._4._1
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.dataGridViewCoffee = new System.Windows.Forms.DataGridView();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.buttonFufillOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoffee)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Bisque;
            this.labelTitle.Font = new System.Drawing.Font("Modern No. 20", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(401, 26);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(265, 45);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Coffee Orders";
            // 
            // dataGridViewCoffee
            // 
            this.dataGridViewCoffee.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridViewCoffee.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridViewCoffee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoffee.Location = new System.Drawing.Point(69, 99);
            this.dataGridViewCoffee.Name = "dataGridViewCoffee";
            this.dataGridViewCoffee.RowHeadersWidth = 51;
            this.dataGridViewCoffee.RowTemplate.Height = 24;
            this.dataGridViewCoffee.Size = new System.Drawing.Size(959, 318);
            this.dataGridViewCoffee.TabIndex = 1;
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.BackColor = System.Drawing.Color.Bisque;
            this.buttonAddOrder.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddOrder.Location = new System.Drawing.Point(189, 487);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(264, 96);
            this.buttonAddOrder.TabIndex = 2;
            this.buttonAddOrder.Text = "Add Order";
            this.buttonAddOrder.UseVisualStyleBackColor = false;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // buttonFufillOrder
            // 
            this.buttonFufillOrder.BackColor = System.Drawing.Color.Bisque;
            this.buttonFufillOrder.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFufillOrder.Location = new System.Drawing.Point(664, 487);
            this.buttonFufillOrder.Name = "buttonFufillOrder";
            this.buttonFufillOrder.Size = new System.Drawing.Size(264, 96);
            this.buttonFufillOrder.TabIndex = 3;
            this.buttonFufillOrder.Text = "Fufill Order";
            this.buttonFufillOrder.UseVisualStyleBackColor = false;
            this.buttonFufillOrder.Click += new System.EventHandler(this.buttonFufillOrder_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment_3._4._1.Properties.Resources.coffeeMenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1081, 666);
            this.Controls.Add(this.buttonFufillOrder);
            this.Controls.Add(this.buttonAddOrder);
            this.Controls.Add(this.dataGridViewCoffee);
            this.Controls.Add(this.labelTitle);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Coffee Orders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoffee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridViewCoffee;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.Button buttonFufillOrder;
    }
}


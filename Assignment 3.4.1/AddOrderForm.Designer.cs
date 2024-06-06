namespace Assignment_3._4._1
{
    partial class AddOrderForm
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
            this.labelAddOrdTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.comboBoxTemp = new System.Windows.Forms.ComboBox();
            this.comboBoxCoffeeType = new System.Windows.Forms.ComboBox();
            this.buttonSubmitOrder = new System.Windows.Forms.Button();
            this.buttonBackToHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddOrdTitle
            // 
            this.labelAddOrdTitle.AutoSize = true;
            this.labelAddOrdTitle.BackColor = System.Drawing.Color.Bisque;
            this.labelAddOrdTitle.Font = new System.Drawing.Font("Modern No. 20", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddOrdTitle.Location = new System.Drawing.Point(433, 30);
            this.labelAddOrdTitle.Name = "labelAddOrdTitle";
            this.labelAddOrdTitle.Size = new System.Drawing.Size(216, 45);
            this.labelAddOrdTitle.TabIndex = 1;
            this.labelAddOrdTitle.Text = "Add Order";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Bisque;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tempeture:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Bisque;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Coffee Type:";
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Location = new System.Drawing.Point(569, 182);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(186, 37);
            this.comboBoxSize.TabIndex = 5;
            // 
            // comboBoxTemp
            // 
            this.comboBoxTemp.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTemp.FormattingEnabled = true;
            this.comboBoxTemp.Location = new System.Drawing.Point(569, 279);
            this.comboBoxTemp.Name = "comboBoxTemp";
            this.comboBoxTemp.Size = new System.Drawing.Size(186, 37);
            this.comboBoxTemp.TabIndex = 6;
            // 
            // comboBoxCoffeeType
            // 
            this.comboBoxCoffeeType.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCoffeeType.FormattingEnabled = true;
            this.comboBoxCoffeeType.Location = new System.Drawing.Point(569, 383);
            this.comboBoxCoffeeType.Name = "comboBoxCoffeeType";
            this.comboBoxCoffeeType.Size = new System.Drawing.Size(186, 37);
            this.comboBoxCoffeeType.TabIndex = 7;
            // 
            // buttonSubmitOrder
            // 
            this.buttonSubmitOrder.BackColor = System.Drawing.Color.Bisque;
            this.buttonSubmitOrder.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold);
            this.buttonSubmitOrder.Location = new System.Drawing.Point(473, 498);
            this.buttonSubmitOrder.Name = "buttonSubmitOrder";
            this.buttonSubmitOrder.Size = new System.Drawing.Size(161, 53);
            this.buttonSubmitOrder.TabIndex = 8;
            this.buttonSubmitOrder.Text = "Order";
            this.buttonSubmitOrder.UseVisualStyleBackColor = false;
            this.buttonSubmitOrder.Click += new System.EventHandler(this.buttonSubmitOrder_Click);
            // 
            // buttonBackToHome
            // 
            this.buttonBackToHome.BackColor = System.Drawing.Color.Bisque;
            this.buttonBackToHome.Font = new System.Drawing.Font("Modern No. 20", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackToHome.Location = new System.Drawing.Point(31, 30);
            this.buttonBackToHome.Name = "buttonBackToHome";
            this.buttonBackToHome.Size = new System.Drawing.Size(72, 68);
            this.buttonBackToHome.TabIndex = 9;
            this.buttonBackToHome.Text = "🔙";
            this.buttonBackToHome.UseVisualStyleBackColor = false;
            this.buttonBackToHome.Click += new System.EventHandler(this.buttonBackToHome_Click);
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment_3._4._1.Properties.Resources.coffeeMenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 648);
            this.Controls.Add(this.buttonBackToHome);
            this.Controls.Add(this.buttonSubmitOrder);
            this.Controls.Add(this.comboBoxCoffeeType);
            this.Controls.Add(this.comboBoxTemp);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAddOrdTitle);
            this.DoubleBuffered = true;
            this.Name = "AddOrderForm";
            this.Text = "Add Orders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddOrdTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.ComboBox comboBoxTemp;
        private System.Windows.Forms.ComboBox comboBoxCoffeeType;
        private System.Windows.Forms.Button buttonSubmitOrder;
        private System.Windows.Forms.Button buttonBackToHome;
    }
}
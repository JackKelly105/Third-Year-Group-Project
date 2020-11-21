﻿namespace BloomFeildHotel
{
    partial class formSales
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCreateReservation = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnSubtotal = new System.Windows.Forms.Button();
            this.lblAddDrink = new System.Windows.Forms.Label();
            this.AddFood = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblManagerMenuTag = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(37)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblCreateReservation);
            this.panel1.Location = new System.Drawing.Point(-3, -14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1273, 68);
            this.panel1.TabIndex = 24;
            // 
            // lblCreateReservation
            // 
            this.lblCreateReservation.AutoSize = true;
            this.lblCreateReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateReservation.ForeColor = System.Drawing.Color.White;
            this.lblCreateReservation.Location = new System.Drawing.Point(3, 21);
            this.lblCreateReservation.Name = "lblCreateReservation";
            this.lblCreateReservation.Size = new System.Drawing.Size(86, 39);
            this.lblCreateReservation.TabIndex = 0;
            this.lblCreateReservation.Text = "Sale";
            this.lblCreateReservation.Click += new System.EventHandler(this.lblCreateReservation_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(377, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(579, 377);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnPayment
            // 
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(568, 512);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(177, 88);
            this.btnPayment.TabIndex = 36;
            this.btnPayment.Text = "Select Payment Type";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnSubtotal
            // 
            this.btnSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtotal.Location = new System.Drawing.Point(377, 512);
            this.btnSubtotal.Name = "btnSubtotal";
            this.btnSubtotal.Size = new System.Drawing.Size(144, 80);
            this.btnSubtotal.TabIndex = 35;
            this.btnSubtotal.Text = "Calculate Subtotal";
            this.btnSubtotal.UseVisualStyleBackColor = true;
            this.btnSubtotal.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblAddDrink
            // 
            this.lblAddDrink.AutoSize = true;
            this.lblAddDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDrink.Location = new System.Drawing.Point(42, 229);
            this.lblAddDrink.Name = "lblAddDrink";
            this.lblAddDrink.Size = new System.Drawing.Size(79, 20);
            this.lblAddDrink.TabIndex = 29;
            this.lblAddDrink.Text = "Add Drink";
            this.lblAddDrink.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // AddFood
            // 
            this.AddFood.AutoSize = true;
            this.AddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFood.Location = new System.Drawing.Point(42, 105);
            this.AddFood.Name = "AddFood";
            this.AddFood.Size = new System.Drawing.Size(79, 20);
            this.AddFood.TabIndex = 25;
            this.AddFood.Text = "Add Food";
            this.AddFood.Click += new System.EventHandler(this.lxlFirstName_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(138, 105);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(183, 108);
            this.listBox1.TabIndex = 38;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(138, 229);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(183, 108);
            this.listBox2.TabIndex = 39;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(812, 512);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 88);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // lblManagerMenuTag
            // 
            this.lblManagerMenuTag.AutoSize = true;
            this.lblManagerMenuTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerMenuTag.Location = new System.Drawing.Point(598, 57);
            this.lblManagerMenuTag.Name = "lblManagerMenuTag";
            this.lblManagerMenuTag.Size = new System.Drawing.Size(124, 39);
            this.lblManagerMenuTag.TabIndex = 41;
            this.lblManagerMenuTag.Text = "Orders";
            // 
            // formSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 659);
            this.Controls.Add(this.lblManagerMenuTag);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnSubtotal);
            this.Controls.Add(this.lblAddDrink);
            this.Controls.Add(this.AddFood);
            this.Controls.Add(this.panel1);
            this.Name = "formSales";
            this.Text = "formSales";
            this.Load += new System.EventHandler(this.formSales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCreateReservation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnSubtotal;
        private System.Windows.Forms.Label lblAddDrink;
        private System.Windows.Forms.Label AddFood;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblManagerMenuTag;
    }
}
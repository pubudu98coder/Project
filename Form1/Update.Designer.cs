namespace GroceryItems_update
{
    partial class Update
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
            this.background_panel1 = new System.Windows.Forms.Panel();
            this.Table_panel1 = new System.Windows.Forms.Panel();
            this.Items_DataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.search_textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Update_panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Stock_textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Price_textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ItemName_textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemCode_textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Top_panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.background_panel1.SuspendLayout();
            this.Table_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Items_DataGridView1)).BeginInit();
            this.Update_panel2.SuspendLayout();
            this.Top_panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // background_panel1
            // 
            this.background_panel1.BackColor = System.Drawing.Color.White;
            this.background_panel1.Controls.Add(this.Table_panel1);
            this.background_panel1.Controls.Add(this.Update_panel2);
            this.background_panel1.Controls.Add(this.Top_panel1);
            this.background_panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background_panel1.Location = new System.Drawing.Point(0, 0);
            this.background_panel1.Name = "background_panel1";
            this.background_panel1.Size = new System.Drawing.Size(1100, 605);
            this.background_panel1.TabIndex = 1;
            // 
            // Table_panel1
            // 
            this.Table_panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Table_panel1.Controls.Add(this.Items_DataGridView1);
            this.Table_panel1.Controls.Add(this.label7);
            this.Table_panel1.Controls.Add(this.search_textBox1);
            this.Table_panel1.Controls.Add(this.label6);
            this.Table_panel1.Location = new System.Drawing.Point(12, 72);
            this.Table_panel1.Name = "Table_panel1";
            this.Table_panel1.Size = new System.Drawing.Size(704, 521);
            this.Table_panel1.TabIndex = 2;
            // 
            // Items_DataGridView1
            // 
            this.Items_DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Items_DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Items_DataGridView1.Location = new System.Drawing.Point(0, 70);
            this.Items_DataGridView1.Name = "Items_DataGridView1";
            this.Items_DataGridView1.RowHeadersWidth = 51;
            this.Items_DataGridView1.RowTemplate.Height = 24;
            this.Items_DataGridView1.Size = new System.Drawing.Size(704, 451);
            this.Items_DataGridView1.TabIndex = 4;
            this.Items_DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Items_DataGridView1_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(310, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Search Items";
            // 
            // search_textBox1
            // 
            this.search_textBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_textBox1.Location = new System.Drawing.Point(424, 22);
            this.search_textBox1.Name = "search_textBox1";
            this.search_textBox1.Size = new System.Drawing.Size(256, 30);
            this.search_textBox1.TabIndex = 2;
            this.search_textBox1.TextChanged += new System.EventHandler(this.search_textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Grocery Items List";
            // 
            // Update_panel2
            // 
            this.Update_panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Update_panel2.Controls.Add(this.btnBack);
            this.Update_panel2.Controls.Add(this.btnUpdate);
            this.Update_panel2.Controls.Add(this.btnClear);
            this.Update_panel2.Controls.Add(this.panel1);
            this.Update_panel2.Controls.Add(this.Stock_textBox4);
            this.Update_panel2.Controls.Add(this.label5);
            this.Update_panel2.Controls.Add(this.Price_textBox3);
            this.Update_panel2.Controls.Add(this.label4);
            this.Update_panel2.Controls.Add(this.ItemName_textBox2);
            this.Update_panel2.Controls.Add(this.label3);
            this.Update_panel2.Controls.Add(this.ItemCode_textBox1);
            this.Update_panel2.Controls.Add(this.label2);
            this.Update_panel2.Controls.Add(this.label1);
            this.Update_panel2.Location = new System.Drawing.Point(732, 72);
            this.Update_panel2.Name = "Update_panel2";
            this.Update_panel2.Size = new System.Drawing.Size(355, 513);
            this.Update_panel2.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(111, 460);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 36);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back To Main";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(206, 380);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 40);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(31, 380);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 40);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Location = new System.Drawing.Point(31, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 4);
            this.panel1.TabIndex = 11;
            // 
            // Stock_textBox4
            // 
            this.Stock_textBox4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock_textBox4.Location = new System.Drawing.Point(31, 322);
            this.Stock_textBox4.Name = "Stock_textBox4";
            this.Stock_textBox4.Size = new System.Drawing.Size(296, 30);
            this.Stock_textBox4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Stock  (Quntity)";
            // 
            // Price_textBox3
            // 
            this.Price_textBox3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_textBox3.Location = new System.Drawing.Point(31, 254);
            this.Price_textBox3.Name = "Price_textBox3";
            this.Price_textBox3.Size = new System.Drawing.Size(296, 30);
            this.Price_textBox3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // ItemName_textBox2
            // 
            this.ItemName_textBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName_textBox2.Location = new System.Drawing.Point(31, 182);
            this.ItemName_textBox2.Name = "ItemName_textBox2";
            this.ItemName_textBox2.Size = new System.Drawing.Size(296, 30);
            this.ItemName_textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item Name";
            // 
            // ItemCode_textBox1
            // 
            this.ItemCode_textBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCode_textBox1.Location = new System.Drawing.Point(31, 113);
            this.ItemCode_textBox1.Name = "ItemCode_textBox1";
            this.ItemCode_textBox1.Size = new System.Drawing.Size(296, 30);
            this.ItemCode_textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update The Selected Item Details";
            // 
            // Top_panel1
            // 
            this.Top_panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.Top_panel1.Controls.Add(this.label10);
            this.Top_panel1.Controls.Add(this.label9);
            this.Top_panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_panel1.Location = new System.Drawing.Point(0, 0);
            this.Top_panel1.Name = "Top_panel1";
            this.Top_panel1.Size = new System.Drawing.Size(1100, 51);
            this.Top_panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 31);
            this.label10.TabIndex = 6;
            this.label10.Text = "Grocery Shop";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(177, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(262, 28);
            this.label9.TabIndex = 1;
            this.label9.Text = "Update Inventy Items Details";
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 605);
            this.Controls.Add(this.background_panel1);
            this.Name = "Update";
            this.Text = "Update";
            this.background_panel1.ResumeLayout(false);
            this.Table_panel1.ResumeLayout(false);
            this.Table_panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Items_DataGridView1)).EndInit();
            this.Update_panel2.ResumeLayout(false);
            this.Update_panel2.PerformLayout();
            this.Top_panel1.ResumeLayout(false);
            this.Top_panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background_panel1;
        private System.Windows.Forms.Panel Table_panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox search_textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel Update_panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Stock_textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Price_textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ItemName_textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ItemCode_textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Top_panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView Items_DataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label10;
    }
}
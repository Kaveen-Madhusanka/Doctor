namespace Doctor
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MedicineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicine_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacture_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expire_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insert = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMeID = new System.Windows.Forms.TextBox();
            this.txtMeNem = new System.Windows.Forms.TextBox();
            this.txtQnty = new System.Windows.Forms.TextBox();
            this.txtMnfDt = new System.Windows.Forms.TextBox();
            this.txtExDat = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stock ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicineID,
            this.Medicine_name,
            this.Quntity,
            this.Manufacture_Date,
            this.Expire_date});
            this.dataGridView1.Location = new System.Drawing.Point(364, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 398);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // MedicineID
            // 
            this.MedicineID.HeaderText = "MedicineID";
            this.MedicineID.Name = "MedicineID";
            this.MedicineID.ReadOnly = true;
            // 
            // Medicine_name
            // 
            this.Medicine_name.HeaderText = "Medicine_name";
            this.Medicine_name.Name = "Medicine_name";
            this.Medicine_name.ReadOnly = true;
            // 
            // Quntity
            // 
            this.Quntity.HeaderText = "Quntity";
            this.Quntity.Name = "Quntity";
            this.Quntity.ReadOnly = true;
            // 
            // Manufacture_Date
            // 
            this.Manufacture_Date.HeaderText = "Manufacture_Date";
            this.Manufacture_Date.Name = "Manufacture_Date";
            this.Manufacture_Date.ReadOnly = true;
            // 
            // Expire_date
            // 
            this.Expire_date.HeaderText = "Expire_date";
            this.Expire_date.Name = "Expire_date";
            this.Expire_date.ReadOnly = true;
            // 
            // insert
            // 
            this.insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.Location = new System.Drawing.Point(46, 327);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(111, 42);
            this.insert.TabIndex = 28;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(210, 327);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(111, 42);
            this.update.TabIndex = 29;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(116, 403);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(111, 42);
            this.delete.TabIndex = 30;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "MedicineID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Medicine Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Quntity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Manufacture Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Expire Date";
            // 
            // txtMeID
            // 
            this.txtMeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeID.Location = new System.Drawing.Point(189, 71);
            this.txtMeID.Name = "txtMeID";
            this.txtMeID.Size = new System.Drawing.Size(149, 26);
            this.txtMeID.TabIndex = 36;
            // 
            // txtMeNem
            // 
            this.txtMeNem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeNem.Location = new System.Drawing.Point(189, 113);
            this.txtMeNem.Name = "txtMeNem";
            this.txtMeNem.Size = new System.Drawing.Size(149, 26);
            this.txtMeNem.TabIndex = 37;
            // 
            // txtQnty
            // 
            this.txtQnty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQnty.Location = new System.Drawing.Point(189, 155);
            this.txtQnty.Name = "txtQnty";
            this.txtQnty.Size = new System.Drawing.Size(149, 26);
            this.txtQnty.TabIndex = 38;
            // 
            // txtMnfDt
            // 
            this.txtMnfDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMnfDt.Location = new System.Drawing.Point(189, 197);
            this.txtMnfDt.Name = "txtMnfDt";
            this.txtMnfDt.Size = new System.Drawing.Size(149, 26);
            this.txtMnfDt.TabIndex = 39;
            // 
            // txtExDat
            // 
            this.txtExDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExDat.Location = new System.Drawing.Point(189, 241);
            this.txtExDat.Name = "txtExDat";
            this.txtExDat.Size = new System.Drawing.Size(149, 26);
            this.txtExDat.TabIndex = 40;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(18, 10);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(111, 42);
            this.btnHome.TabIndex = 41;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 522);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.txtExDat);
            this.Controls.Add(this.txtMnfDt);
            this.Controls.Add(this.txtQnty);
            this.Controls.Add(this.txtMeNem);
            this.Controls.Add(this.txtMeID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "Bill";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMeID;
        private System.Windows.Forms.TextBox txtMeNem;
        private System.Windows.Forms.TextBox txtQnty;
        private System.Windows.Forms.TextBox txtMnfDt;
        private System.Windows.Forms.TextBox txtExDat;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicine_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacture_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expire_date;
    }
}
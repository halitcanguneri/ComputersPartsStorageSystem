namespace ComputerPartsSQL
{
    partial class ShowMonitor
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
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(429, 487);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 43);
            this.button2.TabIndex = 79;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Write ProductID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(411, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 77;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 49);
            this.button1.TabIndex = 76;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(905, 120);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "All Monitors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "All Keyboards Filter";
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Location = new System.Drawing.Point(12, 346);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.Size = new System.Drawing.Size(905, 106);
            this.advancedDataGridView1.TabIndex = 81;
            this.advancedDataGridView1.TimeFilter = false;
            this.advancedDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advancedDataGridView1_CellContentClick);
            // 
            // ShowMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 577);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ShowMonitor";
            this.Text = "ShowMonitor";
            this.Load += new System.EventHandler(this.ShowMonitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
    }
}
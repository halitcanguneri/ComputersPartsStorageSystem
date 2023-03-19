namespace ComputerPartsSQL
{
    partial class ShowCPUForUsers
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
            this.label3 = new System.Windows.Forms.Label();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 93;
            this.label3.Text = "All CPUs Filter";
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Location = new System.Drawing.Point(12, 275);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.Size = new System.Drawing.Size(1039, 131);
            this.advancedDataGridView1.TabIndex = 92;
            this.advancedDataGridView1.TimeFilter = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(515, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 44);
            this.button2.TabIndex = 90;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1039, 142);
            this.dataGridView1.TabIndex = 89;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ShowCPUForUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 494);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowCPUForUsers";
            this.Text = "ShowCPUForUsers";
            this.Load += new System.EventHandler(this.ShowCPUForUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
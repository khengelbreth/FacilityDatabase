namespace FacilityDatabase
{
    partial class Form1
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
            this.Search = new System.Windows.Forms.Label();
            this.FacilityNo = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxFacilityNo = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.Search.Location = new System.Drawing.Point(535, 122);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(304, 38);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search FacilityNo:";
            // 
            // FacilityNo
            // 
            this.FacilityNo.AutoSize = true;
            this.FacilityNo.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.FacilityNo.Location = new System.Drawing.Point(84, 301);
            this.FacilityNo.Name = "FacilityNo";
            this.FacilityNo.Size = new System.Drawing.Size(173, 38);
            this.FacilityNo.TabIndex = 1;
            this.FacilityNo.Text = "FacilityNo";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.Type.Location = new System.Drawing.Point(84, 418);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(203, 38);
            this.Type.TabIndex = 2;
            this.Type.Text = "Name/Type";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.textBoxSearch.Location = new System.Drawing.Point(861, 119);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(448, 45);
            this.textBoxSearch.TabIndex = 3;
            // 
            // textBoxFacilityNo
            // 
            this.textBoxFacilityNo.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.textBoxFacilityNo.Location = new System.Drawing.Point(337, 301);
            this.textBoxFacilityNo.Name = "textBoxFacilityNo";
            this.textBoxFacilityNo.Size = new System.Drawing.Size(330, 45);
            this.textBoxFacilityNo.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.textBoxName.Location = new System.Drawing.Point(337, 418);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(330, 45);
            this.textBoxName.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Orange;
            this.textBox4.Font = new System.Drawing.Font("MS UI Gothic", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(12, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(1444, 66);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "Facility Database";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(726, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(715, 461);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Update.Location = new System.Drawing.Point(91, 529);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(137, 51);
            this.Update.TabIndex = 8;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Delete.Location = new System.Drawing.Point(291, 529);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(127, 52);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Insert
            // 
            this.Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Insert.Location = new System.Drawing.Point(473, 528);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(194, 52);
            this.Insert.TabIndex = 10;
            this.Insert.Text = "Create/Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Show
            // 
            this.Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Show.Location = new System.Drawing.Point(726, 690);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(153, 45);
            this.Show.TabIndex = 11;
            this.Show.Text = "Show All";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Exit.Location = new System.Drawing.Point(1308, 690);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(133, 45);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSearch.Location = new System.Drawing.Point(1315, 119);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(126, 45);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 771);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxFacilityNo);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.FacilityNo);
            this.Controls.Add(this.Search);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Label FacilityNo;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxFacilityNo;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button buttonSearch;
    }
}


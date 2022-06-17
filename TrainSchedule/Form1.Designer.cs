namespace TrainSchedule
{
    partial class TrainSchedule
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
            this.passengers = new System.Windows.Forms.ListBox();
            this.Add_pass = new System.Windows.Forms.Button();
            this.Delete_pass = new System.Windows.Forms.Button();
            this.Update_pass = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // passengers
            // 
            this.passengers.FormattingEnabled = true;
            this.passengers.HorizontalScrollbar = true;
            this.passengers.ItemHeight = 15;
            this.passengers.Location = new System.Drawing.Point(12, 12);
            this.passengers.Name = "passengers";
            this.passengers.Size = new System.Drawing.Size(371, 199);
            this.passengers.TabIndex = 0;
            this.passengers.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Add_pass
            // 
            this.Add_pass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add_pass.Location = new System.Drawing.Point(3, 3);
            this.Add_pass.Name = "Add_pass";
            this.Add_pass.Size = new System.Drawing.Size(118, 22);
            this.Add_pass.TabIndex = 1;
            this.Add_pass.Text = "Добавить";
            this.Add_pass.UseVisualStyleBackColor = true;
            this.Add_pass.Click += new System.EventHandler(this.Add_pass_Click);
            // 
            // Delete_pass
            // 
            this.Delete_pass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Delete_pass.Location = new System.Drawing.Point(127, 3);
            this.Delete_pass.Name = "Delete_pass";
            this.Delete_pass.Size = new System.Drawing.Size(117, 22);
            this.Delete_pass.TabIndex = 2;
            this.Delete_pass.Text = "Удалить";
            this.Delete_pass.UseVisualStyleBackColor = true;
            this.Delete_pass.Click += new System.EventHandler(this.Delete_pass_Click);
            // 
            // Update_pass
            // 
            this.Update_pass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Update_pass.Location = new System.Drawing.Point(250, 3);
            this.Update_pass.Name = "Update_pass";
            this.Update_pass.Size = new System.Drawing.Size(118, 22);
            this.Update_pass.TabIndex = 3;
            this.Update_pass.Text = "Редактировать";
            this.Update_pass.UseVisualStyleBackColor = true;
            this.Update_pass.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.20921F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.79079F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.Controls.Add(this.Add_pass, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Update_pass, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Delete_pass, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 217);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(371, 28);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // TrainSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.passengers);
            this.Name = "TrainSchedule";
            this.Text = "Train Schedule";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox passengers;
        private Button Add_pass;
        private Button Delete_pass;
        private Button Update_pass;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
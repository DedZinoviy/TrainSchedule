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
            this.Add_pass.Location = new System.Drawing.Point(12, 217);
            this.Add_pass.Name = "Add_pass";
            this.Add_pass.Size = new System.Drawing.Size(75, 23);
            this.Add_pass.TabIndex = 1;
            this.Add_pass.Text = "Добавить";
            this.Add_pass.UseVisualStyleBackColor = true;
            this.Add_pass.Click += new System.EventHandler(this.Add_pass_Click);
            // 
            // Delete_pass
            // 
            this.Delete_pass.Location = new System.Drawing.Point(93, 217);
            this.Delete_pass.Name = "Delete_pass";
            this.Delete_pass.Size = new System.Drawing.Size(75, 23);
            this.Delete_pass.TabIndex = 2;
            this.Delete_pass.Text = "Удалить";
            this.Delete_pass.UseVisualStyleBackColor = true;
            this.Delete_pass.Click += new System.EventHandler(this.Delete_pass_Click);
            // 
            // Update_pass
            // 
            this.Update_pass.Location = new System.Drawing.Point(174, 217);
            this.Update_pass.Name = "Update_pass";
            this.Update_pass.Size = new System.Drawing.Size(99, 23);
            this.Update_pass.TabIndex = 3;
            this.Update_pass.Text = "Редактировать";
            this.Update_pass.UseVisualStyleBackColor = true;
            this.Update_pass.Click += new System.EventHandler(this.button1_Click);
            // 
            // TrainSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Update_pass);
            this.Controls.Add(this.Delete_pass);
            this.Controls.Add(this.Add_pass);
            this.Controls.Add(this.passengers);
            this.Name = "TrainSchedule";
            this.Text = "Train Schedule";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox passengers;
        private Button Add_pass;
        private Button Delete_pass;
        private Button Update_pass;
    }
}
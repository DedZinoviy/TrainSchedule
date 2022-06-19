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
            this.Add_pass = new System.Windows.Forms.Button();
            this.Delete_pass = new System.Windows.Forms.Button();
            this.Update_pass = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.passengers = new System.Windows.Forms.DataGridView();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contacts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passengers)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add_pass
            // 
            this.Add_pass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add_pass.Location = new System.Drawing.Point(3, 3);
            this.Add_pass.Name = "Add_pass";
            this.Add_pass.Size = new System.Drawing.Size(142, 29);
            this.Add_pass.TabIndex = 1;
            this.Add_pass.Text = "Добавить";
            this.Add_pass.UseVisualStyleBackColor = true;
            this.Add_pass.Click += new System.EventHandler(this.Add_pass_Click);
            // 
            // Delete_pass
            // 
            this.Delete_pass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Delete_pass.Location = new System.Drawing.Point(151, 3);
            this.Delete_pass.Name = "Delete_pass";
            this.Delete_pass.Size = new System.Drawing.Size(173, 29);
            this.Delete_pass.TabIndex = 2;
            this.Delete_pass.Text = "Удалить";
            this.Delete_pass.UseVisualStyleBackColor = true;
            this.Delete_pass.Click += new System.EventHandler(this.Delete_pass_Click);
            // 
            // Update_pass
            // 
            this.Update_pass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Update_pass.Location = new System.Drawing.Point(330, 3);
            this.Update_pass.Name = "Update_pass";
            this.Update_pass.Size = new System.Drawing.Size(153, 29);
            this.Update_pass.TabIndex = 3;
            this.Update_pass.Text = "Редактировать";
            this.Update_pass.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.15419F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.84581F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel1.Controls.Add(this.Add_pass, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Update_pass, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Delete_pass, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 205);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(486, 35);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // passengers
            // 
            this.passengers.AllowUserToAddRows = false;
            this.passengers.AllowUserToDeleteRows = false;
            this.passengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passengers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.last_name,
            this.first_name,
            this.patronim,
            this.contacts,
            this.id});
            this.passengers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passengers.Location = new System.Drawing.Point(3, 2);
            this.passengers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passengers.MultiSelect = false;
            this.passengers.Name = "passengers";
            this.passengers.RowHeadersVisible = false;
            this.passengers.RowHeadersWidth = 51;
            this.passengers.RowTemplate.Height = 29;
            this.passengers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.passengers.Size = new System.Drawing.Size(486, 198);
            this.passengers.TabIndex = 5;
            this.passengers.SelectionChanged += new System.EventHandler(this.passengers_SelectionChanged);
            // 
            // last_name
            // 
            this.last_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.last_name.HeaderText = "Фамилия";
            this.last_name.MinimumWidth = 6;
            this.last_name.Name = "last_name";
            // 
            // first_name
            // 
            this.first_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.first_name.HeaderText = "Имя";
            this.first_name.MinimumWidth = 6;
            this.first_name.Name = "first_name";
            // 
            // patronim
            // 
            this.patronim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.patronim.HeaderText = "Отчество";
            this.patronim.MinimumWidth = 6;
            this.patronim.Name = "patronim";
            // 
            // contacts
            // 
            this.contacts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contacts.HeaderText = "Контакты";
            this.contacts.MinimumWidth = 6;
            this.contacts.Name = "contacts";
            // 
            // id
            // 
            this.id.HeaderText = "";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.passengers, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(158, 94);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(492, 243);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // TrainSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "TrainSchedule";
            this.Text = "Train Schedule";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.passengers)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button Add_pass;
        private Button Delete_pass;
        private Button Update_pass;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView passengers;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridViewTextBoxColumn last_name;
        private DataGridViewTextBoxColumn first_name;
        private DataGridViewTextBoxColumn patronim;
        private DataGridViewTextBoxColumn contacts;
        private DataGridViewTextBoxColumn id;
    }
}
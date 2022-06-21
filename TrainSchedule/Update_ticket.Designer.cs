namespace TrainSchedule
{
    partial class Update_ticket
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cost_label = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.NumericUpDown();
            this.places = new System.Windows.Forms.DataGridView();
            this.placeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wagons = new System.Windows.Forms.DataGridView();
            this.wagonNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trains = new System.Windows.Forms.DataGridView();
            this.trainNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Save_btn = new System.Windows.Forms.Button();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.PlacesCountLabel = new System.Windows.Forms.Label();
            this.PlacesCount = new System.Windows.Forms.TextBox();
            this.WagonCountLabel = new System.Windows.Forms.Label();
            this.WagonsCount = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.places)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wagons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trains)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cost_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cost, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(591, 173);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(158, 51);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // cost_label
            // 
            this.cost_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cost_label.AutoSize = true;
            this.cost_label.Location = new System.Drawing.Point(61, 5);
            this.cost_label.Name = "cost_label";
            this.cost_label.Size = new System.Drawing.Size(35, 15);
            this.cost_label.TabIndex = 6;
            this.cost_label.Text = "Цена";
            // 
            // cost
            // 
            this.cost.DecimalPlaces = 2;
            this.cost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cost.Location = new System.Drawing.Point(3, 28);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(152, 23);
            this.cost.TabIndex = 5;
            // 
            // places
            // 
            this.places.AllowUserToAddRows = false;
            this.places.AllowUserToDeleteRows = false;
            this.places.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.places.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.placeNumber,
            this.placeId});
            this.places.Location = new System.Drawing.Point(326, 50);
            this.places.Name = "places";
            this.places.ReadOnly = true;
            this.places.RowHeadersVisible = false;
            this.places.RowTemplate.Height = 25;
            this.places.Size = new System.Drawing.Size(94, 150);
            this.places.TabIndex = 12;
            // 
            // placeNumber
            // 
            this.placeNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.placeNumber.HeaderText = "Место";
            this.placeNumber.Name = "placeNumber";
            this.placeNumber.ReadOnly = true;
            // 
            // placeId
            // 
            this.placeId.HeaderText = "";
            this.placeId.Name = "placeId";
            this.placeId.ReadOnly = true;
            this.placeId.Visible = false;
            // 
            // wagons
            // 
            this.wagons.AllowUserToAddRows = false;
            this.wagons.AllowUserToDeleteRows = false;
            this.wagons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wagons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wagonNumber,
            this.id});
            this.wagons.Location = new System.Drawing.Point(209, 50);
            this.wagons.Name = "wagons";
            this.wagons.ReadOnly = true;
            this.wagons.RowHeadersVisible = false;
            this.wagons.RowTemplate.Height = 25;
            this.wagons.Size = new System.Drawing.Size(111, 150);
            this.wagons.TabIndex = 11;
            this.wagons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.wagons_CellClick);
            // 
            // wagonNumber
            // 
            this.wagonNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.wagonNumber.HeaderText = "Номер вагона";
            this.wagonNumber.Name = "wagonNumber";
            this.wagonNumber.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // trains
            // 
            this.trains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trains.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainNumber,
            this.trainId});
            this.trains.Location = new System.Drawing.Point(51, 50);
            this.trains.Name = "trains";
            this.trains.RowHeadersVisible = false;
            this.trains.RowTemplate.Height = 25;
            this.trains.Size = new System.Drawing.Size(152, 150);
            this.trains.TabIndex = 10;
            this.trains.SelectionChanged += new System.EventHandler(this.trains_SelectionChanged);
            // 
            // trainNumber
            // 
            this.trainNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trainNumber.HeaderText = "Номер поезда";
            this.trainNumber.Name = "trainNumber";
            this.trainNumber.ReadOnly = true;
            // 
            // trainId
            // 
            this.trainId.HeaderText = "";
            this.trainId.Name = "trainId";
            this.trainId.ReadOnly = true;
            this.trainId.Visible = false;
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(632, 365);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel_btn.TabIndex = 9;
            this.Cancel_btn.Text = "Отмена";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(443, 365);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(75, 23);
            this.Save_btn.TabIndex = 8;
            this.Save_btn.Text = "Сохранить";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // ShowBtn
            // 
            this.ShowBtn.Location = new System.Drawing.Point(71, 394);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(75, 23);
            this.ShowBtn.TabIndex = 18;
            this.ShowBtn.Text = "Показать";
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // PlacesCountLabel
            // 
            this.PlacesCountLabel.AutoSize = true;
            this.PlacesCountLabel.Location = new System.Drawing.Point(244, 347);
            this.PlacesCountLabel.Name = "PlacesCountLabel";
            this.PlacesCountLabel.Size = new System.Drawing.Size(101, 15);
            this.PlacesCountLabel.TabIndex = 17;
            this.PlacesCountLabel.Text = "Количество мест";
            // 
            // PlacesCount
            // 
            this.PlacesCount.Location = new System.Drawing.Point(244, 365);
            this.PlacesCount.Name = "PlacesCount";
            this.PlacesCount.ReadOnly = true;
            this.PlacesCount.Size = new System.Drawing.Size(100, 23);
            this.PlacesCount.TabIndex = 16;
            // 
            // WagonCountLabel
            // 
            this.WagonCountLabel.AutoSize = true;
            this.WagonCountLabel.Location = new System.Drawing.Point(71, 347);
            this.WagonCountLabel.Name = "WagonCountLabel";
            this.WagonCountLabel.Size = new System.Drawing.Size(119, 15);
            this.WagonCountLabel.TabIndex = 15;
            this.WagonCountLabel.Text = "Количество вагонов";
            // 
            // WagonsCount
            // 
            this.WagonsCount.Location = new System.Drawing.Point(71, 365);
            this.WagonsCount.Name = "WagonsCount";
            this.WagonsCount.ReadOnly = true;
            this.WagonsCount.Size = new System.Drawing.Size(100, 23);
            this.WagonsCount.TabIndex = 14;
            // 
            // Update_ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.PlacesCountLabel);
            this.Controls.Add(this.PlacesCount);
            this.Controls.Add(this.WagonCountLabel);
            this.Controls.Add(this.WagonsCount);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.places);
            this.Controls.Add(this.wagons);
            this.Controls.Add(this.trains);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Save_btn);
            this.Name = "Update_ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактировать билет...";
            this.Load += new System.EventHandler(this.Update_ticket_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.places)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wagons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trains)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label cost_label;
        private NumericUpDown cost;
        private DataGridView places;
        private DataGridViewTextBoxColumn placeNumber;
        private DataGridViewTextBoxColumn placeId;
        private DataGridView wagons;
        private DataGridViewTextBoxColumn wagonNumber;
        private DataGridViewTextBoxColumn id;
        private DataGridView trains;
        private DataGridViewTextBoxColumn trainNumber;
        private DataGridViewTextBoxColumn trainId;
        private Button Cancel_btn;
        private Button Save_btn;
        private Button ShowBtn;
        private Label PlacesCountLabel;
        private TextBox PlacesCount;
        private Label WagonCountLabel;
        private TextBox WagonsCount;
    }
}
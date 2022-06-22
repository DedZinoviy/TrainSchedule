namespace TrainSchedule
{
    partial class Add_ticket
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
            this.Save_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.trains = new System.Windows.Forms.DataGridView();
            this.trainNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wagons = new System.Windows.Forms.DataGridView();
            this.wagonNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.places = new System.Windows.Forms.DataGridView();
            this.placeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.NumericUpDown();
            this.cost_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.WagonsCount = new System.Windows.Forms.TextBox();
            this.WagonCountLabel = new System.Windows.Forms.Label();
            this.PlacesCount = new System.Windows.Forms.TextBox();
            this.PlacesCountLabel = new System.Windows.Forms.Label();
            this.ShowBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trains)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wagons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.places)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cost)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(104, 420);
            this.Save_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(86, 31);
            this.Save_btn.TabIndex = 0;
            this.Save_btn.Text = "Сохранить";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(702, 453);
            this.Cancel_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(86, 31);
            this.Cancel_btn.TabIndex = 1;
            this.Cancel_btn.Text = "Отмена";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // trains
            // 
            this.trains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trains.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainNumber,
            this.trainId});
            this.trains.Location = new System.Drawing.Point(37, 16);
            this.trains.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trains.Name = "trains";
            this.trains.RowHeadersVisible = false;
            this.trains.RowHeadersWidth = 51;
            this.trains.RowTemplate.Height = 25;
            this.trains.Size = new System.Drawing.Size(174, 200);
            this.trains.TabIndex = 2;
            this.trains.SelectionChanged += new System.EventHandler(this.trains_SelectionChanged);
            // 
            // trainNumber
            // 
            this.trainNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trainNumber.HeaderText = "Номер поезда";
            this.trainNumber.MinimumWidth = 6;
            this.trainNumber.Name = "trainNumber";
            this.trainNumber.ReadOnly = true;
            // 
            // trainId
            // 
            this.trainId.HeaderText = "";
            this.trainId.MinimumWidth = 6;
            this.trainId.Name = "trainId";
            this.trainId.ReadOnly = true;
            this.trainId.Visible = false;
            this.trainId.Width = 125;
            // 
            // wagons
            // 
            this.wagons.AllowUserToAddRows = false;
            this.wagons.AllowUserToDeleteRows = false;
            this.wagons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wagons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wagonNumber,
            this.id});
            this.wagons.Location = new System.Drawing.Point(217, 16);
            this.wagons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wagons.Name = "wagons";
            this.wagons.ReadOnly = true;
            this.wagons.RowHeadersVisible = false;
            this.wagons.RowHeadersWidth = 51;
            this.wagons.RowTemplate.Height = 25;
            this.wagons.Size = new System.Drawing.Size(127, 200);
            this.wagons.TabIndex = 3;
            this.wagons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.wagons_CellClick);
            // 
            // wagonNumber
            // 
            this.wagonNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.wagonNumber.HeaderText = "Номер вагона";
            this.wagonNumber.MinimumWidth = 6;
            this.wagonNumber.Name = "wagonNumber";
            this.wagonNumber.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // places
            // 
            this.places.AllowUserToAddRows = false;
            this.places.AllowUserToDeleteRows = false;
            this.places.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.places.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.placeNumber,
            this.placeId});
            this.places.Location = new System.Drawing.Point(351, 16);
            this.places.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.places.Name = "places";
            this.places.ReadOnly = true;
            this.places.RowHeadersVisible = false;
            this.places.RowHeadersWidth = 51;
            this.places.RowTemplate.Height = 25;
            this.places.Size = new System.Drawing.Size(107, 200);
            this.places.TabIndex = 4;
            // 
            // placeNumber
            // 
            this.placeNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.placeNumber.HeaderText = "Место";
            this.placeNumber.MinimumWidth = 6;
            this.placeNumber.Name = "placeNumber";
            this.placeNumber.ReadOnly = true;
            // 
            // placeId
            // 
            this.placeId.HeaderText = "";
            this.placeId.MinimumWidth = 6;
            this.placeId.Name = "placeId";
            this.placeId.ReadOnly = true;
            this.placeId.Visible = false;
            this.placeId.Width = 125;
            // 
            // cost
            // 
            this.cost.DecimalPlaces = 2;
            this.cost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cost.Location = new System.Drawing.Point(3, 38);
            this.cost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(175, 27);
            this.cost.TabIndex = 5;
            // 
            // cost_label
            // 
            this.cost_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cost_label.AutoSize = true;
            this.cost_label.Location = new System.Drawing.Point(68, 7);
            this.cost_label.Name = "cost_label";
            this.cost_label.Size = new System.Drawing.Size(45, 20);
            this.cost_label.TabIndex = 6;
            this.cost_label.Text = "Цена";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cost_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cost, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(654, 180);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(181, 68);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // WagonsCount
            // 
            this.WagonsCount.Location = new System.Drawing.Point(96, 501);
            this.WagonsCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WagonsCount.Name = "WagonsCount";
            this.WagonsCount.ReadOnly = true;
            this.WagonsCount.Size = new System.Drawing.Size(114, 27);
            this.WagonsCount.TabIndex = 8;
            // 
            // WagonCountLabel
            // 
            this.WagonCountLabel.AutoSize = true;
            this.WagonCountLabel.Location = new System.Drawing.Point(96, 477);
            this.WagonCountLabel.Name = "WagonCountLabel";
            this.WagonCountLabel.Size = new System.Drawing.Size(151, 20);
            this.WagonCountLabel.TabIndex = 9;
            this.WagonCountLabel.Text = "Количество вагонов";
            // 
            // PlacesCount
            // 
            this.PlacesCount.Location = new System.Drawing.Point(294, 501);
            this.PlacesCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlacesCount.Name = "PlacesCount";
            this.PlacesCount.ReadOnly = true;
            this.PlacesCount.Size = new System.Drawing.Size(114, 27);
            this.PlacesCount.TabIndex = 10;
            // 
            // PlacesCountLabel
            // 
            this.PlacesCountLabel.AutoSize = true;
            this.PlacesCountLabel.Location = new System.Drawing.Point(294, 477);
            this.PlacesCountLabel.Name = "PlacesCountLabel";
            this.PlacesCountLabel.Size = new System.Drawing.Size(126, 20);
            this.PlacesCountLabel.TabIndex = 11;
            this.PlacesCountLabel.Text = "Количество мест";
            // 
            // ShowBtn
            // 
            this.ShowBtn.Location = new System.Drawing.Point(96, 540);
            this.ShowBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(86, 31);
            this.ShowBtn.TabIndex = 12;
            this.ShowBtn.Text = "Показать";
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // Add_ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Add_ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить билет...";
            this.Load += new System.EventHandler(this.Add_ticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trains)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wagons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.places)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cost)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Save_btn;
        private Button Cancel_btn;
        private DataGridView trains;
        private DataGridViewTextBoxColumn trainNumber;
        private DataGridViewTextBoxColumn trainId;
        private DataGridView wagons;
        private DataGridViewTextBoxColumn wagonNumber;
        private DataGridViewTextBoxColumn id;
        private DataGridView places;
        private DataGridViewTextBoxColumn placeNumber;
        private DataGridViewTextBoxColumn placeId;
        private NumericUpDown cost;
        private Label cost_label;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox WagonsCount;
        private Label WagonCountLabel;
        private TextBox PlacesCount;
        private Label PlacesCountLabel;
        private Button ShowBtn;
    }
}
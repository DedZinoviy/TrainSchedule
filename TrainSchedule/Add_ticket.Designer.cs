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
            ((System.ComponentModel.ISupportInitialize)(this.trains)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wagons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.places)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cost)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(91, 315);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(75, 23);
            this.Save_btn.TabIndex = 0;
            this.Save_btn.Text = "Сохранить";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(614, 340);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(75, 23);
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
            this.trains.Location = new System.Drawing.Point(32, 12);
            this.trains.Name = "trains";
            this.trains.RowHeadersVisible = false;
            this.trains.RowTemplate.Height = 25;
            this.trains.Size = new System.Drawing.Size(152, 150);
            this.trains.TabIndex = 2;
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
            // wagons
            // 
            this.wagons.AllowUserToAddRows = false;
            this.wagons.AllowUserToDeleteRows = false;
            this.wagons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wagons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wagonNumber,
            this.id});
            this.wagons.Location = new System.Drawing.Point(190, 12);
            this.wagons.Name = "wagons";
            this.wagons.ReadOnly = true;
            this.wagons.RowHeadersVisible = false;
            this.wagons.RowTemplate.Height = 25;
            this.wagons.Size = new System.Drawing.Size(111, 150);
            this.wagons.TabIndex = 3;
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
            // places
            // 
            this.places.AllowUserToAddRows = false;
            this.places.AllowUserToDeleteRows = false;
            this.places.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.places.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.placeNumber,
            this.placeId});
            this.places.Location = new System.Drawing.Point(307, 12);
            this.places.Name = "places";
            this.places.ReadOnly = true;
            this.places.RowHeadersVisible = false;
            this.places.RowTemplate.Height = 25;
            this.places.Size = new System.Drawing.Size(94, 150);
            this.places.TabIndex = 4;
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
            // cost
            // 
            this.cost.DecimalPlaces = 2;
            this.cost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cost.Location = new System.Drawing.Point(3, 28);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(152, 23);
            this.cost.TabIndex = 5;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cost_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cost, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(572, 135);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(158, 51);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // Add_ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.places);
            this.Controls.Add(this.wagons);
            this.Controls.Add(this.trains);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Save_btn);
            this.Name = "Add_ticket";
            this.Text = "Добавить билет...";
            this.Load += new System.EventHandler(this.Add_ticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trains)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wagons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.places)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cost)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}
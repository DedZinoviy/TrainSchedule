﻿namespace TrainSchedule
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
            this.tickets = new System.Windows.Forms.DataGridView();
            this.trainNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOfDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOfArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteTicketBtn = new System.Windows.Forms.Button();
            this.Add_ticket_btn = new System.Windows.Forms.Button();
            this.updateTicketBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passengers)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tickets)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
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
            this.Update_pass.Click += new System.EventHandler(this.Update_pass_Click);
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
            this.passengers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 11);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(492, 243);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // tickets
            // 
            this.tickets.AllowUserToAddRows = false;
            this.tickets.AllowUserToDeleteRows = false;
            this.tickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainNumber,
            this.departure,
            this.timeOfDeparture,
            this.timeOfArrival,
            this.ticketId});
            this.tickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tickets.Location = new System.Drawing.Point(3, 3);
            this.tickets.Name = "tickets";
            this.tickets.ReadOnly = true;
            this.tickets.RowHeadersVisible = false;
            this.tickets.RowTemplate.Height = 25;
            this.tickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tickets.Size = new System.Drawing.Size(478, 196);
            this.tickets.TabIndex = 7;
            this.tickets.SelectionChanged += new System.EventHandler(this.tickets_SelectionChanged);
            // 
            // trainNumber
            // 
            this.trainNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trainNumber.HeaderText = "Номер поезда";
            this.trainNumber.Name = "trainNumber";
            this.trainNumber.ReadOnly = true;
            // 
            // departure
            // 
            this.departure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departure.HeaderText = "Населённый пункт";
            this.departure.Name = "departure";
            this.departure.ReadOnly = true;
            // 
            // timeOfDeparture
            // 
            this.timeOfDeparture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timeOfDeparture.HeaderText = "Время отправления";
            this.timeOfDeparture.Name = "timeOfDeparture";
            this.timeOfDeparture.ReadOnly = true;
            // 
            // timeOfArrival
            // 
            this.timeOfArrival.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timeOfArrival.HeaderText = "Время прибытия";
            this.timeOfArrival.Name = "timeOfArrival";
            this.timeOfArrival.ReadOnly = true;
            // 
            // ticketId
            // 
            this.ticketId.HeaderText = "";
            this.ticketId.Name = "ticketId";
            this.ticketId.ReadOnly = true;
            this.ticketId.Visible = false;
            // 
            // deleteTicketBtn
            // 
            this.deleteTicketBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteTicketBtn.Location = new System.Drawing.Point(147, 3);
            this.deleteTicketBtn.Name = "deleteTicketBtn";
            this.deleteTicketBtn.Size = new System.Drawing.Size(166, 29);
            this.deleteTicketBtn.TabIndex = 8;
            this.deleteTicketBtn.Text = "Удалить";
            this.deleteTicketBtn.UseVisualStyleBackColor = true;
            this.deleteTicketBtn.Click += new System.EventHandler(this.deleteTicketBtn_Click);
            // 
            // Add_ticket_btn
            // 
            this.Add_ticket_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add_ticket_btn.Location = new System.Drawing.Point(3, 3);
            this.Add_ticket_btn.Name = "Add_ticket_btn";
            this.Add_ticket_btn.Size = new System.Drawing.Size(138, 29);
            this.Add_ticket_btn.TabIndex = 9;
            this.Add_ticket_btn.Text = "Добавить";
            this.Add_ticket_btn.UseVisualStyleBackColor = true;
            this.Add_ticket_btn.Click += new System.EventHandler(this.Add_ticket_btn_Click);
            // 
            // updateTicketBtn
            // 
            this.updateTicketBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateTicketBtn.Location = new System.Drawing.Point(319, 3);
            this.updateTicketBtn.Name = "updateTicketBtn";
            this.updateTicketBtn.Size = new System.Drawing.Size(156, 29);
            this.updateTicketBtn.TabIndex = 10;
            this.updateTicketBtn.Text = "Редактировать";
            this.updateTicketBtn.UseVisualStyleBackColor = true;
            this.updateTicketBtn.Click += new System.EventHandler(this.updateTicketBtn_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.56962F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.43038F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel3.Controls.Add(this.Add_ticket_btn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.updateTicketBtn, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.deleteTicketBtn, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 205);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(478, 35);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tickets, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(510, 11);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.12757F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.87243F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(484, 243);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // TrainSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 470);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "TrainSchedule";
            this.Text = "Train Schedule";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.passengers)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tickets)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
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
        private DataGridView tickets;
        private DataGridViewTextBoxColumn trainNumber;
        private DataGridViewTextBoxColumn departure;
        private DataGridViewTextBoxColumn timeOfDeparture;
        private DataGridViewTextBoxColumn timeOfArrival;
        private DataGridViewTextBoxColumn ticketId;
        private Button deleteTicketBtn;
        private Button Add_ticket_btn;
        private Button updateTicketBtn;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
    }
}
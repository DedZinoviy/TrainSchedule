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
            this.AverageRating = new System.Windows.Forms.TextBox();
            this.AvRagingLabel = new System.Windows.Forms.Label();
            this.SummaryCost = new System.Windows.Forms.TextBox();
            this.SymmaryCostLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.reviews = new System.Windows.Forms.DataGridView();
            this.ReviewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewEvaluation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reviewId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addReviewBtn = new System.Windows.Forms.Button();
            this.DeleteReviewBtn = new System.Windows.Forms.Button();
            this.UpdateReviewBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passengers)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tickets)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reviews)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add_pass
            // 
            this.Add_pass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add_pass.Location = new System.Drawing.Point(3, 3);
            this.Add_pass.Name = "Add_pass";
            this.Add_pass.Size = new System.Drawing.Size(134, 37);
            this.Add_pass.TabIndex = 1;
            this.Add_pass.Text = "Добавить";
            this.Add_pass.UseVisualStyleBackColor = true;
            this.Add_pass.Click += new System.EventHandler(this.Add_pass_Click);
            // 
            // Delete_pass
            // 
            this.Delete_pass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Delete_pass.Location = new System.Drawing.Point(143, 3);
            this.Delete_pass.Name = "Delete_pass";
            this.Delete_pass.Size = new System.Drawing.Size(162, 37);
            this.Delete_pass.TabIndex = 2;
            this.Delete_pass.Text = "Удалить";
            this.Delete_pass.UseVisualStyleBackColor = true;
            this.Delete_pass.Click += new System.EventHandler(this.Delete_pass_Click);
            // 
            // Update_pass
            // 
            this.Update_pass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Update_pass.Location = new System.Drawing.Point(311, 3);
            this.Update_pass.Name = "Update_pass";
            this.Update_pass.Size = new System.Drawing.Size(221, 37);
            this.Update_pass.TabIndex = 3;
            this.Update_pass.Text = "Редактировать";
            this.Update_pass.UseVisualStyleBackColor = true;
            this.Update_pass.Click += new System.EventHandler(this.Update_pass_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.41485F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.58515F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 226F));
            this.tableLayoutPanel1.Controls.Add(this.Add_pass, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Update_pass, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Delete_pass, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 200);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(535, 43);
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
            this.passengers.Size = new System.Drawing.Size(535, 193);
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
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0813F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9187F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(541, 246);
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
            this.tickets.Size = new System.Drawing.Size(535, 192);
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
            this.deleteTicketBtn.Location = new System.Drawing.Point(149, 3);
            this.deleteTicketBtn.Name = "deleteTicketBtn";
            this.deleteTicketBtn.Size = new System.Drawing.Size(168, 34);
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
            this.Add_ticket_btn.Size = new System.Drawing.Size(140, 34);
            this.Add_ticket_btn.TabIndex = 9;
            this.Add_ticket_btn.Text = "Добавить";
            this.Add_ticket_btn.UseVisualStyleBackColor = true;
            this.Add_ticket_btn.Click += new System.EventHandler(this.Add_ticket_btn_Click);
            // 
            // updateTicketBtn
            // 
            this.updateTicketBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateTicketBtn.Location = new System.Drawing.Point(323, 3);
            this.updateTicketBtn.Name = "updateTicketBtn";
            this.updateTicketBtn.Size = new System.Drawing.Size(209, 34);
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
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanel3.Controls.Add(this.Add_ticket_btn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.updateTicketBtn, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.deleteTicketBtn, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 201);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(535, 40);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tickets, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(550, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.14754F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.85246F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(541, 244);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // AverageRating
            // 
            this.AverageRating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AverageRating.Location = new System.Drawing.Point(3, 122);
            this.AverageRating.Name = "AverageRating";
            this.AverageRating.ReadOnly = true;
            this.AverageRating.Size = new System.Drawing.Size(259, 23);
            this.AverageRating.TabIndex = 13;
            this.AverageRating.UseWaitCursor = true;
            this.AverageRating.Click += new System.EventHandler(this.AverageRating_Click);
            // 
            // AvRagingLabel
            // 
            this.AvRagingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AvRagingLabel.AutoSize = true;
            this.AvRagingLabel.Location = new System.Drawing.Point(85, 52);
            this.AvRagingLabel.Name = "AvRagingLabel";
            this.AvRagingLabel.Size = new System.Drawing.Size(95, 15);
            this.AvRagingLabel.TabIndex = 14;
            this.AvRagingLabel.Text = "Средняя оценка";
            // 
            // SummaryCost
            // 
            this.SummaryCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SummaryCost.Location = new System.Drawing.Point(3, 122);
            this.SummaryCost.Name = "SummaryCost";
            this.SummaryCost.ReadOnly = true;
            this.SummaryCost.Size = new System.Drawing.Size(258, 23);
            this.SummaryCost.TabIndex = 15;
            this.SummaryCost.Click += new System.EventHandler(this.SummaryCost_Click);
            // 
            // SymmaryCostLabel
            // 
            this.SymmaryCostLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SymmaryCostLabel.AutoSize = true;
            this.SymmaryCostLabel.Location = new System.Drawing.Point(77, 52);
            this.SymmaryCostLabel.Name = "SymmaryCostLabel";
            this.SymmaryCostLabel.Size = new System.Drawing.Size(110, 15);
            this.SymmaryCostLabel.TabIndex = 16;
            this.SymmaryCostLabel.Text = "Общая  стоимость";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.AvRagingLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.AverageRating, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(273, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(265, 239);
            this.tableLayoutPanel5.TabIndex = 17;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.SymmaryCostLabel, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.SummaryCost, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(264, 239);
            this.tableLayoutPanel6.TabIndex = 18;
            // 
            // reviews
            // 
            this.reviews.AllowUserToAddRows = false;
            this.reviews.AllowUserToDeleteRows = false;
            this.reviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reviews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReviewName,
            this.ReviewMessage,
            this.ReviewEvaluation,
            this.reviewId});
            this.reviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reviews.Location = new System.Drawing.Point(3, 3);
            this.reviews.Name = "reviews";
            this.reviews.ReadOnly = true;
            this.reviews.RowHeadersVisible = false;
            this.reviews.RowTemplate.Height = 25;
            this.reviews.Size = new System.Drawing.Size(535, 194);
            this.reviews.TabIndex = 19;
            // 
            // ReviewName
            // 
            this.ReviewName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReviewName.HeaderText = "Название";
            this.ReviewName.Name = "ReviewName";
            this.ReviewName.ReadOnly = true;
            // 
            // ReviewMessage
            // 
            this.ReviewMessage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReviewMessage.HeaderText = "Сообщение";
            this.ReviewMessage.Name = "ReviewMessage";
            this.ReviewMessage.ReadOnly = true;
            // 
            // ReviewEvaluation
            // 
            this.ReviewEvaluation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReviewEvaluation.HeaderText = "Оценка";
            this.ReviewEvaluation.Name = "ReviewEvaluation";
            this.ReviewEvaluation.ReadOnly = true;
            // 
            // reviewId
            // 
            this.reviewId.HeaderText = "";
            this.reviewId.Name = "reviewId";
            this.reviewId.ReadOnly = true;
            this.reviewId.Visible = false;
            // 
            // addReviewBtn
            // 
            this.addReviewBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addReviewBtn.Location = new System.Drawing.Point(3, 3);
            this.addReviewBtn.Name = "addReviewBtn";
            this.addReviewBtn.Size = new System.Drawing.Size(140, 33);
            this.addReviewBtn.TabIndex = 20;
            this.addReviewBtn.Text = "Добавить";
            this.addReviewBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteReviewBtn
            // 
            this.DeleteReviewBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteReviewBtn.Location = new System.Drawing.Point(149, 3);
            this.DeleteReviewBtn.Name = "DeleteReviewBtn";
            this.DeleteReviewBtn.Size = new System.Drawing.Size(176, 33);
            this.DeleteReviewBtn.TabIndex = 21;
            this.DeleteReviewBtn.Text = "Удалить";
            this.DeleteReviewBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateReviewBtn
            // 
            this.UpdateReviewBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateReviewBtn.Location = new System.Drawing.Point(331, 3);
            this.UpdateReviewBtn.Name = "UpdateReviewBtn";
            this.UpdateReviewBtn.Size = new System.Drawing.Size(201, 33);
            this.UpdateReviewBtn.TabIndex = 22;
            this.UpdateReviewBtn.Text = "Редактировать";
            this.UpdateReviewBtn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.5122F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.4878F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanel7.Controls.Add(this.addReviewBtn, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.UpdateReviewBtn, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.DeleteReviewBtn, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 203);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(535, 39);
            this.tableLayoutPanel7.TabIndex = 23;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.reviews, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(550, 253);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.63265F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.36735F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(541, 245);
            this.tableLayoutPanel8.TabIndex = 24;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel10, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel8, 1, 1);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(1094, 501);
            this.tableLayoutPanel9.TabIndex = 25;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 253);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(541, 245);
            this.tableLayoutPanel10.TabIndex = 26;
            // 
            // TrainSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 501);
            this.Controls.Add(this.tableLayoutPanel9);
            this.Name = "TrainSchedule";
            this.Text = "Train Schedule";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.passengers)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tickets)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reviews)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
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
        private TextBox AverageRating;
        private Label AvRagingLabel;
        private TextBox SummaryCost;
        private Label SymmaryCostLabel;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private DataGridView reviews;
        private DataGridViewTextBoxColumn ReviewName;
        private DataGridViewTextBoxColumn ReviewMessage;
        private DataGridViewTextBoxColumn ReviewEvaluation;
        private DataGridViewTextBoxColumn reviewId;
        private Button addReviewBtn;
        private Button DeleteReviewBtn;
        private Button UpdateReviewBtn;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel10;
    }
}
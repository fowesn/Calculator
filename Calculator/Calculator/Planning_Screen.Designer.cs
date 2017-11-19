namespace Calculator
{
    partial class Planning_Screen
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
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "werty"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Window, new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "sdfgn"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            this.Planning = new System.Windows.Forms.Label();
            this.History = new System.Windows.Forms.Label();
            this.ActiveButton = new System.Windows.Forms.Label();
            this.PlanningList = new System.Windows.Forms.ListView();
            this.Today = new System.Windows.Forms.Label();
            this.Account = new System.Windows.Forms.Label();
            this.CurrentStateBar = new System.Windows.Forms.Label();
            this.SideBarBG = new System.Windows.Forms.Label();
            this.AddSubBar = new System.Windows.Forms.Label();
            this.CurrentState = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Label();
            this.Subtract = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Label();
            this.CalculateBar = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Planning
            // 
            this.Planning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Planning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Planning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Planning.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Planning.ForeColor = System.Drawing.Color.Gray;
            this.Planning.Location = new System.Drawing.Point(8, 172);
            this.Planning.MaximumSize = new System.Drawing.Size(217, 10000);
            this.Planning.MinimumSize = new System.Drawing.Size(217, 87);
            this.Planning.Name = "Planning";
            this.Planning.Size = new System.Drawing.Size(217, 87);
            this.Planning.TabIndex = 38;
            this.Planning.Text = "Планирование";
            this.Planning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // History
            // 
            this.History.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.History.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.History.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.History.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.History.ForeColor = System.Drawing.Color.Gray;
            this.History.Location = new System.Drawing.Point(0, 86);
            this.History.MaximumSize = new System.Drawing.Size(225, 10000);
            this.History.MinimumSize = new System.Drawing.Size(225, 87);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(225, 87);
            this.History.TabIndex = 37;
            this.History.Text = "История";
            this.History.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // ActiveButton
            // 
            this.ActiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(64)))));
            this.ActiveButton.Location = new System.Drawing.Point(0, 172);
            this.ActiveButton.Name = "ActiveButton";
            this.ActiveButton.Size = new System.Drawing.Size(8, 87);
            this.ActiveButton.TabIndex = 35;
            // 
            // PlanningList
            // 
            this.PlanningList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlanningList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            listViewItem9.ToolTipText = "sredrgfhcgv";
            listViewItem9.UseItemStyleForSubItems = false;
            listViewItem10.UseItemStyleForSubItems = false;
            this.PlanningList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem9,
            listViewItem10});
            this.PlanningList.Location = new System.Drawing.Point(225, 75);
            this.PlanningList.MultiSelect = false;
            this.PlanningList.Name = "PlanningList";
            this.PlanningList.Size = new System.Drawing.Size(551, 349);
            this.PlanningList.TabIndex = 34;
            this.PlanningList.UseCompatibleStateImageBehavior = false;
            this.PlanningList.View = System.Windows.Forms.View.List;
            this.PlanningList.SelectedIndexChanged += new System.EventHandler(this.PlanningList_SelectedIndexChanged);
            // 
            // Today
            // 
            this.Today.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Today.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(64)))));
            this.Today.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Today.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Today.Location = new System.Drawing.Point(652, 0);
            this.Today.MaximumSize = new System.Drawing.Size(118, 27);
            this.Today.Name = "Today";
            this.Today.Size = new System.Drawing.Size(118, 27);
            this.Today.TabIndex = 33;
            this.Today.Text = "01.01.1900";
            this.Today.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Account
            // 
            this.Account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(64)))));
            this.Account.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Account.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Account.Location = new System.Drawing.Point(231, 0);
            this.Account.MaximumSize = new System.Drawing.Size(118, 27);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(118, 27);
            this.Account.TabIndex = 32;
            this.Account.Text = "0 руб.";
            this.Account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CurrentStateBar
            // 
            this.CurrentStateBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentStateBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(64)))));
            this.CurrentStateBar.Location = new System.Drawing.Point(225, 0);
            this.CurrentStateBar.Name = "CurrentStateBar";
            this.CurrentStateBar.Size = new System.Drawing.Size(550, 27);
            this.CurrentStateBar.TabIndex = 31;
            // 
            // SideBarBG
            // 
            this.SideBarBG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SideBarBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SideBarBG.Location = new System.Drawing.Point(0, 0);
            this.SideBarBG.MaximumSize = new System.Drawing.Size(225, 10000);
            this.SideBarBG.MinimumSize = new System.Drawing.Size(225, 472);
            this.SideBarBG.Name = "SideBarBG";
            this.SideBarBG.Size = new System.Drawing.Size(225, 472);
            this.SideBarBG.TabIndex = 30;
            // 
            // AddSubBar
            // 
            this.AddSubBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSubBar.BackColor = System.Drawing.Color.Silver;
            this.AddSubBar.Location = new System.Drawing.Point(225, 27);
            this.AddSubBar.Name = "AddSubBar";
            this.AddSubBar.Size = new System.Drawing.Size(550, 48);
            this.AddSubBar.TabIndex = 39;
            // 
            // CurrentState
            // 
            this.CurrentState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CurrentState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentState.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentState.ForeColor = System.Drawing.Color.Gray;
            this.CurrentState.Location = new System.Drawing.Point(0, 0);
            this.CurrentState.MaximumSize = new System.Drawing.Size(225, 10000);
            this.CurrentState.MinimumSize = new System.Drawing.Size(225, 87);
            this.CurrentState.Name = "CurrentState";
            this.CurrentState.Size = new System.Drawing.Size(225, 87);
            this.CurrentState.TabIndex = 40;
            this.CurrentState.Text = "Текущее состояние";
            this.CurrentState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CurrentState.Click += new System.EventHandler(this.CurrentState_Click);
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add.BackColor = System.Drawing.Color.Gray;
            this.Add.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Add.Location = new System.Drawing.Point(463, 36);
            this.Add.MaximumSize = new System.Drawing.Size(143, 30);
            this.Add.MinimumSize = new System.Drawing.Size(143, 30);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(143, 30);
            this.Add.TabIndex = 42;
            this.Add.Text = "Добавить доход";
            this.Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Subtract
            // 
            this.Subtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Subtract.BackColor = System.Drawing.Color.Gray;
            this.Subtract.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Subtract.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Subtract.Location = new System.Drawing.Point(612, 36);
            this.Subtract.MaximumSize = new System.Drawing.Size(143, 30);
            this.Subtract.MinimumSize = new System.Drawing.Size(143, 30);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(143, 30);
            this.Subtract.TabIndex = 41;
            this.Subtract.Text = "Добавить расход";
            this.Subtract.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Gray;
            this.Clear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Clear.Location = new System.Drawing.Point(239, 36);
            this.Clear.MaximumSize = new System.Drawing.Size(110, 30);
            this.Clear.MinimumSize = new System.Drawing.Size(110, 30);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(110, 30);
            this.Clear.TabIndex = 43;
            this.Clear.Text = "Очистить";
            this.Clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // CalculateBar
            // 
            this.CalculateBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculateBar.BackColor = System.Drawing.Color.Silver;
            this.CalculateBar.Location = new System.Drawing.Point(225, 424);
            this.CalculateBar.Name = "CalculateBar";
            this.CalculateBar.Size = new System.Drawing.Size(550, 48);
            this.CalculateBar.TabIndex = 44;
            // 
            // Calculate
            // 
            this.Calculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Calculate.BackColor = System.Drawing.Color.Gray;
            this.Calculate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calculate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Calculate.Location = new System.Drawing.Point(612, 434);
            this.Calculate.MaximumSize = new System.Drawing.Size(143, 30);
            this.Calculate.MinimumSize = new System.Drawing.Size(143, 30);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(143, 30);
            this.Calculate.TabIndex = 45;
            this.Calculate.Text = "Рассчитать";
            this.Calculate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Date
            // 
            this.Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Date.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date.CalendarTitleBackColor = System.Drawing.SystemColors.Window;
            this.Date.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date.Location = new System.Drawing.Point(243, 435);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(188, 28);
            this.Date.TabIndex = 46;
            // 
            // Planning_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 471);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.CalculateBar);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.CurrentState);
            this.Controls.Add(this.AddSubBar);
            this.Controls.Add(this.Planning);
            this.Controls.Add(this.History);
            this.Controls.Add(this.ActiveButton);
            this.Controls.Add(this.PlanningList);
            this.Controls.Add(this.Today);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.CurrentStateBar);
            this.Controls.Add(this.SideBarBG);
            this.MinimumSize = new System.Drawing.Size(690, 500);
            this.Name = "Planning_Screen";
            this.Text = "Планирование счёта";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Planning_Screen_Closed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Planning;
        private System.Windows.Forms.Label History;
        private System.Windows.Forms.Label ActiveButton;
        private System.Windows.Forms.ListView PlanningList;
        private System.Windows.Forms.Label Today;
        private System.Windows.Forms.Label Account;
        private System.Windows.Forms.Label CurrentStateBar;
        private System.Windows.Forms.Label SideBarBG;
        private System.Windows.Forms.Label AddSubBar;
        private System.Windows.Forms.Label CurrentState;
        private System.Windows.Forms.Label Add;
        private System.Windows.Forms.Label Subtract;
        private System.Windows.Forms.Label Clear;
        private System.Windows.Forms.Label CalculateBar;
        private System.Windows.Forms.Label Calculate;
        private System.Windows.Forms.DateTimePicker Date;
    }
}
namespace Calculator
{
    partial class History_Screen
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "01.01.1900"}, -1, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.InfoText, null);
            this.Today = new System.Windows.Forms.Label();
            this.Account = new System.Windows.Forms.Label();
            this.CurrentStateBar = new System.Windows.Forms.Label();
            this.HistoryList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Clear = new System.Windows.Forms.Label();
            this.ClearBar = new System.Windows.Forms.Label();
            this.CurrentState = new System.Windows.Forms.Label();
            this.Planning = new System.Windows.Forms.Label();
            this.History = new System.Windows.Forms.Label();
            this.ActiveButton = new System.Windows.Forms.Label();
            this.SideBarBG = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.Today.TabIndex = 22;
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
            this.Account.TabIndex = 19;
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
            this.CurrentStateBar.TabIndex = 18;
            // 
            // HistoryList
            // 
            this.HistoryList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HistoryList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HistoryList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.HistoryList.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HistoryList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.HistoryList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.HistoryList.Location = new System.Drawing.Point(220, 27);
            this.HistoryList.Margin = new System.Windows.Forms.Padding(0);
            this.HistoryList.MultiSelect = false;
            this.HistoryList.Name = "HistoryList";
            this.HistoryList.Size = new System.Drawing.Size(555, 445);
            this.HistoryList.TabIndex = 33;
            this.HistoryList.UseCompatibleStateImageBehavior = false;
            this.HistoryList.View = System.Windows.Forms.View.Details;
            this.HistoryList.SelectedIndexChanged += new System.EventHandler(this.HistoryList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 1000;
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear.BackColor = System.Drawing.Color.Gray;
            this.Clear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Clear.Location = new System.Drawing.Point(644, 36);
            this.Clear.MaximumSize = new System.Drawing.Size(110, 30);
            this.Clear.MinimumSize = new System.Drawing.Size(110, 30);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(110, 30);
            this.Clear.TabIndex = 35;
            this.Clear.Text = "Очистить";
            this.Clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClearBar
            // 
            this.ClearBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearBar.BackColor = System.Drawing.Color.Silver;
            this.ClearBar.Location = new System.Drawing.Point(225, 27);
            this.ClearBar.Name = "ClearBar";
            this.ClearBar.Size = new System.Drawing.Size(550, 48);
            this.ClearBar.TabIndex = 34;
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
            // Planning
            // 
            this.Planning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Planning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Planning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Planning.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Planning.ForeColor = System.Drawing.Color.Gray;
            this.Planning.Location = new System.Drawing.Point(0, 172);
            this.Planning.MaximumSize = new System.Drawing.Size(225, 10000);
            this.Planning.MinimumSize = new System.Drawing.Size(225, 87);
            this.Planning.Name = "Planning";
            this.Planning.Size = new System.Drawing.Size(225, 87);
            this.Planning.TabIndex = 39;
            this.Planning.Text = "Планирование";
            this.Planning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Planning.Click += new System.EventHandler(this.Planning_Click);
            // 
            // History
            // 
            this.History.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.History.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.History.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.History.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.History.ForeColor = System.Drawing.Color.Gray;
            this.History.Location = new System.Drawing.Point(8, 86);
            this.History.MaximumSize = new System.Drawing.Size(217, 10000);
            this.History.MinimumSize = new System.Drawing.Size(217, 87);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(217, 87);
            this.History.TabIndex = 38;
            this.History.Text = "История";
            this.History.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ActiveButton
            // 
            this.ActiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(64)))));
            this.ActiveButton.Location = new System.Drawing.Point(0, 86);
            this.ActiveButton.Name = "ActiveButton";
            this.ActiveButton.Size = new System.Drawing.Size(8, 87);
            this.ActiveButton.TabIndex = 37;
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
            this.SideBarBG.TabIndex = 36;
            // 
            // History_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(774, 471);
            this.Controls.Add(this.CurrentState);
            this.Controls.Add(this.Planning);
            this.Controls.Add(this.History);
            this.Controls.Add(this.ActiveButton);
            this.Controls.Add(this.SideBarBG);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.ClearBar);
            this.Controls.Add(this.HistoryList);
            this.Controls.Add(this.Today);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.CurrentStateBar);
            this.Location = new System.Drawing.Point(150, 150);
            this.MinimumSize = new System.Drawing.Size(690, 500);
            this.Name = "History_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "История счёта";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.History_Screen_Closed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Today;
        private System.Windows.Forms.Label Account;
        private System.Windows.Forms.Label CurrentStateBar;
        private System.Windows.Forms.ListView HistoryList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label Clear;
        private System.Windows.Forms.Label ClearBar;
        private System.Windows.Forms.Label CurrentState;
        private System.Windows.Forms.Label Planning;
        private System.Windows.Forms.Label History;
        private System.Windows.Forms.Label ActiveButton;
        private System.Windows.Forms.Label SideBarBG;
    }
}
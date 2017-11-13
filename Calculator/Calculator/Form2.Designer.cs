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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "werty"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Window, new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "sdfgn"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            this.CurrentStateList = new System.Windows.Forms.ListView();
            this.Today = new System.Windows.Forms.Label();
            this.Account = new System.Windows.Forms.Label();
            this.CurrentStateBar = new System.Windows.Forms.Label();
            this.SideBarBG = new System.Windows.Forms.Label();
            this.ActiveButton = new System.Windows.Forms.Label();
            this.CurrentState = new System.Windows.Forms.Label();
            this.History = new System.Windows.Forms.Label();
            this.Planning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurrentStateList
            // 
            this.CurrentStateList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentStateList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            listViewItem5.ToolTipText = "sredrgfhcgv";
            listViewItem5.UseItemStyleForSubItems = false;
            listViewItem6.UseItemStyleForSubItems = false;
            this.CurrentStateList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6});
            this.CurrentStateList.Location = new System.Drawing.Point(155, 27);
            this.CurrentStateList.MultiSelect = false;
            this.CurrentStateList.Name = "CurrentStateList";
            this.CurrentStateList.Size = new System.Drawing.Size(330, 483);
            this.CurrentStateList.TabIndex = 25;
            this.CurrentStateList.UseCompatibleStateImageBehavior = false;
            this.CurrentStateList.View = System.Windows.Forms.View.Tile;
            // 
            // Today
            // 
            this.Today.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Today.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(64)))));
            this.Today.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Today.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Today.Location = new System.Drawing.Point(367, 0);
            this.Today.MaximumSize = new System.Drawing.Size(118, 27);
            this.Today.Name = "Today";
            this.Today.Size = new System.Drawing.Size(118, 27);
            this.Today.TabIndex = 22;
            this.Today.Text = "01.01.1900  ";
            this.Today.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Account
            // 
            this.Account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(64)))));
            this.Account.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Account.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Account.Location = new System.Drawing.Point(162, 0);
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
            this.CurrentStateBar.Location = new System.Drawing.Point(126, 0);
            this.CurrentStateBar.Name = "CurrentStateBar";
            this.CurrentStateBar.Size = new System.Drawing.Size(359, 27);
            this.CurrentStateBar.TabIndex = 18;
            // 
            // SideBarBG
            // 
            this.SideBarBG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SideBarBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SideBarBG.Location = new System.Drawing.Point(0, -3);
            this.SideBarBG.MaximumSize = new System.Drawing.Size(225, 10000);
            this.SideBarBG.MinimumSize = new System.Drawing.Size(156, 515);
            this.SideBarBG.Name = "SideBarBG";
            this.SideBarBG.Size = new System.Drawing.Size(156, 515);
            this.SideBarBG.TabIndex = 15;
            // 
            // ActiveButton
            // 
            this.ActiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(64)))));
            this.ActiveButton.Location = new System.Drawing.Point(0, 86);
            this.ActiveButton.Name = "ActiveButton";
            this.ActiveButton.Size = new System.Drawing.Size(8, 87);
            this.ActiveButton.TabIndex = 26;
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
            this.CurrentState.MaximumSize = new System.Drawing.Size(217, 10000);
            this.CurrentState.MinimumSize = new System.Drawing.Size(156, 87);
            this.CurrentState.Name = "CurrentState";
            this.CurrentState.Size = new System.Drawing.Size(156, 87);
            this.CurrentState.TabIndex = 27;
            this.CurrentState.Text = "Текущее состояние";
            this.CurrentState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CurrentState.Click += new System.EventHandler(this.CurrentState_Click);
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
            this.History.MaximumSize = new System.Drawing.Size(225, 10000);
            this.History.MinimumSize = new System.Drawing.Size(148, 87);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(148, 87);
            this.History.TabIndex = 28;
            this.History.Text = "История";
            this.History.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Planning.MinimumSize = new System.Drawing.Size(156, 87);
            this.Planning.Name = "Planning";
            this.Planning.Size = new System.Drawing.Size(156, 87);
            this.Planning.TabIndex = 29;
            this.Planning.Text = "Планирование";
            this.Planning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // History_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 511);
            this.Controls.Add(this.Planning);
            this.Controls.Add(this.History);
            this.Controls.Add(this.CurrentState);
            this.Controls.Add(this.ActiveButton);
            this.Controls.Add(this.CurrentStateList);
            this.Controls.Add(this.Today);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.CurrentStateBar);
            this.Controls.Add(this.SideBarBG);
            this.Location = new System.Drawing.Point(150, 150);
            this.MaximumSize = new System.Drawing.Size(500, 10000);
            this.MinimumSize = new System.Drawing.Size(500, 550);
            this.Name = "History_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "История счёта";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.History_Screen_Closed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView CurrentStateList;
        private System.Windows.Forms.Label Today;
        private System.Windows.Forms.Label Account;
        private System.Windows.Forms.Label CurrentStateBar;
        private System.Windows.Forms.Label SideBarBG;
        private System.Windows.Forms.Label ActiveButton;
        private System.Windows.Forms.Label CurrentState;
        private System.Windows.Forms.Label History;
        private System.Windows.Forms.Label Planning;
    }
}
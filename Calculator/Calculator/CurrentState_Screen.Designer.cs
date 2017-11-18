namespace Calculator
{
    partial class CurrentState_Screen
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "werty"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Window, new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "sdfgn"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            this.SideBarBG = new System.Windows.Forms.Label();
            this.History = new System.Windows.Forms.Label();
            this.Planning = new System.Windows.Forms.Label();
            this.ActiveButton = new System.Windows.Forms.Label();
            this.CurrentStateBar = new System.Windows.Forms.Label();
            this.Account = new System.Windows.Forms.Label();
            this.AddSubBar = new System.Windows.Forms.Label();
            this.CurrentState = new System.Windows.Forms.Label();
            this.Today = new System.Windows.Forms.Label();
            this.Subtract = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Label();
            this.CurrentStateList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
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
            this.SideBarBG.TabIndex = 0;
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
            this.History.TabIndex = 3;
            this.History.Text = "История";
            this.History.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.History.Click += new System.EventHandler(this.History_Click);
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
            this.Planning.TabIndex = 4;
            this.Planning.Text = "Планирование";
            this.Planning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Planning.Click += new System.EventHandler(this.Planning_Click);
            // 
            // ActiveButton
            // 
            this.ActiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(64)))));
            this.ActiveButton.Location = new System.Drawing.Point(0, 0);
            this.ActiveButton.Name = "ActiveButton";
            this.ActiveButton.Size = new System.Drawing.Size(8, 87);
            this.ActiveButton.TabIndex = 5;
            // 
            // CurrentStateBar
            // 
            this.CurrentStateBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentStateBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(64)))));
            this.CurrentStateBar.Location = new System.Drawing.Point(225, 0);
            this.CurrentStateBar.Name = "CurrentStateBar";
            this.CurrentStateBar.Size = new System.Drawing.Size(550, 27);
            this.CurrentStateBar.TabIndex = 6;
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
            this.Account.TabIndex = 8;
            this.Account.Text = "0 руб.";
            this.Account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddSubBar
            // 
            this.AddSubBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSubBar.BackColor = System.Drawing.Color.Silver;
            this.AddSubBar.Location = new System.Drawing.Point(225, 27);
            this.AddSubBar.Name = "AddSubBar";
            this.AddSubBar.Size = new System.Drawing.Size(550, 48);
            this.AddSubBar.TabIndex = 9;
            // 
            // CurrentState
            // 
            this.CurrentState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CurrentState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentState.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentState.ForeColor = System.Drawing.Color.Gray;
            this.CurrentState.Location = new System.Drawing.Point(8, 0);
            this.CurrentState.MaximumSize = new System.Drawing.Size(217, 10000);
            this.CurrentState.MinimumSize = new System.Drawing.Size(217, 87);
            this.CurrentState.Name = "CurrentState";
            this.CurrentState.Size = new System.Drawing.Size(217, 87);
            this.CurrentState.TabIndex = 10;
            this.CurrentState.Text = "Текущее состояние";
            this.CurrentState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Today.TabIndex = 11;
            this.Today.Text = "01.01.1900";
            this.Today.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Subtract
            // 
            this.Subtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Subtract.BackColor = System.Drawing.Color.Gray;
            this.Subtract.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Subtract.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Subtract.Location = new System.Drawing.Point(612, 36);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(143, 30);
            this.Subtract.TabIndex = 12;
            this.Subtract.Text = "Добавить расход";
            this.Subtract.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add.BackColor = System.Drawing.Color.Gray;
            this.Add.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Add.Location = new System.Drawing.Point(463, 36);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(143, 30);
            this.Add.TabIndex = 13;
            this.Add.Text = "Добавить доход";
            this.Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // CurrentStateList
            // 
            this.CurrentStateList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentStateList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            listViewItem1.ToolTipText = "sredrgfhcgv";
            listViewItem1.UseItemStyleForSubItems = false;
            listViewItem2.UseItemStyleForSubItems = false;
            this.CurrentStateList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.CurrentStateList.Location = new System.Drawing.Point(225, 75);
            this.CurrentStateList.MultiSelect = false;
            this.CurrentStateList.Name = "CurrentStateList";
            this.CurrentStateList.Size = new System.Drawing.Size(551, 397);
            this.CurrentStateList.TabIndex = 14;
            this.CurrentStateList.UseCompatibleStateImageBehavior = false;
            this.CurrentStateList.View = System.Windows.Forms.View.List;
            this.CurrentStateList.SelectedIndexChanged += new System.EventHandler(this.CurrentStateList_SelectedIndexChanged);
            // 
            // CurrentState_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 471);
            this.Controls.Add(this.CurrentStateList);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Today);
            this.Controls.Add(this.CurrentState);
            this.Controls.Add(this.AddSubBar);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.CurrentStateBar);
            this.Controls.Add(this.ActiveButton);
            this.Controls.Add(this.Planning);
            this.Controls.Add(this.History);
            this.Controls.Add(this.SideBarBG);
            this.Location = new System.Drawing.Point(150, 150);
            this.MinimumSize = new System.Drawing.Size(690, 500);
            this.Name = "CurrentState_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Текущее состояние счёта";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CurrentState_Screen_Closed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SideBarBG;
        private System.Windows.Forms.Label History;
        private System.Windows.Forms.Label Planning;
        private System.Windows.Forms.Label ActiveButton;
        private System.Windows.Forms.Label CurrentStateBar;
        private System.Windows.Forms.Label Account;
        private System.Windows.Forms.Label AddSubBar;
        private System.Windows.Forms.Label CurrentState;
        private System.Windows.Forms.Label Today;
        private System.Windows.Forms.Label Subtract;
        private System.Windows.Forms.Label Add;
        private System.Windows.Forms.ListView CurrentStateList;
    }
}


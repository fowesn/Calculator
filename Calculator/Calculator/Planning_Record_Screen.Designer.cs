namespace Calculator
{
    partial class Planning_Record_Screen
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
            this.Save = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Label();
            this.Today = new System.Windows.Forms.Label();
            this.CurrentState = new System.Windows.Forms.Label();
            this.AddSubBar = new System.Windows.Forms.Label();
            this.Account = new System.Windows.Forms.Label();
            this.CurrentStateBar = new System.Windows.Forms.Label();
            this.ActiveButton = new System.Windows.Forms.Label();
            this.Planning = new System.Windows.Forms.Label();
            this.History = new System.Windows.Forms.Label();
            this.SideBarBG = new System.Windows.Forms.Label();
            this.Commentary = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.TextBox();
            this.CommentaryLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.FrequencyLabel = new System.Windows.Forms.Label();
            this.Times = new System.Windows.Forms.TextBox();
            this.TimesLabel = new System.Windows.Forms.Label();
            this.Days = new System.Windows.Forms.TextBox();
            this.DaysLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.BackColor = System.Drawing.Color.Gray;
            this.Save.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Save.Location = new System.Drawing.Point(463, 36);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(143, 30);
            this.Save.TabIndex = 36;
            this.Save.Text = "Сохранить";
            this.Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.BackColor = System.Drawing.Color.Gray;
            this.Cancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Cancel.Location = new System.Drawing.Point(612, 36);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(143, 30);
            this.Cancel.TabIndex = 35;
            this.Cancel.Text = "Отменить";
            this.Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
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
            this.Today.TabIndex = 34;
            this.Today.Text = "01.01.1900";
            this.Today.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.CurrentState.TabIndex = 33;
            this.CurrentState.Text = "Текущее состояние";
            this.CurrentState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CurrentState.Click += new System.EventHandler(this.CurrentState_Click);
            // 
            // AddSubBar
            // 
            this.AddSubBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSubBar.BackColor = System.Drawing.Color.Silver;
            this.AddSubBar.Location = new System.Drawing.Point(225, 27);
            this.AddSubBar.Name = "AddSubBar";
            this.AddSubBar.Size = new System.Drawing.Size(550, 48);
            this.AddSubBar.TabIndex = 32;
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
            this.Account.TabIndex = 31;
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
            this.CurrentStateBar.TabIndex = 30;
            // 
            // ActiveButton
            // 
            this.ActiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(64)))));
            this.ActiveButton.Location = new System.Drawing.Point(0, 172);
            this.ActiveButton.Name = "ActiveButton";
            this.ActiveButton.Size = new System.Drawing.Size(8, 87);
            this.ActiveButton.TabIndex = 29;
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
            this.Planning.TabIndex = 28;
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
            this.History.TabIndex = 27;
            this.History.Text = "История";
            this.History.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.History.Click += new System.EventHandler(this.History_Click);
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
            this.SideBarBG.TabIndex = 26;
            // 
            // Commentary
            // 
            this.Commentary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Commentary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Commentary.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Commentary.Location = new System.Drawing.Point(467, 250);
            this.Commentary.Multiline = true;
            this.Commentary.Name = "Commentary";
            this.Commentary.Size = new System.Drawing.Size(254, 192);
            this.Commentary.TabIndex = 42;
            // 
            // Amount
            // 
            this.Amount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Amount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Amount.Location = new System.Drawing.Point(467, 200);
            this.Amount.Multiline = true;
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(254, 29);
            this.Amount.TabIndex = 41;
            // 
            // CommentaryLabel
            // 
            this.CommentaryLabel.BackColor = System.Drawing.SystemColors.Window;
            this.CommentaryLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommentaryLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommentaryLabel.Location = new System.Drawing.Point(281, 250);
            this.CommentaryLabel.Name = "CommentaryLabel";
            this.CommentaryLabel.Size = new System.Drawing.Size(170, 29);
            this.CommentaryLabel.TabIndex = 40;
            this.CommentaryLabel.Text = "Комментарий";
            this.CommentaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AmountLabel
            // 
            this.AmountLabel.BackColor = System.Drawing.SystemColors.Window;
            this.AmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AmountLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(281, 200);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(170, 29);
            this.AmountLabel.TabIndex = 39;
            this.AmountLabel.Text = "Сумма";
            this.AmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Category
            // 
            this.Category.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Category.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Category.FormattingEnabled = true;
            this.Category.Location = new System.Drawing.Point(467, 100);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(254, 29);
            this.Category.TabIndex = 38;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.BackColor = System.Drawing.SystemColors.Window;
            this.CategoryLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CategoryLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel.Location = new System.Drawing.Point(281, 100);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(170, 29);
            this.CategoryLabel.TabIndex = 37;
            this.CategoryLabel.Text = "Категория";
            this.CategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrequencyLabel
            // 
            this.FrequencyLabel.BackColor = System.Drawing.SystemColors.Window;
            this.FrequencyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FrequencyLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FrequencyLabel.Location = new System.Drawing.Point(281, 150);
            this.FrequencyLabel.Name = "FrequencyLabel";
            this.FrequencyLabel.Size = new System.Drawing.Size(170, 29);
            this.FrequencyLabel.TabIndex = 43;
            this.FrequencyLabel.Text = "Частота";
            this.FrequencyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Times
            // 
            this.Times.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Times.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Times.Location = new System.Drawing.Point(467, 150);
            this.Times.Multiline = true;
            this.Times.Name = "Times";
            this.Times.Size = new System.Drawing.Size(64, 29);
            this.Times.TabIndex = 44;
            // 
            // TimesLabel
            // 
            this.TimesLabel.BackColor = System.Drawing.SystemColors.Control;
            this.TimesLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimesLabel.Location = new System.Drawing.Point(537, 150);
            this.TimesLabel.Name = "TimesLabel";
            this.TimesLabel.Size = new System.Drawing.Size(56, 29);
            this.TimesLabel.TabIndex = 45;
            this.TimesLabel.Text = "раз в";
            this.TimesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Days
            // 
            this.Days.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Days.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Days.Location = new System.Drawing.Point(589, 150);
            this.Days.Multiline = true;
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(64, 29);
            this.Days.TabIndex = 46;
            // 
            // DaysLabel
            // 
            this.DaysLabel.BackColor = System.Drawing.SystemColors.Control;
            this.DaysLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DaysLabel.Location = new System.Drawing.Point(659, 150);
            this.DaysLabel.Name = "DaysLabel";
            this.DaysLabel.Size = new System.Drawing.Size(56, 29);
            this.DaysLabel.TabIndex = 47;
            this.DaysLabel.Text = "дней";
            this.DaysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Planning_Record_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 471);
            this.Controls.Add(this.DaysLabel);
            this.Controls.Add(this.Days);
            this.Controls.Add(this.TimesLabel);
            this.Controls.Add(this.Times);
            this.Controls.Add(this.FrequencyLabel);
            this.Controls.Add(this.Commentary);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.CommentaryLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Today);
            this.Controls.Add(this.CurrentState);
            this.Controls.Add(this.AddSubBar);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.CurrentStateBar);
            this.Controls.Add(this.ActiveButton);
            this.Controls.Add(this.Planning);
            this.Controls.Add(this.History);
            this.Controls.Add(this.SideBarBG);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(690, 500);
            this.Name = "Planning_Record_Screen";
            this.Text = "Добавить новый пункт";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Planning_Record_Screen_Closed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Planning_Record_Screen_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Save;
        private System.Windows.Forms.Label Cancel;
        private System.Windows.Forms.Label Today;
        private System.Windows.Forms.Label CurrentState;
        private System.Windows.Forms.Label AddSubBar;
        private System.Windows.Forms.Label Account;
        private System.Windows.Forms.Label CurrentStateBar;
        private System.Windows.Forms.Label ActiveButton;
        private System.Windows.Forms.Label Planning;
        private System.Windows.Forms.Label History;
        private System.Windows.Forms.Label SideBarBG;
        private System.Windows.Forms.TextBox Commentary;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Label CommentaryLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label FrequencyLabel;
        private System.Windows.Forms.TextBox Times;
        private System.Windows.Forms.Label TimesLabel;
        private System.Windows.Forms.TextBox Days;
        private System.Windows.Forms.Label DaysLabel;
    }
}
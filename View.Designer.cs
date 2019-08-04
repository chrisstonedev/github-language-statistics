namespace GitHubLanguageStatistics
{
    partial class View
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
            System.Windows.Forms.TableLayoutPanel userNameTableLayoutPanel;
            System.Windows.Forms.Label userNameLabel;
            this.projectsDataGridView = new System.Windows.Forms.DataGridView();
            this.titleLabel = new System.Windows.Forms.Label();
            this.linesOfCodeDataGridView = new System.Windows.Forms.DataGridView();
            this.submitButton = new System.Windows.Forms.Button();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.LinesOfCodeLanguageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinesOfCodeCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinesOfCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectLanguageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectPercentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectsPanel = new GitHubLanguageStatistics.SquareCanvas();
            this.linesOfCodePanel = new GitHubLanguageStatistics.SquareCanvas();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            userNameTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            userNameLabel = new System.Windows.Forms.Label();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesOfCodeDataGridView)).BeginInit();
            userNameTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(3, 67);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(271, 25);
            label1.TabIndex = 10;
            label1.Text = "Majority languages by project:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(3, 432);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(256, 25);
            label2.TabIndex = 11;
            label2.Text = "Languages by lines of code:";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(this.linesOfCodeDataGridView, 1, 4);
            tableLayoutPanel.Controls.Add(this.titleLabel, 0, 1);
            tableLayoutPanel.Controls.Add(this.projectsDataGridView, 1, 2);
            tableLayoutPanel.Controls.Add(this.projectsPanel, 0, 3);
            tableLayoutPanel.Controls.Add(this.linesOfCodePanel, 0, 5);
            tableLayoutPanel.Controls.Add(userNameTableLayoutPanel, 0, 0);
            tableLayoutPanel.Controls.Add(label1, 0, 2);
            tableLayoutPanel.Controls.Add(label2, 0, 4);
            tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 6;
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel.Size = new System.Drawing.Size(995, 797);
            tableLayoutPanel.TabIndex = 5;
            // 
            // projectsDataGridView
            // 
            this.projectsDataGridView.AllowUserToAddRows = false;
            this.projectsDataGridView.AllowUserToDeleteRows = false;
            this.projectsDataGridView.AllowUserToResizeColumns = false;
            this.projectsDataGridView.AllowUserToResizeRows = false;
            this.projectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectLanguageColumn,
            this.ProjectCountColumn,
            this.ProjectPercentColumn});
            this.projectsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectsDataGridView.Location = new System.Drawing.Point(343, 70);
            this.projectsDataGridView.MultiSelect = false;
            this.projectsDataGridView.Name = "projectsDataGridView";
            this.projectsDataGridView.RowHeadersVisible = false;
            this.projectsDataGridView.RowHeadersWidth = 62;
            tableLayoutPanel.SetRowSpan(this.projectsDataGridView, 2);
            this.projectsDataGridView.RowTemplate.Height = 28;
            this.projectsDataGridView.Size = new System.Drawing.Size(649, 359);
            this.projectsDataGridView.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            tableLayoutPanel.SetColumnSpan(this.titleLabel, 2);
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(360, 42);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(274, 25);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "GitHub Language Statistics";
            // 
            // linesOfCodeDataGridView
            // 
            this.linesOfCodeDataGridView.AllowUserToAddRows = false;
            this.linesOfCodeDataGridView.AllowUserToDeleteRows = false;
            this.linesOfCodeDataGridView.AllowUserToResizeColumns = false;
            this.linesOfCodeDataGridView.AllowUserToResizeRows = false;
            this.linesOfCodeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.linesOfCodeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LinesOfCodeLanguageColumn,
            this.LinesOfCodeCountColumn,
            this.LinesOfCodeColumn});
            this.linesOfCodeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linesOfCodeDataGridView.Location = new System.Drawing.Point(343, 435);
            this.linesOfCodeDataGridView.MultiSelect = false;
            this.linesOfCodeDataGridView.Name = "linesOfCodeDataGridView";
            this.linesOfCodeDataGridView.RowHeadersVisible = false;
            this.linesOfCodeDataGridView.RowHeadersWidth = 62;
            tableLayoutPanel.SetRowSpan(this.linesOfCodeDataGridView, 2);
            this.linesOfCodeDataGridView.RowTemplate.Height = 28;
            this.linesOfCodeDataGridView.Size = new System.Drawing.Size(649, 359);
            this.linesOfCodeDataGridView.TabIndex = 6;
            // 
            // userNameTableLayoutPanel
            // 
            userNameTableLayoutPanel.AutoSize = true;
            userNameTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            userNameTableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.SetColumnSpan(userNameTableLayoutPanel, 2);
            userNameTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            userNameTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            userNameTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            userNameTableLayoutPanel.Controls.Add(this.submitButton, 2, 0);
            userNameTableLayoutPanel.Controls.Add(userNameLabel, 0, 0);
            userNameTableLayoutPanel.Controls.Add(this.userNameTextBox, 1, 0);
            userNameTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            userNameTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            userNameTableLayoutPanel.Name = "userNameTableLayoutPanel";
            userNameTableLayoutPanel.RowCount = 1;
            userNameTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            userNameTableLayoutPanel.Size = new System.Drawing.Size(989, 36);
            userNameTableLayoutPanel.TabIndex = 9;
            // 
            // submitButton
            // 
            this.submitButton.AutoSize = true;
            this.submitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submitButton.Location = new System.Drawing.Point(661, 3);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(69, 30);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "&Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            userNameLabel.Location = new System.Drawing.Point(3, 0);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(323, 36);
            userNameLabel.TabIndex = 1;
            userNameLabel.Text = "User name:";
            userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userNameTextBox.Location = new System.Drawing.Point(332, 3);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(323, 26);
            this.userNameTextBox.TabIndex = 2;
            // 
            // LinesOfCodeLanguageColumn
            // 
            this.LinesOfCodeLanguageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LinesOfCodeLanguageColumn.DataPropertyName = "LanguageName";
            this.LinesOfCodeLanguageColumn.HeaderText = "Language";
            this.LinesOfCodeLanguageColumn.MinimumWidth = 8;
            this.LinesOfCodeLanguageColumn.Name = "LinesOfCodeLanguageColumn";
            this.LinesOfCodeLanguageColumn.ReadOnly = true;
            // 
            // LinesOfCodeCountColumn
            // 
            this.LinesOfCodeCountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LinesOfCodeCountColumn.DataPropertyName = "Count";
            this.LinesOfCodeCountColumn.HeaderText = "Lines of code";
            this.LinesOfCodeCountColumn.MinimumWidth = 8;
            this.LinesOfCodeCountColumn.Name = "LinesOfCodeCountColumn";
            this.LinesOfCodeCountColumn.ReadOnly = true;
            this.LinesOfCodeCountColumn.Width = 140;
            // 
            // LinesOfCodeColumn
            // 
            this.LinesOfCodeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LinesOfCodeColumn.DataPropertyName = "Percent";
            this.LinesOfCodeColumn.HeaderText = "Percent";
            this.LinesOfCodeColumn.MinimumWidth = 8;
            this.LinesOfCodeColumn.Name = "LinesOfCodeColumn";
            this.LinesOfCodeColumn.ReadOnly = true;
            // 
            // ProjectLanguageColumn
            // 
            this.ProjectLanguageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProjectLanguageColumn.DataPropertyName = "LanguageName";
            this.ProjectLanguageColumn.HeaderText = "Language";
            this.ProjectLanguageColumn.MinimumWidth = 8;
            this.ProjectLanguageColumn.Name = "ProjectLanguageColumn";
            this.ProjectLanguageColumn.ReadOnly = true;
            // 
            // ProjectCountColumn
            // 
            this.ProjectCountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProjectCountColumn.DataPropertyName = "Count";
            this.ProjectCountColumn.HeaderText = "Projects";
            this.ProjectCountColumn.MinimumWidth = 8;
            this.ProjectCountColumn.Name = "ProjectCountColumn";
            this.ProjectCountColumn.ReadOnly = true;
            this.ProjectCountColumn.Width = 102;
            // 
            // ProjectPercentColumn
            // 
            this.ProjectPercentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProjectPercentColumn.DataPropertyName = "Percent";
            this.ProjectPercentColumn.HeaderText = "Percent";
            this.ProjectPercentColumn.MinimumWidth = 8;
            this.ProjectPercentColumn.Name = "ProjectPercentColumn";
            this.ProjectPercentColumn.ReadOnly = true;
            // 
            // projectsPanel
            // 
            this.projectsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectsPanel.Location = new System.Drawing.Point(3, 95);
            this.projectsPanel.Name = "projectsPanel";
            this.projectsPanel.Size = new System.Drawing.Size(334, 334);
            this.projectsPanel.TabIndex = 7;
            this.projectsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ProjectsPanel_Paint);
            // 
            // linesOfCodePanel
            // 
            this.linesOfCodePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linesOfCodePanel.Location = new System.Drawing.Point(3, 460);
            this.linesOfCodePanel.Name = "linesOfCodePanel";
            this.linesOfCodePanel.Size = new System.Drawing.Size(334, 334);
            this.linesOfCodePanel.TabIndex = 8;
            this.linesOfCodePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LinesOfCodePanel_Paint);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 797);
            this.Controls.Add(tableLayoutPanel);
            this.DoubleBuffered = true;
            this.Name = "View";
            this.Text = "GitHub Language Statistics";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesOfCodeDataGridView)).EndInit();
            userNameTableLayoutPanel.ResumeLayout(false);
            userNameTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView projectsDataGridView;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DataGridView linesOfCodeDataGridView;
        private GitHubLanguageStatistics.SquareCanvas projectsPanel;
        private GitHubLanguageStatistics.SquareCanvas linesOfCodePanel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinesOfCodeLanguageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinesOfCodeCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinesOfCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectLanguageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectPercentColumn;
    }
}


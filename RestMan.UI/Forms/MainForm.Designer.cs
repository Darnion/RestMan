namespace RestMan.UI.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finishShiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelFullname = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.buttonCloseShift = new System.Windows.Forms.Button();
            this.buttonDatabaseAccess = new System.Windows.Forms.Button();
            this.buttonReports = new System.Windows.Forms.Button();
            this.buttonStopList = new System.Windows.Forms.Button();
            this.buttonClosedOrders = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.splitterTop = new System.Windows.Forms.Splitter();
            this.splitterBottom = new System.Windows.Forms.Splitter();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.finishShiftToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip.ShowItemToolTips = true;
            this.menuStrip.Size = new System.Drawing.Size(697, 28);
            this.menuStrip.TabIndex = 0;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.ToolTipText = "Вернуться на окно авторизации";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.changePasswordToolStripMenuItem.Text = "Сменить пароль";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // finishShiftToolStripMenuItem
            // 
            this.finishShiftToolStripMenuItem.Name = "finishShiftToolStripMenuItem";
            this.finishShiftToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.finishShiftToolStripMenuItem.Text = "Закончить смену";
            this.finishShiftToolStripMenuItem.Click += new System.EventHandler(this.finishShiftToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelFullname,
            this.toolStripStatusLabelRole});
            this.statusStrip.Location = new System.Drawing.Point(0, 356);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.ShowItemToolTips = true;
            this.statusStrip.Size = new System.Drawing.Size(697, 23);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 1;
            // 
            // toolStripStatusLabelFullname
            // 
            this.toolStripStatusLabelFullname.Name = "toolStripStatusLabelFullname";
            this.toolStripStatusLabelFullname.Size = new System.Drawing.Size(43, 18);
            this.toolStripStatusLabelFullname.Text = "ФИО";
            this.toolStripStatusLabelFullname.ToolTipText = "Текущий пользователь";
            // 
            // toolStripStatusLabelRole
            // 
            this.toolStripStatusLabelRole.Name = "toolStripStatusLabelRole";
            this.toolStripStatusLabelRole.Size = new System.Drawing.Size(39, 18);
            this.toolStripStatusLabelRole.Text = "Роль";
            this.toolStripStatusLabelRole.ToolTipText = "Роль";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.Controls.Add(this.panelControls, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(697, 328);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.buttonCloseShift);
            this.panelControls.Controls.Add(this.buttonDatabaseAccess);
            this.panelControls.Controls.Add(this.buttonReports);
            this.panelControls.Controls.Add(this.buttonStopList);
            this.panelControls.Controls.Add(this.buttonClosedOrders);
            this.panelControls.Controls.Add(this.buttonOrders);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(212, 3);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(272, 322);
            this.panelControls.TabIndex = 0;
            // 
            // buttonCloseShift
            // 
            this.buttonCloseShift.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCloseShift.Location = new System.Drawing.Point(0, 230);
            this.buttonCloseShift.Name = "buttonCloseShift";
            this.buttonCloseShift.Size = new System.Drawing.Size(272, 46);
            this.buttonCloseShift.TabIndex = 5;
            this.buttonCloseShift.Text = "Закрыть смену";
            this.buttonCloseShift.UseVisualStyleBackColor = true;
            this.buttonCloseShift.Click += new System.EventHandler(this.buttonCloseShift_Click);
            // 
            // buttonDatabaseAccess
            // 
            this.buttonDatabaseAccess.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDatabaseAccess.Location = new System.Drawing.Point(0, 184);
            this.buttonDatabaseAccess.Name = "buttonDatabaseAccess";
            this.buttonDatabaseAccess.Size = new System.Drawing.Size(272, 46);
            this.buttonDatabaseAccess.TabIndex = 4;
            this.buttonDatabaseAccess.Text = "Изменение БД";
            this.buttonDatabaseAccess.UseVisualStyleBackColor = true;
            this.buttonDatabaseAccess.Click += new System.EventHandler(this.buttonDatabaseAccess_Click);
            // 
            // buttonReports
            // 
            this.buttonReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReports.Location = new System.Drawing.Point(0, 138);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Size = new System.Drawing.Size(272, 46);
            this.buttonReports.TabIndex = 3;
            this.buttonReports.Text = "Отчеты";
            this.buttonReports.UseVisualStyleBackColor = true;
            this.buttonReports.Click += new System.EventHandler(this.buttonReports_Click);
            // 
            // buttonStopList
            // 
            this.buttonStopList.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStopList.Location = new System.Drawing.Point(0, 92);
            this.buttonStopList.Name = "buttonStopList";
            this.buttonStopList.Size = new System.Drawing.Size(272, 46);
            this.buttonStopList.TabIndex = 2;
            this.buttonStopList.Text = "Стоп-лист";
            this.buttonStopList.UseVisualStyleBackColor = true;
            this.buttonStopList.Click += new System.EventHandler(this.buttonStopList_Click);
            // 
            // buttonClosedOrders
            // 
            this.buttonClosedOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClosedOrders.Location = new System.Drawing.Point(0, 46);
            this.buttonClosedOrders.Name = "buttonClosedOrders";
            this.buttonClosedOrders.Size = new System.Drawing.Size(272, 46);
            this.buttonClosedOrders.TabIndex = 1;
            this.buttonClosedOrders.Text = "Завершенные заказы";
            this.buttonClosedOrders.UseVisualStyleBackColor = true;
            this.buttonClosedOrders.Click += new System.EventHandler(this.buttonClosedOrders_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOrders.Location = new System.Drawing.Point(0, 0);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(272, 46);
            this.buttonOrders.TabIndex = 0;
            this.buttonOrders.Text = "Заказы";
            this.buttonOrders.UseVisualStyleBackColor = true;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // splitterTop
            // 
            this.splitterTop.BackColor = System.Drawing.Color.Black;
            this.splitterTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterTop.Enabled = false;
            this.splitterTop.Location = new System.Drawing.Point(0, 28);
            this.splitterTop.Name = "splitterTop";
            this.splitterTop.Size = new System.Drawing.Size(697, 1);
            this.splitterTop.TabIndex = 3;
            this.splitterTop.TabStop = false;
            // 
            // splitterBottom
            // 
            this.splitterBottom.BackColor = System.Drawing.Color.Black;
            this.splitterBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitterBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterBottom.Enabled = false;
            this.splitterBottom.Location = new System.Drawing.Point(0, 355);
            this.splitterBottom.Name = "splitterBottom";
            this.splitterBottom.Size = new System.Drawing.Size(697, 1);
            this.splitterBottom.TabIndex = 4;
            this.splitterBottom.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 379);
            this.Controls.Add(this.splitterBottom);
            this.Controls.Add(this.splitterTop);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(713, 418);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АСУР \"RestMan\"";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFullname;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRole;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button buttonDatabaseAccess;
        private System.Windows.Forms.Button buttonReports;
        private System.Windows.Forms.Button buttonStopList;
        private System.Windows.Forms.Button buttonClosedOrders;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button buttonCloseShift;
        private System.Windows.Forms.Splitter splitterTop;
        private System.Windows.Forms.Splitter splitterBottom;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finishShiftToolStripMenuItem;
    }
}


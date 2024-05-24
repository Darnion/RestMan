namespace RestMan.UI.Forms
{
    partial class EditOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditOrderForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelFullname = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelMenuItems = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewOrderMenuItems = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelControls = new System.Windows.Forms.Panel();
            this.buttonCloseOrder = new System.Windows.Forms.Button();
            this.buttonDeleteOrderMenuItem = new System.Windows.Forms.Button();
            this.buttonEditOrderMenuItem = new System.Windows.Forms.Button();
            this.buttonEditWaiter = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panelPayments = new System.Windows.Forms.Panel();
            this.groupBoxMenuSearch = new System.Windows.Forms.GroupBox();
            this.textBoxMenuSearch = new System.Windows.Forms.TextBox();
            this.buttonEditTable = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderMenuItems)).BeginInit();
            this.panelControls.SuspendLayout();
            this.groupBoxMenuSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip.ShowItemToolTips = true;
            this.menuStrip.Size = new System.Drawing.Size(990, 30);
            this.menuStrip.TabIndex = 4;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.exitToolStripMenuItem.Text = "Назад";
            this.exitToolStripMenuItem.ToolTipText = "Вернуться на прошлое окно";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelFullname,
            this.toolStripStatusLabelRole});
            this.statusStrip.Location = new System.Drawing.Point(0, 623);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.ShowItemToolTips = true;
            this.statusStrip.Size = new System.Drawing.Size(990, 23);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 5;
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
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanelMenuItems, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.dataGridViewOrderMenuItems, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.panelControls, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.panelInfo, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.panelPayments, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.groupBoxMenuSearch, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(990, 593);
            this.tableLayoutPanel.TabIndex = 6;
            // 
            // flowLayoutPanelMenuItems
            // 
            this.flowLayoutPanelMenuItems.AutoScroll = true;
            this.flowLayoutPanelMenuItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMenuItems.Location = new System.Drawing.Point(152, 359);
            this.flowLayoutPanelMenuItems.Name = "flowLayoutPanelMenuItems";
            this.flowLayoutPanelMenuItems.Size = new System.Drawing.Size(585, 230);
            this.flowLayoutPanelMenuItems.TabIndex = 0;
            // 
            // dataGridViewOrderMenuItems
            // 
            this.dataGridViewOrderMenuItems.AllowUserToAddRows = false;
            this.dataGridViewOrderMenuItems.AllowUserToDeleteRows = false;
            this.dataGridViewOrderMenuItems.AllowUserToResizeColumns = false;
            this.dataGridViewOrderMenuItems.AllowUserToResizeRows = false;
            this.dataGridViewOrderMenuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderMenuItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnTitle,
            this.ColumnCost,
            this.ColumnCount,
            this.ColumnTotal});
            this.dataGridViewOrderMenuItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrderMenuItems.Location = new System.Drawing.Point(152, 4);
            this.dataGridViewOrderMenuItems.Name = "dataGridViewOrderMenuItems";
            this.dataGridViewOrderMenuItems.ReadOnly = true;
            this.dataGridViewOrderMenuItems.Size = new System.Drawing.Size(585, 348);
            this.dataGridViewOrderMenuItems.TabIndex = 1;
            this.dataGridViewOrderMenuItems.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewOrderMenuItems_RowPostPaint);
            this.dataGridViewOrderMenuItems.SelectionChanged += new System.EventHandler(this.dataGridViewOrderMenuItems_SelectionChanged);
            this.dataGridViewOrderMenuItems.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridViewOrderMenuItems_Paint);
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "Id";
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // ColumnTitle
            // 
            this.ColumnTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnTitle.DataPropertyName = "Title";
            this.ColumnTitle.HeaderText = "Название";
            this.ColumnTitle.Name = "ColumnTitle";
            this.ColumnTitle.ReadOnly = true;
            this.ColumnTitle.Width = 97;
            // 
            // ColumnCost
            // 
            this.ColumnCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCost.DataPropertyName = "Cost";
            this.ColumnCost.HeaderText = "Цена";
            this.ColumnCost.Name = "ColumnCost";
            this.ColumnCost.ReadOnly = true;
            // 
            // ColumnCount
            // 
            this.ColumnCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCount.DataPropertyName = "Count";
            this.ColumnCount.HeaderText = "Количество";
            this.ColumnCount.Name = "ColumnCount";
            this.ColumnCount.ReadOnly = true;
            // 
            // ColumnTotal
            // 
            this.ColumnTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTotal.DataPropertyName = "Total";
            this.ColumnTotal.HeaderText = "Итого";
            this.ColumnTotal.Name = "ColumnTotal";
            this.ColumnTotal.ReadOnly = true;
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "Id";
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // ColumnTitle
            // 
            this.ColumnTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnTitle.DataPropertyName = "Title";
            this.ColumnTitle.HeaderText = "Название";
            this.ColumnTitle.Name = "ColumnTitle";
            this.ColumnTitle.ReadOnly = true;
            this.ColumnTitle.Width = 97;
            // 
            // ColumnCost
            // 
            this.ColumnCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCost.DataPropertyName = "Cost";
            this.ColumnCost.HeaderText = "Цена";
            this.ColumnCost.Name = "ColumnCost";
            this.ColumnCost.ReadOnly = true;
            // 
            // ColumnCount
            // 
            this.ColumnCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCount.DataPropertyName = "Count";
            this.ColumnCount.HeaderText = "Количество";
            this.ColumnCount.Name = "ColumnCount";
            this.ColumnCount.ReadOnly = true;
            // 
            // ColumnTotal
            // 
            this.ColumnTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTotal.DataPropertyName = "Total";
            this.ColumnTotal.HeaderText = "Итого";
            this.ColumnTotal.Name = "ColumnTotal";
            this.ColumnTotal.ReadOnly = true;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.buttonCloseOrder);
            this.panelControls.Controls.Add(this.buttonDeleteOrderMenuItem);
            this.panelControls.Controls.Add(this.buttonEditOrderMenuItem);
            this.panelControls.Controls.Add(this.buttonEditTable);
            this.panelControls.Controls.Add(this.buttonEditWaiter);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(744, 359);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(242, 230);
            this.panelControls.TabIndex = 3;
            // 
            // buttonCloseOrder
            // 
            this.buttonCloseOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCloseOrder.Location = new System.Drawing.Point(0, 184);
            this.buttonCloseOrder.Name = "buttonCloseOrder";
            this.buttonCloseOrder.Size = new System.Drawing.Size(242, 46);
            this.buttonCloseOrder.TabIndex = 3;
            this.buttonCloseOrder.Text = "Закрыть заказ";
            this.buttonCloseOrder.UseVisualStyleBackColor = true;
            this.buttonCloseOrder.Click += new System.EventHandler(this.buttonCloseOrder_Click);
            // 
            // buttonDeleteOrderMenuItem
            // 
            this.buttonDeleteOrderMenuItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDeleteOrderMenuItem.Enabled = false;
            this.buttonDeleteOrderMenuItem.Location = new System.Drawing.Point(0, 138);
            this.buttonDeleteOrderMenuItem.Name = "buttonDeleteOrderMenuItem";
            this.buttonDeleteOrderMenuItem.Size = new System.Drawing.Size(242, 46);
            this.buttonDeleteOrderMenuItem.TabIndex = 2;
            this.buttonDeleteOrderMenuItem.Text = "Удалить позиции";
            this.buttonDeleteOrderMenuItem.UseVisualStyleBackColor = true;
            this.buttonDeleteOrderMenuItem.Click += new System.EventHandler(this.buttonDeleteOrderMenuItem_Click);
            // 
            // buttonEditOrderMenuItem
            // 
            this.buttonEditOrderMenuItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEditOrderMenuItem.Enabled = false;
            this.buttonEditOrderMenuItem.Location = new System.Drawing.Point(0, 92);
            this.buttonEditOrderMenuItem.Name = "buttonEditOrderMenuItem";
            this.buttonEditOrderMenuItem.Size = new System.Drawing.Size(242, 46);
            this.buttonEditOrderMenuItem.TabIndex = 1;
            this.buttonEditOrderMenuItem.Text = "Изменить позицию";
            this.buttonEditOrderMenuItem.UseVisualStyleBackColor = true;
            this.buttonEditOrderMenuItem.Click += new System.EventHandler(this.buttonEditOrderMenuItem_Click);
            // 
            // buttonEditWaiter
            // 
            this.buttonEditWaiter.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEditWaiter.Location = new System.Drawing.Point(0, 0);
            this.buttonEditWaiter.Name = "buttonEditWaiter";
            this.buttonEditWaiter.Size = new System.Drawing.Size(242, 46);
            this.buttonEditWaiter.TabIndex = 0;
            this.buttonEditWaiter.Text = "Изменить официанта";
            this.buttonEditWaiter.UseVisualStyleBackColor = true;
            this.buttonEditWaiter.Click += new System.EventHandler(this.buttonEditWaiter_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(4, 4);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(141, 348);
            this.panelInfo.TabIndex = 4;
            // 
            // panelPayments
            // 
            this.panelPayments.BackColor = System.Drawing.SystemColors.Control;
            this.panelPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPayments.Location = new System.Drawing.Point(744, 4);
            this.panelPayments.Name = "panelPayments";
            this.panelPayments.Size = new System.Drawing.Size(242, 348);
            this.panelPayments.TabIndex = 5;
            // 
            // groupBoxMenuSearch
            // 
            this.groupBoxMenuSearch.Controls.Add(this.textBoxMenuSearch);
            this.groupBoxMenuSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMenuSearch.Location = new System.Drawing.Point(4, 359);
            this.groupBoxMenuSearch.Name = "groupBoxMenuSearch";
            this.groupBoxMenuSearch.Size = new System.Drawing.Size(141, 230);
            this.groupBoxMenuSearch.TabIndex = 6;
            this.groupBoxMenuSearch.TabStop = false;
            this.groupBoxMenuSearch.Text = "Поиск по меню";
            // 
            // textBoxMenuSearch
            // 
            this.textBoxMenuSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMenuSearch.Location = new System.Drawing.Point(6, 23);
            this.textBoxMenuSearch.Multiline = true;
            this.textBoxMenuSearch.Name = "textBoxMenuSearch";
            this.textBoxMenuSearch.Size = new System.Drawing.Size(129, 48);
            this.textBoxMenuSearch.TabIndex = 0;
            this.textBoxMenuSearch.TextChanged += new System.EventHandler(this.textBoxMenuSearch_TextChanged);
            // 
            // buttonEditTable
            // 
            this.buttonEditTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEditTable.Location = new System.Drawing.Point(0, 46);
            this.buttonEditTable.Name = "buttonEditTable";
            this.buttonEditTable.Size = new System.Drawing.Size(242, 46);
            this.buttonEditTable.TabIndex = 1;
            this.buttonEditTable.Text = "Изменить стол";
            this.buttonEditTable.UseVisualStyleBackColor = true;
            this.buttonEditTable.Click += new System.EventHandler(this.buttonEditTable_Click);
            // 
            // EditOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 646);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1006, 685);
            this.Name = "EditOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditOrderForm_FormClosing);
            this.Load += new System.EventHandler(this.EditOrderForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderMenuItems)).EndInit();
            this.panelControls.ResumeLayout(false);
            this.groupBoxMenuSearch.ResumeLayout(false);
            this.groupBoxMenuSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFullname;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRole;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenuItems;
        private System.Windows.Forms.DataGridView dataGridViewOrderMenuItems;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button buttonEditWaiter;
        private System.Windows.Forms.Button buttonEditOrderMenuItem;
        private System.Windows.Forms.Button buttonDeleteOrderMenuItem;
        private System.Windows.Forms.Button buttonCloseOrder;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelPayments;
        private System.Windows.Forms.GroupBox groupBoxMenuSearch;
        private System.Windows.Forms.TextBox textBoxMenuSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotal;
        private System.Windows.Forms.Button buttonEditTable;
    }
}
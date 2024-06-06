namespace RestMan.UI.Forms
{
    partial class StopListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StopListForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelFullname = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewStopList = new System.Windows.Forms.DataGridView();
            this.ColumnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanelActualList = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxStopListFilter = new System.Windows.Forms.GroupBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.labelShop = new System.Windows.Forms.Label();
            this.comboBoxShops = new System.Windows.Forms.ComboBox();
            this.textBoxStopListSearch = new System.Windows.Forms.TextBox();
            this.buttonDeleteFromStopList = new System.Windows.Forms.Button();
            this.groupBoxActualListFilter = new System.Windows.Forms.GroupBox();
            this.textBoxActualListSearch = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStopList)).BeginInit();
            this.groupBoxStopListFilter.SuspendLayout();
            this.groupBoxActualListFilter.SuspendLayout();
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
            this.menuStrip.Size = new System.Drawing.Size(867, 30);
            this.menuStrip.TabIndex = 3;
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
            this.statusStrip.Location = new System.Drawing.Point(0, 568);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.ShowItemToolTips = true;
            this.statusStrip.Size = new System.Drawing.Size(867, 23);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 4;
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
            this.tableLayoutPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.Controls.Add(this.dataGridViewStopList, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanelActualList, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.groupBoxStopListFilter, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.groupBoxActualListFilter, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(867, 538);
            this.tableLayoutPanel.TabIndex = 5;
            // 
            // dataGridViewStopList
            // 
            this.dataGridViewStopList.AllowUserToAddRows = false;
            this.dataGridViewStopList.AllowUserToDeleteRows = false;
            this.dataGridViewStopList.AllowUserToResizeColumns = false;
            this.dataGridViewStopList.AllowUserToResizeRows = false;
            this.dataGridViewStopList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStopList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTitle,
            this.ColumnCost});
            this.dataGridViewStopList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStopList.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewStopList.Name = "dataGridViewStopList";
            this.dataGridViewStopList.ReadOnly = true;
            this.dataGridViewStopList.RowHeadersVisible = false;
            this.dataGridViewStopList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStopList.Size = new System.Drawing.Size(512, 315);
            this.dataGridViewStopList.TabIndex = 0;
            this.dataGridViewStopList.SelectionChanged += new System.EventHandler(this.dataGridViewStopList_SelectionChanged);
            // 
            // ColumnTitle
            // 
            this.ColumnTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTitle.DataPropertyName = "Title";
            this.ColumnTitle.HeaderText = "Название";
            this.ColumnTitle.Name = "ColumnTitle";
            this.ColumnTitle.ReadOnly = true;
            // 
            // ColumnCost
            // 
            this.ColumnCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnCost.DataPropertyName = "Cost";
            this.ColumnCost.HeaderText = "Стоимость";
            this.ColumnCost.Name = "ColumnCost";
            this.ColumnCost.ReadOnly = true;
            this.ColumnCost.Width = 105;
            // 
            // flowLayoutPanelActualList
            // 
            this.flowLayoutPanelActualList.AutoScroll = true;
            this.flowLayoutPanelActualList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelActualList.Location = new System.Drawing.Point(4, 326);
            this.flowLayoutPanelActualList.Name = "flowLayoutPanelActualList";
            this.flowLayoutPanelActualList.Size = new System.Drawing.Size(512, 208);
            this.flowLayoutPanelActualList.TabIndex = 1;
            // 
            // groupBoxStopListFilter
            // 
            this.groupBoxStopListFilter.Controls.Add(this.labelCategory);
            this.groupBoxStopListFilter.Controls.Add(this.comboBoxCategories);
            this.groupBoxStopListFilter.Controls.Add(this.labelShop);
            this.groupBoxStopListFilter.Controls.Add(this.comboBoxShops);
            this.groupBoxStopListFilter.Controls.Add(this.textBoxStopListSearch);
            this.groupBoxStopListFilter.Controls.Add(this.buttonDeleteFromStopList);
            this.groupBoxStopListFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxStopListFilter.Location = new System.Drawing.Point(523, 4);
            this.groupBoxStopListFilter.Name = "groupBoxStopListFilter";
            this.groupBoxStopListFilter.Size = new System.Drawing.Size(340, 315);
            this.groupBoxStopListFilter.TabIndex = 2;
            this.groupBoxStopListFilter.TabStop = false;
            this.groupBoxStopListFilter.Text = "Поиск по стоп-листу";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(7, 123);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(81, 18);
            this.labelCategory.TabIndex = 5;
            this.labelCategory.Text = "Категория:";
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(9, 152);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(325, 25);
            this.comboBoxCategories.TabIndex = 4;
            this.comboBoxCategories.SelectedIndexChanged += new System.EventHandler(this.textBoxStopListSearch_TextChanged);
            // 
            // labelShop
            // 
            this.labelShop.AutoSize = true;
            this.labelShop.Location = new System.Drawing.Point(6, 58);
            this.labelShop.Name = "labelShop";
            this.labelShop.Size = new System.Drawing.Size(37, 18);
            this.labelShop.TabIndex = 3;
            this.labelShop.Text = "Цех:";
            // 
            // comboBoxShops
            // 
            this.comboBoxShops.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxShops.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShops.FormattingEnabled = true;
            this.comboBoxShops.Location = new System.Drawing.Point(8, 87);
            this.comboBoxShops.Name = "comboBoxShops";
            this.comboBoxShops.Size = new System.Drawing.Size(325, 25);
            this.comboBoxShops.TabIndex = 2;
            this.comboBoxShops.SelectedIndexChanged += new System.EventHandler(this.comboBoxShops_SelectedIndexChanged);
            // 
            // textBoxStopListSearch
            // 
            this.textBoxStopListSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStopListSearch.Location = new System.Drawing.Point(8, 23);
            this.textBoxStopListSearch.Name = "textBoxStopListSearch";
            this.textBoxStopListSearch.Size = new System.Drawing.Size(325, 24);
            this.textBoxStopListSearch.TabIndex = 1;
            this.textBoxStopListSearch.TextChanged += new System.EventHandler(this.textBoxStopListSearch_TextChanged);
            // 
            // buttonDeleteFromStopList
            // 
            this.buttonDeleteFromStopList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteFromStopList.Location = new System.Drawing.Point(81, 276);
            this.buttonDeleteFromStopList.Name = "buttonDeleteFromStopList";
            this.buttonDeleteFromStopList.Size = new System.Drawing.Size(178, 33);
            this.buttonDeleteFromStopList.TabIndex = 0;
            this.buttonDeleteFromStopList.Text = "Убрать из стоп-листа";
            this.buttonDeleteFromStopList.UseVisualStyleBackColor = true;
            this.buttonDeleteFromStopList.Visible = false;
            this.buttonDeleteFromStopList.Click += new System.EventHandler(this.buttonDeleteFromStopList_Click);
            // 
            // groupBoxActualListFilter
            // 
            this.groupBoxActualListFilter.Controls.Add(this.textBoxActualListSearch);
            this.groupBoxActualListFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxActualListFilter.Location = new System.Drawing.Point(523, 326);
            this.groupBoxActualListFilter.Name = "groupBoxActualListFilter";
            this.groupBoxActualListFilter.Size = new System.Drawing.Size(340, 208);
            this.groupBoxActualListFilter.TabIndex = 3;
            this.groupBoxActualListFilter.TabStop = false;
            this.groupBoxActualListFilter.Text = "Поиск по актуальным позициям";
            // 
            // textBoxActualListSearch
            // 
            this.textBoxActualListSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxActualListSearch.Location = new System.Drawing.Point(8, 23);
            this.textBoxActualListSearch.Name = "textBoxActualListSearch";
            this.textBoxActualListSearch.Size = new System.Drawing.Size(325, 24);
            this.textBoxActualListSearch.TabIndex = 0;
            this.textBoxActualListSearch.TextChanged += new System.EventHandler(this.textBoxActualListSearch_TextChanged);
            // 
            // StopListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 591);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(883, 630);
            this.Name = "StopListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Стоп-лист";
            this.Load += new System.EventHandler(this.StopListForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStopList)).EndInit();
            this.groupBoxStopListFilter.ResumeLayout(false);
            this.groupBoxStopListFilter.PerformLayout();
            this.groupBoxActualListFilter.ResumeLayout(false);
            this.groupBoxActualListFilter.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridViewStopList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelActualList;
        private System.Windows.Forms.GroupBox groupBoxStopListFilter;
        private System.Windows.Forms.GroupBox groupBoxActualListFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCost;
        private System.Windows.Forms.Button buttonDeleteFromStopList;
        private System.Windows.Forms.TextBox textBoxActualListSearch;
        private System.Windows.Forms.TextBox textBoxStopListSearch;
        private System.Windows.Forms.Label labelShop;
        private System.Windows.Forms.ComboBox comboBoxShops;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox comboBoxCategories;
    }
}
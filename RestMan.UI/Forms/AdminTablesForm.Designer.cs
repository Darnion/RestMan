namespace RestMan.UI.Forms
{
    partial class AdminTablesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminTablesForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelFullname = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewTables = new System.Windows.Forms.DataGridView();
            this.ColumnHall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelControls = new System.Windows.Forms.Panel();
            this.buttonAddTable = new System.Windows.Forms.Button();
            this.groupBoxHall = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxAcronym = new System.Windows.Forms.TextBox();
            this.labelAcronym = new System.Windows.Forms.Label();
            this.comboBoxHall = new System.Windows.Forms.ComboBox();
            this.buttonDeleteTable = new System.Windows.Forms.Button();
            this.buttonDeleteHall = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTables)).BeginInit();
            this.panelControls.SuspendLayout();
            this.groupBoxHall.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip.ShowItemToolTips = true;
            this.menuStrip.Size = new System.Drawing.Size(646, 28);
            this.menuStrip.TabIndex = 6;
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
            this.statusStrip.Location = new System.Drawing.Point(0, 376);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.ShowItemToolTips = true;
            this.statusStrip.Size = new System.Drawing.Size(646, 23);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 7;
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
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.Controls.Add(this.dataGridViewTables, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.panelControls, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(646, 348);
            this.tableLayoutPanel.TabIndex = 8;
            // 
            // dataGridViewTables
            // 
            this.dataGridViewTables.AllowUserToAddRows = false;
            this.dataGridViewTables.AllowUserToDeleteRows = false;
            this.dataGridViewTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnHall,
            this.ColumnTable});
            this.dataGridViewTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTables.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewTables.Name = "dataGridViewTables";
            this.dataGridViewTables.ReadOnly = true;
            this.dataGridViewTables.RowHeadersVisible = false;
            this.dataGridViewTables.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTables.Size = new System.Drawing.Size(446, 342);
            this.dataGridViewTables.TabIndex = 0;
            // 
            // ColumnHall
            // 
            this.ColumnHall.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnHall.DataPropertyName = "Hall";
            this.ColumnHall.HeaderText = "Зал";
            this.ColumnHall.Name = "ColumnHall";
            this.ColumnHall.ReadOnly = true;
            // 
            // ColumnTable
            // 
            this.ColumnTable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnTable.DataPropertyName = "Title";
            this.ColumnTable.HeaderText = "Стол";
            this.ColumnTable.Name = "ColumnTable";
            this.ColumnTable.ReadOnly = true;
            this.ColumnTable.Width = 66;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.buttonAddTable);
            this.panelControls.Controls.Add(this.groupBoxHall);
            this.panelControls.Controls.Add(this.buttonDeleteTable);
            this.panelControls.Controls.Add(this.buttonDeleteHall);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(455, 3);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(188, 342);
            this.panelControls.TabIndex = 1;
            // 
            // buttonAddTable
            // 
            this.buttonAddTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAddTable.Location = new System.Drawing.Point(0, 264);
            this.buttonAddTable.Name = "buttonAddTable";
            this.buttonAddTable.Size = new System.Drawing.Size(188, 26);
            this.buttonAddTable.TabIndex = 1;
            this.buttonAddTable.Text = "Добавить стол";
            this.buttonAddTable.UseVisualStyleBackColor = true;
            this.buttonAddTable.Click += new System.EventHandler(this.buttonAddTable_Click);
            // 
            // groupBoxHall
            // 
            this.groupBoxHall.Controls.Add(this.buttonSave);
            this.groupBoxHall.Controls.Add(this.textBoxAcronym);
            this.groupBoxHall.Controls.Add(this.labelAcronym);
            this.groupBoxHall.Controls.Add(this.comboBoxHall);
            this.groupBoxHall.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxHall.Location = new System.Drawing.Point(0, 0);
            this.groupBoxHall.Name = "groupBoxHall";
            this.groupBoxHall.Size = new System.Drawing.Size(188, 136);
            this.groupBoxHall.TabIndex = 0;
            this.groupBoxHall.TabStop = false;
            this.groupBoxHall.Text = "Зал";
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSave.Location = new System.Drawing.Point(3, 107);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(182, 26);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxAcronym
            // 
            this.textBoxAcronym.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxAcronym.Location = new System.Drawing.Point(3, 65);
            this.textBoxAcronym.Name = "textBoxAcronym";
            this.textBoxAcronym.Size = new System.Drawing.Size(182, 24);
            this.textBoxAcronym.TabIndex = 2;
            this.textBoxAcronym.TextChanged += new System.EventHandler(this.textBoxAcronym_TextChanged);
            // 
            // labelAcronym
            // 
            this.labelAcronym.AutoSize = true;
            this.labelAcronym.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAcronym.Location = new System.Drawing.Point(3, 45);
            this.labelAcronym.Name = "labelAcronym";
            this.labelAcronym.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.labelAcronym.Size = new System.Drawing.Size(93, 20);
            this.labelAcronym.TabIndex = 1;
            this.labelAcronym.Text = "Сокращение";
            // 
            // comboBoxHall
            // 
            this.comboBoxHall.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxHall.FormattingEnabled = true;
            this.comboBoxHall.Location = new System.Drawing.Point(3, 20);
            this.comboBoxHall.Name = "comboBoxHall";
            this.comboBoxHall.Size = new System.Drawing.Size(182, 25);
            this.comboBoxHall.TabIndex = 0;
            this.comboBoxHall.SelectedIndexChanged += new System.EventHandler(this.comboBoxHall_SelectedIndexChanged);
            this.comboBoxHall.TextUpdate += new System.EventHandler(this.comboBoxHall_SelectedIndexChanged);
            this.comboBoxHall.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxHall_KeyPress);
            this.comboBoxHall.Leave += new System.EventHandler(this.comboBoxHall_Leave);
            // 
            // buttonDeleteTable
            // 
            this.buttonDeleteTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonDeleteTable.Location = new System.Drawing.Point(0, 290);
            this.buttonDeleteTable.Name = "buttonDeleteTable";
            this.buttonDeleteTable.Size = new System.Drawing.Size(188, 26);
            this.buttonDeleteTable.TabIndex = 2;
            this.buttonDeleteTable.Text = "Удалить стол";
            this.buttonDeleteTable.UseVisualStyleBackColor = true;
            this.buttonDeleteTable.Click += new System.EventHandler(this.buttonDeleteTable_Click);
            // 
            // buttonDeleteHall
            // 
            this.buttonDeleteHall.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonDeleteHall.Location = new System.Drawing.Point(0, 316);
            this.buttonDeleteHall.Name = "buttonDeleteHall";
            this.buttonDeleteHall.Size = new System.Drawing.Size(188, 26);
            this.buttonDeleteHall.TabIndex = 3;
            this.buttonDeleteHall.Text = "Удалить зал";
            this.buttonDeleteHall.UseVisualStyleBackColor = true;
            this.buttonDeleteHall.Click += new System.EventHandler(this.buttonDeleteHall_Click);
            // 
            // AdminTablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 399);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminTablesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Столы";
            this.Load += new System.EventHandler(this.AdminTablesForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTables)).EndInit();
            this.panelControls.ResumeLayout(false);
            this.groupBoxHall.ResumeLayout(false);
            this.groupBoxHall.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridViewTables;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHall;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTable;
        private System.Windows.Forms.GroupBox groupBoxHall;
        private System.Windows.Forms.ComboBox comboBoxHall;
        private System.Windows.Forms.Label labelAcronym;
        private System.Windows.Forms.TextBox textBoxAcronym;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAddTable;
        private System.Windows.Forms.Button buttonDeleteTable;
        private System.Windows.Forms.Button buttonDeleteHall;
    }
}
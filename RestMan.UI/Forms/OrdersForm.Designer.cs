namespace RestMan.UI.Forms
{
    partial class OrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelFullname = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitterTop = new System.Windows.Forms.Splitter();
            this.splitterBottom = new System.Windows.Forms.Splitter();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.groupBoxSort = new System.Windows.Forms.GroupBox();
            this.radioButtonDesc = new System.Windows.Forms.RadioButton();
            this.radioButtonAsc = new System.Windows.Forms.RadioButton();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.labelPadding = new System.Windows.Forms.Label();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.comboBoxWaiter = new System.Windows.Forms.ComboBox();
            this.labelWaiter = new System.Windows.Forms.Label();
            this.comboBoxTable = new System.Windows.Forms.ComboBox();
            this.labelTable = new System.Windows.Forms.Label();
            this.comboBoxHalls = new System.Windows.Forms.ComboBox();
            this.labelHall = new System.Windows.Forms.Label();
            this.flowLayoutPanelOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.groupBoxSort.SuspendLayout();
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
            this.menuStrip.Size = new System.Drawing.Size(866, 28);
            this.menuStrip.TabIndex = 1;
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
            this.statusStrip.Location = new System.Drawing.Point(0, 663);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.ShowItemToolTips = true;
            this.statusStrip.Size = new System.Drawing.Size(866, 23);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 2;
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
            // splitterTop
            // 
            this.splitterTop.BackColor = System.Drawing.Color.Black;
            this.splitterTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterTop.Enabled = false;
            this.splitterTop.Location = new System.Drawing.Point(0, 28);
            this.splitterTop.Name = "splitterTop";
            this.splitterTop.Size = new System.Drawing.Size(866, 1);
            this.splitterTop.TabIndex = 4;
            this.splitterTop.TabStop = false;
            // 
            // splitterBottom
            // 
            this.splitterBottom.BackColor = System.Drawing.Color.Black;
            this.splitterBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitterBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterBottom.Enabled = false;
            this.splitterBottom.Location = new System.Drawing.Point(0, 662);
            this.splitterBottom.Name = "splitterBottom";
            this.splitterBottom.Size = new System.Drawing.Size(866, 1);
            this.splitterBottom.TabIndex = 5;
            this.splitterBottom.TabStop = false;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel.Controls.Add(this.panelControls, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanelOrders, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 29);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(866, 633);
            this.tableLayoutPanel.TabIndex = 6;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.groupBoxSort);
            this.panelControls.Controls.Add(this.labelPadding);
            this.panelControls.Controls.Add(this.buttonAddOrder);
            this.panelControls.Controls.Add(this.textBoxTotal);
            this.panelControls.Controls.Add(this.labelTotal);
            this.panelControls.Controls.Add(this.comboBoxWaiter);
            this.panelControls.Controls.Add(this.labelWaiter);
            this.panelControls.Controls.Add(this.comboBoxTable);
            this.panelControls.Controls.Add(this.labelTable);
            this.panelControls.Controls.Add(this.comboBoxHalls);
            this.panelControls.Controls.Add(this.labelHall);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(4, 4);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(209, 625);
            this.panelControls.TabIndex = 0;
            // 
            // groupBoxSort
            // 
            this.groupBoxSort.Controls.Add(this.radioButtonDesc);
            this.groupBoxSort.Controls.Add(this.radioButtonAsc);
            this.groupBoxSort.Controls.Add(this.comboBoxSort);
            this.groupBoxSort.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSort.Location = new System.Drawing.Point(0, 291);
            this.groupBoxSort.Name = "groupBoxSort";
            this.groupBoxSort.Size = new System.Drawing.Size(209, 92);
            this.groupBoxSort.TabIndex = 8;
            this.groupBoxSort.TabStop = false;
            this.groupBoxSort.Text = "Сортировка";
            // 
            // radioButtonDesc
            // 
            this.radioButtonDesc.AutoSize = true;
            this.radioButtonDesc.Checked = true;
            this.radioButtonDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonDesc.Location = new System.Drawing.Point(3, 67);
            this.radioButtonDesc.Name = "radioButtonDesc";
            this.radioButtonDesc.Size = new System.Drawing.Size(203, 22);
            this.radioButtonDesc.TabIndex = 6;
            this.radioButtonDesc.TabStop = true;
            this.radioButtonDesc.Text = "По убыванию";
            this.radioButtonDesc.UseVisualStyleBackColor = true;
            // 
            // radioButtonAsc
            // 
            this.radioButtonAsc.AutoSize = true;
            this.radioButtonAsc.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButtonAsc.Location = new System.Drawing.Point(3, 45);
            this.radioButtonAsc.Name = "radioButtonAsc";
            this.radioButtonAsc.Size = new System.Drawing.Size(203, 22);
            this.radioButtonAsc.TabIndex = 5;
            this.radioButtonAsc.Text = "По возрастанию";
            this.radioButtonAsc.UseVisualStyleBackColor = true;
            this.radioButtonAsc.CheckedChanged += new System.EventHandler(this.radioButtonAsc_CheckedChanged);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "По времени создания",
            "По сумме",
            "По столу"});
            this.comboBoxSort.Location = new System.Drawing.Point(3, 20);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(203, 25);
            this.comboBoxSort.TabIndex = 4;
            this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
            // 
            // labelPadding
            // 
            this.labelPadding.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPadding.Location = new System.Drawing.Point(0, 266);
            this.labelPadding.Name = "labelPadding";
            this.labelPadding.Size = new System.Drawing.Size(209, 25);
            this.labelPadding.TabIndex = 7;
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAddOrder.Location = new System.Drawing.Point(0, 585);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(209, 40);
            this.buttonAddOrder.TabIndex = 2;
            this.buttonAddOrder.Text = "Добавить заказ";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxTotal.Location = new System.Drawing.Point(0, 242);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(209, 24);
            this.textBoxTotal.TabIndex = 6;
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxTotal.TextChanged += new System.EventHandler(this.comboBoxHalls_SelectedIndexChanged);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTotal.Location = new System.Drawing.Point(0, 194);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Padding = new System.Windows.Forms.Padding(0, 25, 0, 5);
            this.labelTotal.Size = new System.Drawing.Size(84, 48);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Стоимость:";
            // 
            // comboBoxWaiter
            // 
            this.comboBoxWaiter.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxWaiter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWaiter.FormattingEnabled = true;
            this.comboBoxWaiter.Location = new System.Drawing.Point(0, 169);
            this.comboBoxWaiter.Name = "comboBoxWaiter";
            this.comboBoxWaiter.Size = new System.Drawing.Size(209, 25);
            this.comboBoxWaiter.TabIndex = 3;
            this.comboBoxWaiter.SelectedIndexChanged += new System.EventHandler(this.comboBoxHalls_SelectedIndexChanged);
            // 
            // labelWaiter
            // 
            this.labelWaiter.AutoSize = true;
            this.labelWaiter.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelWaiter.Location = new System.Drawing.Point(0, 121);
            this.labelWaiter.Name = "labelWaiter";
            this.labelWaiter.Padding = new System.Windows.Forms.Padding(0, 25, 0, 5);
            this.labelWaiter.Size = new System.Drawing.Size(85, 48);
            this.labelWaiter.TabIndex = 4;
            this.labelWaiter.Text = "Официант:";
            // 
            // comboBoxTable
            // 
            this.comboBoxTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTable.FormattingEnabled = true;
            this.comboBoxTable.Location = new System.Drawing.Point(0, 96);
            this.comboBoxTable.Name = "comboBoxTable";
            this.comboBoxTable.Size = new System.Drawing.Size(209, 25);
            this.comboBoxTable.TabIndex = 3;
            this.comboBoxTable.Visible = false;
            this.comboBoxTable.SelectedIndexChanged += new System.EventHandler(this.comboBoxHalls_SelectedIndexChanged);
            // 
            // labelTable
            // 
            this.labelTable.AutoSize = true;
            this.labelTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTable.Location = new System.Drawing.Point(0, 48);
            this.labelTable.Name = "labelTable";
            this.labelTable.Padding = new System.Windows.Forms.Padding(0, 25, 0, 5);
            this.labelTable.Size = new System.Drawing.Size(45, 48);
            this.labelTable.TabIndex = 4;
            this.labelTable.Text = "Стол:";
            this.labelTable.Visible = false;
            // 
            // comboBoxHalls
            // 
            this.comboBoxHalls.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxHalls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHalls.FormattingEnabled = true;
            this.comboBoxHalls.Location = new System.Drawing.Point(0, 23);
            this.comboBoxHalls.Name = "comboBoxHalls";
            this.comboBoxHalls.Size = new System.Drawing.Size(209, 25);
            this.comboBoxHalls.TabIndex = 0;
            this.comboBoxHalls.SelectedIndexChanged += new System.EventHandler(this.comboBoxHalls_SelectedIndexChanged);
            // 
            // labelHall
            // 
            this.labelHall.AutoSize = true;
            this.labelHall.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHall.Location = new System.Drawing.Point(0, 0);
            this.labelHall.Name = "labelHall";
            this.labelHall.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.labelHall.Size = new System.Drawing.Size(35, 23);
            this.labelHall.TabIndex = 1;
            this.labelHall.Text = "Зал:";
            // 
            // flowLayoutPanelOrders
            // 
            this.flowLayoutPanelOrders.AutoScroll = true;
            this.flowLayoutPanelOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelOrders.Location = new System.Drawing.Point(220, 4);
            this.flowLayoutPanelOrders.Name = "flowLayoutPanelOrders";
            this.flowLayoutPanelOrders.Size = new System.Drawing.Size(642, 625);
            this.flowLayoutPanelOrders.TabIndex = 1;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 686);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.splitterBottom);
            this.Controls.Add(this.splitterTop);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(882, 725);
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.VisibleChanged += new System.EventHandler(this.OrdersForm_VisibleChanged);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.groupBoxSort.ResumeLayout(false);
            this.groupBoxSort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFullname;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRole;
        private System.Windows.Forms.Splitter splitterTop;
        private System.Windows.Forms.Splitter splitterBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOrders;
        private System.Windows.Forms.ComboBox comboBoxHalls;
        private System.Windows.Forms.Label labelHall;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.Label labelWaiter;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.ComboBox comboBoxTable;
        private System.Windows.Forms.Label labelTable;
        private System.Windows.Forms.Label labelPadding;
        private System.Windows.Forms.GroupBox groupBoxSort;
        private System.Windows.Forms.RadioButton radioButtonDesc;
        private System.Windows.Forms.RadioButton radioButtonAsc;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.ComboBox comboBoxWaiter;
    }
}
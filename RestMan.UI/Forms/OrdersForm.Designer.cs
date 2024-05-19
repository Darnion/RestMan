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
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.labelHall = new System.Windows.Forms.Label();
            this.comboBoxHalls = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanelOrders = new System.Windows.Forms.FlowLayoutPanel();
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
            this.statusStrip.Location = new System.Drawing.Point(0, 573);
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
            this.splitterBottom.Location = new System.Drawing.Point(0, 572);
            this.splitterBottom.Name = "splitterBottom";
            this.splitterBottom.Size = new System.Drawing.Size(866, 1);
            this.splitterBottom.TabIndex = 5;
            this.splitterBottom.TabStop = false;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel.Controls.Add(this.panelControls, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanelOrders, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 29);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(866, 543);
            this.tableLayoutPanel.TabIndex = 6;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.buttonAddOrder);
            this.panelControls.Controls.Add(this.labelHall);
            this.panelControls.Controls.Add(this.comboBoxHalls);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(4, 4);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(166, 535);
            this.panelControls.TabIndex = 0;
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAddOrder.Location = new System.Drawing.Point(0, 495);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(166, 40);
            this.buttonAddOrder.TabIndex = 2;
            this.buttonAddOrder.Text = "Добавить заказ";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // labelHall
            // 
            this.labelHall.AutoSize = true;
            this.labelHall.Location = new System.Drawing.Point(-3, 0);
            this.labelHall.Name = "labelHall";
            this.labelHall.Size = new System.Drawing.Size(35, 18);
            this.labelHall.TabIndex = 1;
            this.labelHall.Text = "Зал:";
            // 
            // comboBoxHalls
            // 
            this.comboBoxHalls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxHalls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHalls.FormattingEnabled = true;
            this.comboBoxHalls.Location = new System.Drawing.Point(0, 21);
            this.comboBoxHalls.Name = "comboBoxHalls";
            this.comboBoxHalls.Size = new System.Drawing.Size(166, 25);
            this.comboBoxHalls.TabIndex = 0;
            this.comboBoxHalls.SelectedIndexChanged += new System.EventHandler(this.comboBoxHalls_SelectedIndexChanged);
            // 
            // flowLayoutPanelOrders
            // 
            this.flowLayoutPanelOrders.AutoScroll = true;
            this.flowLayoutPanelOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelOrders.Location = new System.Drawing.Point(177, 4);
            this.flowLayoutPanelOrders.Name = "flowLayoutPanelOrders";
            this.flowLayoutPanelOrders.Size = new System.Drawing.Size(685, 535);
            this.flowLayoutPanelOrders.TabIndex = 1;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 596);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.splitterBottom);
            this.Controls.Add(this.splitterTop);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
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
    }
}
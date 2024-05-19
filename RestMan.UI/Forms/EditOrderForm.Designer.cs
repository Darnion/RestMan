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
            this.dataGridViewPayments = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderMenuItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).BeginInit();
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
            this.menuStrip.Size = new System.Drawing.Size(869, 30);
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
            this.statusStrip.Location = new System.Drawing.Point(0, 565);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.ShowItemToolTips = true;
            this.statusStrip.Size = new System.Drawing.Size(869, 23);
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
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanelMenuItems, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.dataGridViewOrderMenuItems, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.dataGridViewPayments, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.button1, 2, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(869, 535);
            this.tableLayoutPanel.TabIndex = 6;
            // 
            // flowLayoutPanelMenuItems
            // 
            this.flowLayoutPanelMenuItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMenuItems.Location = new System.Drawing.Point(178, 324);
            this.flowLayoutPanelMenuItems.Name = "flowLayoutPanelMenuItems";
            this.flowLayoutPanelMenuItems.Size = new System.Drawing.Size(513, 207);
            this.flowLayoutPanelMenuItems.TabIndex = 0;
            // 
            // dataGridViewOrderMenuItems
            // 
            this.dataGridViewOrderMenuItems.AllowUserToAddRows = false;
            this.dataGridViewOrderMenuItems.AllowUserToDeleteRows = false;
            this.dataGridViewOrderMenuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderMenuItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrderMenuItems.Location = new System.Drawing.Point(178, 4);
            this.dataGridViewOrderMenuItems.Name = "dataGridViewOrderMenuItems";
            this.dataGridViewOrderMenuItems.ReadOnly = true;
            this.dataGridViewOrderMenuItems.Size = new System.Drawing.Size(513, 313);
            this.dataGridViewOrderMenuItems.TabIndex = 1;
            // 
            // dataGridViewPayments
            // 
            this.dataGridViewPayments.AllowUserToAddRows = false;
            this.dataGridViewPayments.AllowUserToDeleteRows = false;
            this.dataGridViewPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPayments.Location = new System.Drawing.Point(698, 4);
            this.dataGridViewPayments.Name = "dataGridViewPayments";
            this.dataGridViewPayments.ReadOnly = true;
            this.dataGridViewPayments.Size = new System.Drawing.Size(167, 313);
            this.dataGridViewPayments.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(698, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EditOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 588);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.EditOrderForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderMenuItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewPayments;
        private System.Windows.Forms.Button button1;
    }
}
namespace RestMan.UI.UserControls
{
    partial class ReportView
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanelWrapper = new System.Windows.Forms.TableLayoutPanel();
            this.labelFullname = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTotalTitle = new System.Windows.Forms.Label();
            this.labelGift = new System.Windows.Forms.Label();
            this.labelGiftTitle = new System.Windows.Forms.Label();
            this.labelQR = new System.Windows.Forms.Label();
            this.labelQRTitle = new System.Windows.Forms.Label();
            this.labelCredit = new System.Windows.Forms.Label();
            this.labelCreditTitle = new System.Windows.Forms.Label();
            this.labelCash = new System.Windows.Forms.Label();
            this.labelCashTitle = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.tableLayoutPanelWrapper.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.tableLayoutPanelWrapper);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(2, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(350, 177);
            this.panel.TabIndex = 0;
            // 
            // tableLayoutPanelWrapper
            // 
            this.tableLayoutPanelWrapper.ColumnCount = 2;
            this.tableLayoutPanelWrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelWrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelWrapper.Controls.Add(this.labelFullname, 1, 0);
            this.tableLayoutPanelWrapper.Controls.Add(this.tableLayoutPanel, 0, 1);
            this.tableLayoutPanelWrapper.Controls.Add(this.labelRole, 0, 0);
            this.tableLayoutPanelWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelWrapper.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelWrapper.Name = "tableLayoutPanelWrapper";
            this.tableLayoutPanelWrapper.RowCount = 2;
            this.tableLayoutPanelWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33333F));
            this.tableLayoutPanelWrapper.Size = new System.Drawing.Size(348, 175);
            this.tableLayoutPanelWrapper.TabIndex = 1;
            // 
            // labelFullname
            // 
            this.labelFullname.AutoSize = true;
            this.labelFullname.BackColor = System.Drawing.Color.Transparent;
            this.labelFullname.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelFullname.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold);
            this.labelFullname.Location = new System.Drawing.Point(97, 0);
            this.labelFullname.Name = "labelFullname";
            this.labelFullname.Size = new System.Drawing.Size(248, 29);
            this.labelFullname.TabIndex = 2;
            this.labelFullname.Text = "Коршикова Эльвина Анатольевна";
            this.labelFullname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanelWrapper.SetColumnSpan(this.tableLayoutPanel, 2);
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.labelTotal, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.labelTotalTitle, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.labelGift, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.labelGiftTitle, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.labelQR, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.labelQRTitle, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.labelCredit, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelCreditTitle, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelCash, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelCashTitle, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 32);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(342, 140);
            this.tableLayoutPanel.TabIndex = 0;
            this.tableLayoutPanel.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableLayoutPanel_CellPaint);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelTotal.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotal.Location = new System.Drawing.Point(301, 109);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(37, 30);
            this.labelTotal.TabIndex = 11;
            this.labelTotal.Text = "4000";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotalTitle
            // 
            this.labelTotalTitle.AutoSize = true;
            this.labelTotalTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTotalTitle.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalTitle.Location = new System.Drawing.Point(4, 109);
            this.labelTotalTitle.Name = "labelTotalTitle";
            this.labelTotalTitle.Size = new System.Drawing.Size(54, 30);
            this.labelTotalTitle.TabIndex = 10;
            this.labelTotalTitle.Text = "Итого:";
            this.labelTotalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGift
            // 
            this.labelGift.AutoSize = true;
            this.labelGift.BackColor = System.Drawing.Color.Transparent;
            this.labelGift.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelGift.Location = new System.Drawing.Point(302, 82);
            this.labelGift.Name = "labelGift";
            this.labelGift.Size = new System.Drawing.Size(36, 26);
            this.labelGift.TabIndex = 9;
            this.labelGift.Text = "1000";
            this.labelGift.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelGiftTitle
            // 
            this.labelGiftTitle.AutoSize = true;
            this.labelGiftTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelGiftTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelGiftTitle.Location = new System.Drawing.Point(4, 82);
            this.labelGiftTitle.Name = "labelGiftTitle";
            this.labelGiftTitle.Size = new System.Drawing.Size(147, 26);
            this.labelGiftTitle.TabIndex = 8;
            this.labelGiftTitle.Text = "Подарочной картой:";
            this.labelGiftTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelQR
            // 
            this.labelQR.AutoSize = true;
            this.labelQR.BackColor = System.Drawing.Color.Transparent;
            this.labelQR.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelQR.Location = new System.Drawing.Point(302, 55);
            this.labelQR.Name = "labelQR";
            this.labelQR.Size = new System.Drawing.Size(36, 26);
            this.labelQR.TabIndex = 7;
            this.labelQR.Text = "1000";
            this.labelQR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelQRTitle
            // 
            this.labelQRTitle.AutoSize = true;
            this.labelQRTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelQRTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelQRTitle.Location = new System.Drawing.Point(4, 55);
            this.labelQRTitle.Name = "labelQRTitle";
            this.labelQRTitle.Size = new System.Drawing.Size(42, 26);
            this.labelQRTitle.TabIndex = 6;
            this.labelQRTitle.Text = "СБП:";
            this.labelQRTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCredit
            // 
            this.labelCredit.AutoSize = true;
            this.labelCredit.BackColor = System.Drawing.Color.Transparent;
            this.labelCredit.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelCredit.Location = new System.Drawing.Point(302, 28);
            this.labelCredit.Name = "labelCredit";
            this.labelCredit.Size = new System.Drawing.Size(36, 26);
            this.labelCredit.TabIndex = 5;
            this.labelCredit.Text = "1000";
            this.labelCredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCreditTitle
            // 
            this.labelCreditTitle.AutoSize = true;
            this.labelCreditTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelCreditTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelCreditTitle.Location = new System.Drawing.Point(4, 28);
            this.labelCreditTitle.Name = "labelCreditTitle";
            this.labelCreditTitle.Size = new System.Drawing.Size(142, 26);
            this.labelCreditTitle.TabIndex = 4;
            this.labelCreditTitle.Text = "Банковской картой:";
            this.labelCreditTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCash
            // 
            this.labelCash.AutoSize = true;
            this.labelCash.BackColor = System.Drawing.Color.Transparent;
            this.labelCash.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelCash.Location = new System.Drawing.Point(302, 1);
            this.labelCash.Name = "labelCash";
            this.labelCash.Size = new System.Drawing.Size(36, 26);
            this.labelCash.TabIndex = 3;
            this.labelCash.Text = "1000";
            this.labelCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCashTitle
            // 
            this.labelCashTitle.AutoSize = true;
            this.labelCashTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelCashTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelCashTitle.Location = new System.Drawing.Point(4, 1);
            this.labelCashTitle.Name = "labelCashTitle";
            this.labelCashTitle.Size = new System.Drawing.Size(94, 26);
            this.labelCashTitle.TabIndex = 3;
            this.labelCashTitle.Text = "Наличными:";
            this.labelCashTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.BackColor = System.Drawing.Color.Transparent;
            this.labelRole.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelRole.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold);
            this.labelRole.Location = new System.Drawing.Point(3, 0);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(85, 29);
            this.labelRole.TabIndex = 1;
            this.labelRole.Text = "Менеджер:";
            this.labelRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(348, 175);
            this.Name = "ReportView";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(354, 181);
            this.Load += new System.EventHandler(this.ReportView_Load);
            this.panel.ResumeLayout(false);
            this.tableLayoutPanelWrapper.ResumeLayout(false);
            this.tableLayoutPanelWrapper.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWrapper;
        private System.Windows.Forms.Label labelFullname;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTotalTitle;
        private System.Windows.Forms.Label labelGift;
        private System.Windows.Forms.Label labelGiftTitle;
        private System.Windows.Forms.Label labelQR;
        private System.Windows.Forms.Label labelQRTitle;
        private System.Windows.Forms.Label labelCredit;
        private System.Windows.Forms.Label labelCreditTitle;
        private System.Windows.Forms.Label labelCash;
        private System.Windows.Forms.Label labelCashTitle;
        private System.Windows.Forms.Label labelRole;
    }
}

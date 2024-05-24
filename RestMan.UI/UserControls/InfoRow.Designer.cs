namespace RestMan.UI.UserControls
{
    partial class InfoRow
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
            this.labelValue = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Control;
            this.panel.Controls.Add(this.labelValue);
            this.panel.Controls.Add(this.labelTitle);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(173, 20);
            this.panel.TabIndex = 0;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelValue.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.labelValue.Location = new System.Drawing.Point(129, 0);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(44, 18);
            this.labelValue.TabIndex = 1;
            this.labelValue.Text = "Value";
            this.labelValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTitle.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(37, 18);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "InfoRow";
            this.Size = new System.Drawing.Size(173, 20);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelValue;
    }
}

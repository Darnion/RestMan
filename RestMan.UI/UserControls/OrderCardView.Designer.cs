namespace RestMan.UI.UserControls
{
    partial class OrderCardView
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
            this.labelDeletedAt = new System.Windows.Forms.Label();
            this.labelDeletedCaption = new System.Windows.Forms.Label();
            this.labelCreatedAt = new System.Windows.Forms.Label();
            this.labelCreatedCaption = new System.Windows.Forms.Label();
            this.labelWaiter = new System.Windows.Forms.Label();
            this.labelWaiterCaption = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelTableNumber = new System.Windows.Forms.Label();
            this.buttonHallColor = new System.Windows.Forms.Button();
            this.buttonWaiterColor = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.buttonWaiterColor);
            this.panel.Controls.Add(this.buttonHallColor);
            this.panel.Controls.Add(this.labelDeletedAt);
            this.panel.Controls.Add(this.labelDeletedCaption);
            this.panel.Controls.Add(this.labelCreatedAt);
            this.panel.Controls.Add(this.labelCreatedCaption);
            this.panel.Controls.Add(this.labelWaiter);
            this.panel.Controls.Add(this.labelWaiterCaption);
            this.panel.Controls.Add(this.labelSum);
            this.panel.Controls.Add(this.labelTableNumber);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(200, 200);
            this.panel.TabIndex = 0;
            this.panel.Click += new System.EventHandler(this.OrderCard_Click);
            // 
            // labelDeletedAt
            // 
            this.labelDeletedAt.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDeletedAt.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.labelDeletedAt.Location = new System.Drawing.Point(0, 144);
            this.labelDeletedAt.Name = "labelDeletedAt";
            this.labelDeletedAt.Size = new System.Drawing.Size(198, 18);
            this.labelDeletedAt.TabIndex = 7;
            this.labelDeletedAt.Text = "11.02.2002 14:30:00";
            this.labelDeletedAt.Click += new System.EventHandler(this.OrderCard_Click);
            // 
            // labelDeletedCaption
            // 
            this.labelDeletedCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDeletedCaption.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.labelDeletedCaption.Location = new System.Drawing.Point(0, 126);
            this.labelDeletedCaption.Name = "labelDeletedCaption";
            this.labelDeletedCaption.Size = new System.Drawing.Size(198, 18);
            this.labelDeletedCaption.TabIndex = 6;
            this.labelDeletedCaption.Text = "Закрыт: ";
            this.labelDeletedCaption.Click += new System.EventHandler(this.OrderCard_Click);
            // 
            // labelCreatedAt
            // 
            this.labelCreatedAt.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCreatedAt.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.labelCreatedAt.Location = new System.Drawing.Point(0, 108);
            this.labelCreatedAt.Name = "labelCreatedAt";
            this.labelCreatedAt.Size = new System.Drawing.Size(198, 18);
            this.labelCreatedAt.TabIndex = 5;
            this.labelCreatedAt.Text = "11.02.2002 12:30:00";
            this.labelCreatedAt.Click += new System.EventHandler(this.OrderCard_Click);
            // 
            // labelCreatedCaption
            // 
            this.labelCreatedCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCreatedCaption.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.labelCreatedCaption.Location = new System.Drawing.Point(0, 90);
            this.labelCreatedCaption.Name = "labelCreatedCaption";
            this.labelCreatedCaption.Size = new System.Drawing.Size(198, 18);
            this.labelCreatedCaption.TabIndex = 4;
            this.labelCreatedCaption.Text = "Создан: ";
            this.labelCreatedCaption.Click += new System.EventHandler(this.OrderCard_Click);
            // 
            // labelWaiter
            // 
            this.labelWaiter.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelWaiter.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.labelWaiter.Location = new System.Drawing.Point(0, 54);
            this.labelWaiter.Name = "labelWaiter";
            this.labelWaiter.Size = new System.Drawing.Size(198, 36);
            this.labelWaiter.TabIndex = 3;
            this.labelWaiter.Text = "Конев Ефим Викторович";
            this.labelWaiter.Click += new System.EventHandler(this.OrderCard_Click);
            // 
            // labelWaiterCaption
            // 
            this.labelWaiterCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelWaiterCaption.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.labelWaiterCaption.Location = new System.Drawing.Point(0, 36);
            this.labelWaiterCaption.Name = "labelWaiterCaption";
            this.labelWaiterCaption.Size = new System.Drawing.Size(198, 18);
            this.labelWaiterCaption.TabIndex = 2;
            this.labelWaiterCaption.Text = "Официант: ";
            this.labelWaiterCaption.Click += new System.EventHandler(this.OrderCard_Click);
            // 
            // labelSum
            // 
            this.labelSum.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSum.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold);
            this.labelSum.Location = new System.Drawing.Point(0, 180);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(198, 18);
            this.labelSum.TabIndex = 1;
            this.labelSum.Text = "Итого: ";
            this.labelSum.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.labelSum.Click += new System.EventHandler(this.OrderCard_Click);
            // 
            // labelTableNumber
            // 
            this.labelTableNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTableNumber.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold);
            this.labelTableNumber.Location = new System.Drawing.Point(0, 0);
            this.labelTableNumber.Name = "labelTableNumber";
            this.labelTableNumber.Size = new System.Drawing.Size(198, 36);
            this.labelTableNumber.TabIndex = 0;
            this.labelTableNumber.Text = "Стол ";
            this.labelTableNumber.Click += new System.EventHandler(this.OrderCard_Click);
            // 
            // buttonHallColor
            // 
            this.buttonHallColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHallColor.Location = new System.Drawing.Point(1, 162);
            this.buttonHallColor.Name = "buttonHallColor";
            this.buttonHallColor.Size = new System.Drawing.Size(99, 18);
            this.buttonHallColor.TabIndex = 8;
            this.buttonHallColor.UseVisualStyleBackColor = true;
            // 
            // buttonWaiterColor
            // 
            this.buttonWaiterColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWaiterColor.Location = new System.Drawing.Point(99, 162);
            this.buttonWaiterColor.Name = "buttonWaiterColor";
            this.buttonWaiterColor.Size = new System.Drawing.Size(99, 18);
            this.buttonWaiterColor.TabIndex = 9;
            this.buttonWaiterColor.UseVisualStyleBackColor = true;
            // 
            // OrderCardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderCardView";
            this.Size = new System.Drawing.Size(200, 200);
            this.Click += new System.EventHandler(this.OrderCard_Click);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label labelTableNumber;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelWaiterCaption;
        private System.Windows.Forms.Label labelWaiter;
        private System.Windows.Forms.Label labelCreatedAt;
        private System.Windows.Forms.Label labelCreatedCaption;
        private System.Windows.Forms.Label labelDeletedAt;
        private System.Windows.Forms.Label labelDeletedCaption;
        private System.Windows.Forms.Button buttonHallColor;
        private System.Windows.Forms.Button buttonWaiterColor;
    }
}

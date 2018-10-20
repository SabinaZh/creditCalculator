namespace Credit
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCount = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSum = new System.Windows.Forms.NumericUpDown();
            this.tbTime = new System.Windows.Forms.NumericUpDown();
            this.tbPercent = new System.Windows.Forms.NumericUpDown();
            this.comboprocess = new System.Windows.Forms.ComboBox();
            this.tbResult = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lvPayments = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.original = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.credit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.percent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.remaining = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pereplata = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.tbSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pereplata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сумма :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Срок(мес.) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Процентная ставка(%) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Тип платежей :";
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(141, 216);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(101, 41);
            this.btnCount.TabIndex = 4;
            this.btnCount.Text = "Рассчитать";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ежемесячный платеж :";
            // 
            // tbSum
            // 
            this.tbSum.DecimalPlaces = 2;
            this.tbSum.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tbSum.Location = new System.Drawing.Point(246, 31);
            this.tbSum.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.tbSum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(183, 22);
            this.tbSum.TabIndex = 6;
            this.tbSum.ThousandsSeparator = true;
            this.tbSum.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(246, 67);
            this.tbTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(183, 22);
            this.tbTime.TabIndex = 7;
            this.tbTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbPercent
            // 
            this.tbPercent.DecimalPlaces = 2;
            this.tbPercent.Location = new System.Drawing.Point(246, 109);
            this.tbPercent.Name = "tbPercent";
            this.tbPercent.Size = new System.Drawing.Size(183, 22);
            this.tbPercent.TabIndex = 8;
            this.tbPercent.ThousandsSeparator = true;
            // 
            // comboprocess
            // 
            this.comboprocess.FormattingEnabled = true;
            this.comboprocess.Items.AddRange(new object[] {
            "Аннуитетный",
            "Дифференцированный"});
            this.comboprocess.Location = new System.Drawing.Point(246, 147);
            this.comboprocess.Name = "comboprocess";
            this.comboprocess.Size = new System.Drawing.Size(183, 24);
            this.comboprocess.TabIndex = 9;
            // 
            // tbResult
            // 
            this.tbResult.DecimalPlaces = 2;
            this.tbResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbResult.Location = new System.Drawing.Point(246, 267);
            this.tbResult.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(183, 22);
            this.tbResult.TabIndex = 10;
            this.tbResult.ThousandsSeparator = true;
            this.tbResult.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Таблица погашения :";
            // 
            // lvPayments
            // 
            this.lvPayments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.original,
            this.credit,
            this.percent,
            this.remaining,
            this.total});
            this.lvPayments.Location = new System.Drawing.Point(43, 343);
            this.lvPayments.Name = "lvPayments";
            this.lvPayments.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lvPayments.Size = new System.Drawing.Size(934, 280);
            this.lvPayments.TabIndex = 12;
            this.lvPayments.UseCompatibleStateImageBehavior = false;
            this.lvPayments.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Месяц";
            this.columnHeader1.Width = 68;
            // 
            // original
            // 
            this.original.Text = "Дата";
            this.original.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.original.Width = 91;
            // 
            // credit
            // 
            this.credit.Text = "Погашение";
            this.credit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.credit.Width = 109;
            // 
            // percent
            // 
            this.percent.Text = "Проценты";
            this.percent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.percent.Width = 117;
            // 
            // remaining
            // 
            this.remaining.Text = "Остаток";
            this.remaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.remaining.Width = 123;
            // 
            // total
            // 
            this.total.Text = "Платеж";
            this.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.total.Width = 82;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(246, 273);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 22);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "см.Платеж в табл.погашения ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 678);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Переплата :";
            // 
            // pereplata
            // 
            this.pereplata.DecimalPlaces = 2;
            this.pereplata.Location = new System.Drawing.Point(246, 678);
            this.pereplata.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.pereplata.Minimum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            -2147483648});
            this.pereplata.Name = "pereplata";
            this.pereplata.Size = new System.Drawing.Size(183, 22);
            this.pereplata.TabIndex = 15;
            this.pereplata.ThousandsSeparator = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Дата получения кредита :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(246, 182);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(183, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 776);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pereplata);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lvPayments);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.comboprocess);
            this.Controls.Add(this.tbPercent);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.tbSum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Кредитный калькулятор";
            ((System.ComponentModel.ISupportInitialize)(this.tbSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pereplata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown tbSum;
        private System.Windows.Forms.NumericUpDown tbTime;
        private System.Windows.Forms.NumericUpDown tbPercent;
        private System.Windows.Forms.ComboBox comboprocess;
        private System.Windows.Forms.NumericUpDown tbResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvPayments;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader credit;
        private System.Windows.Forms.ColumnHeader percent;
        private System.Windows.Forms.ColumnHeader remaining;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown pereplata;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ColumnHeader original;
    }
}


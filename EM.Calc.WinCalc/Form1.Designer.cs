namespace EM.Calc.WinCalc
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
            this.components = new System.ComponentModel.Container();
            this.btnExec = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lblOperation = new System.Windows.Forms.Label();
            this.lblhelp = new System.Windows.Forms.Label();
            this.cbOperation = new System.Windows.Forms.ComboBox();
            this.btnfav1 = new System.Windows.Forms.Button();
            this.btnfav2 = new System.Windows.Forms.Button();
            this.btnfav3 = new System.Windows.Forms.Button();
            this.btnfav4 = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(326, 25);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(158, 79);
            this.btnExec.TabIndex = 0;
            this.btnExec.Text = "Вычислить";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(12, 120);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(472, 20);
            this.tbInput.TabIndex = 2;
            this.tbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Location = new System.Drawing.Point(27, 9);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(57, 13);
            this.lblOperation.TabIndex = 3;
            this.lblOperation.Text = "Операции";
            // 
            // lblhelp
            // 
            this.lblhelp.AutoSize = true;
            this.lblhelp.Location = new System.Drawing.Point(15, 101);
            this.lblhelp.Name = "lblhelp";
            this.lblhelp.Size = new System.Drawing.Size(173, 13);
            this.lblhelp.TabIndex = 4;
            this.lblhelp.Text = "Введите операнды через пробел";
            // 
            // cbOperation
            // 
            this.cbOperation.FormattingEnabled = true;
            this.cbOperation.Location = new System.Drawing.Point(30, 25);
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(121, 21);
            this.cbOperation.TabIndex = 5;
            this.cbOperation.SelectedIndexChanged += new System.EventHandler(this.cbOperation_SelectedIndexChanged);
            // 
            // btnfav1
            // 
            this.btnfav1.Location = new System.Drawing.Point(194, 11);
            this.btnfav1.Name = "btnfav1";
            this.btnfav1.Size = new System.Drawing.Size(60, 47);
            this.btnfav1.TabIndex = 6;
            this.btnfav1.Text = "первый";
            this.btnfav1.UseVisualStyleBackColor = true;
            // 
            // btnfav2
            // 
            this.btnfav2.Location = new System.Drawing.Point(260, 11);
            this.btnfav2.Name = "btnfav2";
            this.btnfav2.Size = new System.Drawing.Size(60, 47);
            this.btnfav2.TabIndex = 7;
            this.btnfav2.Text = "второй";
            this.btnfav2.UseVisualStyleBackColor = true;
            // 
            // btnfav3
            // 
            this.btnfav3.Location = new System.Drawing.Point(194, 67);
            this.btnfav3.Name = "btnfav3";
            this.btnfav3.Size = new System.Drawing.Size(60, 47);
            this.btnfav3.TabIndex = 8;
            this.btnfav3.Text = "третий";
            this.btnfav3.UseVisualStyleBackColor = true;
            // 
            // btnfav4
            // 
            this.btnfav4.Location = new System.Drawing.Point(260, 67);
            this.btnfav4.Name = "btnfav4";
            this.btnfav4.Size = new System.Drawing.Size(60, 47);
            this.btnfav4.TabIndex = 9;
            this.btnfav4.Text = "четвертый";
            this.btnfav4.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(9, 160);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(62, 13);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "Результат:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 187);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnfav4);
            this.Controls.Add(this.btnfav3);
            this.Controls.Add(this.btnfav2);
            this.Controls.Add(this.btnfav1);
            this.Controls.Add(this.cbOperation);
            this.Controls.Add(this.lblhelp);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btnExec);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Label lblhelp;
        private System.Windows.Forms.ComboBox cbOperation;
        private System.Windows.Forms.Button btnfav1;
        private System.Windows.Forms.Button btnfav2;
        private System.Windows.Forms.Button btnfav3;
        private System.Windows.Forms.Button btnfav4;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


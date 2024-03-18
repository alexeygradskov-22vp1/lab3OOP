namespace lab3OOP
{
    partial class MainForm
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
            this.btnCreateLib = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.privateLibraryRB = new System.Windows.Forms.RadioButton();
            this.stateLibraryRB = new System.Windows.Forms.RadioButton();
            this.libsLB = new System.Windows.Forms.ListBox();
            this.showTypeBtn = new System.Windows.Forms.Button();
            this.showCostBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateLib
            // 
            this.btnCreateLib.Location = new System.Drawing.Point(575, 16);
            this.btnCreateLib.Name = "btnCreateLib";
            this.btnCreateLib.Size = new System.Drawing.Size(213, 23);
            this.btnCreateLib.TabIndex = 0;
            this.btnCreateLib.Text = "Создать библиотеку";
            this.btnCreateLib.UseVisualStyleBackColor = true;
            this.btnCreateLib.Click += new System.EventHandler(this.btnCreateLib_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.privateLibraryRB);
            this.panel1.Controls.Add(this.stateLibraryRB);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 57);
            this.panel1.TabIndex = 1;
            // 
            // privateLibraryRB
            // 
            this.privateLibraryRB.AutoSize = true;
            this.privateLibraryRB.Location = new System.Drawing.Point(4, 30);
            this.privateLibraryRB.Name = "privateLibraryRB";
            this.privateLibraryRB.Size = new System.Drawing.Size(163, 20);
            this.privateLibraryRB.TabIndex = 1;
            this.privateLibraryRB.TabStop = true;
            this.privateLibraryRB.Text = "Частная библиотека";
            this.privateLibraryRB.UseVisualStyleBackColor = true;
            this.privateLibraryRB.CheckedChanged += new System.EventHandler(this.privateLibraryRB_CheckedChanged);
            // 
            // stateLibraryRB
            // 
            this.stateLibraryRB.AutoSize = true;
            this.stateLibraryRB.Location = new System.Drawing.Point(3, 3);
            this.stateLibraryRB.Name = "stateLibraryRB";
            this.stateLibraryRB.Size = new System.Drawing.Size(224, 20);
            this.stateLibraryRB.TabIndex = 0;
            this.stateLibraryRB.TabStop = true;
            this.stateLibraryRB.Text = "Государственная библиотека";
            this.stateLibraryRB.UseVisualStyleBackColor = true;
            this.stateLibraryRB.CheckedChanged += new System.EventHandler(this.stateLibraryRB_CheckedChanged);
            // 
            // libsLB
            // 
            this.libsLB.FormattingEnabled = true;
            this.libsLB.ItemHeight = 16;
            this.libsLB.Location = new System.Drawing.Point(13, 92);
            this.libsLB.Name = "libsLB";
            this.libsLB.Size = new System.Drawing.Size(775, 292);
            this.libsLB.TabIndex = 2;
            // 
            // showTypeBtn
            // 
            this.showTypeBtn.Location = new System.Drawing.Point(144, 403);
            this.showTypeBtn.Name = "showTypeBtn";
            this.showTypeBtn.Size = new System.Drawing.Size(213, 23);
            this.showTypeBtn.TabIndex = 3;
            this.showTypeBtn.Text = "Тип";
            this.showTypeBtn.UseVisualStyleBackColor = true;
            this.showTypeBtn.Click += new System.EventHandler(this.showTypeBtn_Click);
            // 
            // showCostBtn
            // 
            this.showCostBtn.Location = new System.Drawing.Point(420, 403);
            this.showCostBtn.Name = "showCostBtn";
            this.showCostBtn.Size = new System.Drawing.Size(213, 23);
            this.showCostBtn.TabIndex = 4;
            this.showCostBtn.Text = "Стоимость книг";
            this.showCostBtn.UseVisualStyleBackColor = true;
            this.showCostBtn.Click += new System.EventHandler(this.showCostBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showCostBtn);
            this.Controls.Add(this.showTypeBtn);
            this.Controls.Add(this.libsLB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCreateLib);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateLib;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton privateLibraryRB;
        private System.Windows.Forms.RadioButton stateLibraryRB;
        private System.Windows.Forms.ListBox libsLB;
        private System.Windows.Forms.Button showTypeBtn;
        private System.Windows.Forms.Button showCostBtn;
    }
}


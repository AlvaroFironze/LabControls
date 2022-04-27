
namespace WindowsFormsApp1
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
            this.userControl11 = new LabControls.UserControl1();
            this.numberBox1 = new LabControls.NumberBox(this.components);
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl12 = new WpfControlLibrary1.UserControl1();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl13 = new WpfControlLibrary2.UserControl1();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(704, 67);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(259, 150);
            this.userControl11.TabIndex = 2;
            // 
            // numberBox1
            // 
            this.numberBox1.ForeColor = System.Drawing.Color.Red;
            this.numberBox1.Location = new System.Drawing.Point(321, 88);
            this.numberBox1.Name = "numberBox1";
            this.numberBox1.Size = new System.Drawing.Size(100, 26);
            this.numberBox1.TabIndex = 1;
            this.numberBox1.TextChanged += new System.EventHandler(this.numberBox1_TextChanged);
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(12, 12);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(599, 587);
            this.elementHost1.TabIndex = 3;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.userControl12;
            // 
            // elementHost2
            // 
            this.elementHost2.Location = new System.Drawing.Point(683, 356);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(280, 160);
            this.elementHost2.TabIndex = 4;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.Child = this.userControl13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 599);
            this.Controls.Add(this.elementHost2);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.numberBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabControls.NumberBox numberBox1;
        private LabControls.UserControl1 userControl11;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private WpfControlLibrary1.UserControl1 userControl12;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private WpfControlLibrary2.UserControl1 userControl13;
    }
}


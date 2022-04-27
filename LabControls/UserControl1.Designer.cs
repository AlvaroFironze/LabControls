
namespace LabControls
{
    partial class UserControl1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Dec = new System.Windows.Forms.RadioButton();
            this.Hex = new System.Windows.Forms.RadioButton();
            this.ExampleColor = new System.Windows.Forms.Label();
            this.G = new LabControls.NumberBox(this.components);
            this.B = new LabControls.NumberBox(this.components);
            this.R = new LabControls.NumberBox(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "B";
            // 
            // Dec
            // 
            this.Dec.AutoSize = true;
            this.Dec.Checked = true;
            this.Dec.Location = new System.Drawing.Point(11, 119);
            this.Dec.Name = "Dec";
            this.Dec.Size = new System.Drawing.Size(63, 24);
            this.Dec.TabIndex = 6;
            this.Dec.TabStop = true;
            this.Dec.Text = "Dec";
            this.Dec.UseVisualStyleBackColor = true;
            this.Dec.CheckedChanged += new System.EventHandler(this.Dec_CheckedChanged);
            // 
            // Hex
            // 
            this.Hex.AutoSize = true;
            this.Hex.Location = new System.Drawing.Point(80, 119);
            this.Hex.Name = "Hex";
            this.Hex.Size = new System.Drawing.Size(62, 24);
            this.Hex.TabIndex = 7;
            this.Hex.Text = "Hex";
            this.Hex.UseVisualStyleBackColor = true;
            this.Hex.CheckedChanged += new System.EventHandler(this.Hex_CheckedChanged);
            // 
            // ExampleColor
            // 
            this.ExampleColor.BackColor = System.Drawing.Color.Black;
            this.ExampleColor.Location = new System.Drawing.Point(148, 20);
            this.ExampleColor.Name = "ExampleColor";
            this.ExampleColor.Padding = new System.Windows.Forms.Padding(2);
            this.ExampleColor.Size = new System.Drawing.Size(123, 123);
            this.ExampleColor.TabIndex = 8;
            // 
            // G
            // 
            this.G.Location = new System.Drawing.Point(31, 55);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(111, 26);
            this.G.TabIndex = 2;
            this.G.Text = "0";
            this.G.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.G.TextChanged += new System.EventHandler(this.Color_TextChanged);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(31, 87);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(111, 26);
            this.B.TabIndex = 1;
            this.B.Text = "0";
            this.B.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.B.TextChanged += new System.EventHandler(this.Color_TextChanged);
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(31, 20);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(111, 26);
            this.R.TabIndex = 9;
            this.R.Text = "0";
            this.R.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.R.TextChanged += new System.EventHandler(this.Color_TextChanged);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.R);
            this.Controls.Add(this.ExampleColor);
            this.Controls.Add(this.Hex);
            this.Controls.Add(this.Dec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.G);
            this.Controls.Add(this.B);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(281, 161);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private NumberBox B;
        private NumberBox G;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Dec;
        private System.Windows.Forms.RadioButton Hex;
        private System.Windows.Forms.Label ExampleColor;
        private NumberBox R;
    }
}

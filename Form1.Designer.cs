namespace Genera_los_números_del_1_20_con_while
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SG Alternative High-Alt", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(107, 22);
            label1.Name = "label1";
            label1.Size = new Size(462, 28);
            label1.TabIndex = 0;
            label1.Text = "Genera los números de el 1-20 con While";
            // 
            // button1
            // 
            button1.Font = new Font("SG Alternative High-Alt", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(141, 116);
            button1.Name = "button1";
            button1.Size = new Size(126, 88);
            button1.TabIndex = 1;
            button1.Text = "Imprime en pantalla ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(349, 66);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 244);
            listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private ListBox listBox1;
    }
}
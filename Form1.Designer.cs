namespace _3sem_2lr_kg
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
            this.button1 = new System.Windows.Forms.Button();
            this.button_line = new System.Windows.Forms.Button();
            this.button_arc = new System.Windows.Forms.Button();
            this.button_ellipse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Очистка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_line
            // 
            this.button_line.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_line.Location = new System.Drawing.Point(12, 357);
            this.button_line.Name = "button_line";
            this.button_line.Size = new System.Drawing.Size(120, 23);
            this.button_line.TabIndex = 4;
            this.button_line.Text = "Прямая";
            this.button_line.UseVisualStyleBackColor = true;
            this.button_line.Click += new System.EventHandler(this.button_line_Click);
            // 
            // button_arc
            // 
            this.button_arc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_arc.Location = new System.Drawing.Point(12, 386);
            this.button_arc.Name = "button_arc";
            this.button_arc.Size = new System.Drawing.Size(120, 23);
            this.button_arc.TabIndex = 5;
            this.button_arc.Text = "Дуга окружности";
            this.button_arc.UseVisualStyleBackColor = true;
            this.button_arc.Click += new System.EventHandler(this.button_arc_Click);
            // 
            // button_ellipse
            // 
            this.button_ellipse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ellipse.Location = new System.Drawing.Point(12, 415);
            this.button_ellipse.Name = "button_ellipse";
            this.button_ellipse.Size = new System.Drawing.Size(120, 23);
            this.button_ellipse.TabIndex = 6;
            this.button_ellipse.Text = "Эллипс";
            this.button_ellipse.UseVisualStyleBackColor = true;
            this.button_ellipse.Click += new System.EventHandler(this.button_ellipse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_ellipse);
            this.Controls.Add(this.button_arc);
            this.Controls.Add(this.button_line);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
        private Button button1;
        private Button button_line;
        private Button button_arc;
        private Button button_ellipse;
    }
}
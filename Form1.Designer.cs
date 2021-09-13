
namespace test2
{
    partial class MainForm
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
            this.Btn_SaveText = new System.Windows.Forms.Button();
            this.Lbl_1 = new System.Windows.Forms.Label();
            this.Txtbox_content = new System.Windows.Forms.TextBox();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // Btn_SaveText
            // 
            this.Btn_SaveText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_SaveText.Location = new System.Drawing.Point(262, 352);
            this.Btn_SaveText.Name = "Btn_SaveText";
            this.Btn_SaveText.Size = new System.Drawing.Size(270, 64);
            this.Btn_SaveText.TabIndex = 0;
            this.Btn_SaveText.Text = "Save text";
            this.Btn_SaveText.UseVisualStyleBackColor = true;
            this.Btn_SaveText.Click += new System.EventHandler(this.Btn_SaveText_Click);
            // 
            // Lbl_1
            // 
            this.Lbl_1.AutoSize = true;
            this.Lbl_1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_1.Location = new System.Drawing.Point(12, 32);
            this.Lbl_1.Name = "Lbl_1";
            this.Lbl_1.Size = new System.Drawing.Size(109, 17);
            this.Lbl_1.TabIndex = 1;
            this.Lbl_1.Text = "Write something:";
            // 
            // Txtbox_content
            // 
            this.Txtbox_content.Location = new System.Drawing.Point(12, 76);
            this.Txtbox_content.Multiline = true;
            this.Txtbox_content.Name = "Txtbox_content";
            this.Txtbox_content.Size = new System.Drawing.Size(776, 247);
            this.Txtbox_content.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txtbox_content);
            this.Controls.Add(this.Lbl_1);
            this.Controls.Add(this.Btn_SaveText);
            this.Name = "MainForm";
            this.Text = "Test3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_SaveText;
        private System.Windows.Forms.Label Lbl_1;
        private System.Windows.Forms.TextBox Txtbox_content;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog1;
    }
}


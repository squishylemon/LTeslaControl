namespace LTeslaControl
{
    partial class loginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            emailInput = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            nextInput = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nextInput).BeginInit();
            SuspendLayout();
            // 
            // emailInput
            // 
            emailInput.BackColor = Color.FromArgb(244, 244, 244);
            emailInput.BorderStyle = BorderStyle.None;
            emailInput.Font = new Font("Candara Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            emailInput.Location = new Point(21, 56);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(397, 30);
            emailInput.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(72, 28);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.emailinput;
            pictureBox1.Location = new Point(12, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(417, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // nextInput
            // 
            nextInput.Image = Properties.Resources.emailNext;
            nextInput.Location = new Point(12, 149);
            nextInput.Name = "nextInput";
            nextInput.Size = new Size(252, 50);
            nextInput.SizeMode = PictureBoxSizeMode.StretchImage;
            nextInput.TabIndex = 4;
            nextInput.TabStop = false;
            nextInput.Click += nextInput_Click;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(441, 211);
            Controls.Add(nextInput);
            Controls.Add(emailInput);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "loginForm";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nextInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox emailInput;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox nextInput;
    }
}
namespace MiniBank.UI
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
            msg1Btn = new Button();
            msg2Btn = new Button();
            labelMessage = new Label();
            SuspendLayout();
            // 
            // msg1Btn
            // 
            msg1Btn.Location = new Point(251, 404);
            msg1Btn.Name = "msg1Btn";
            msg1Btn.Size = new Size(112, 34);
            msg1Btn.TabIndex = 0;
            msg1Btn.Text = "Message 1";
            msg1Btn.UseVisualStyleBackColor = true;
            msg1Btn.Click += msg1Btn_Click;
            // 
            // msg2Btn
            // 
            msg2Btn.Location = new Point(369, 404);
            msg2Btn.Name = "msg2Btn";
            msg2Btn.Size = new Size(112, 34);
            msg2Btn.TabIndex = 0;
            msg2Btn.Text = "Message 2";
            msg2Btn.UseVisualStyleBackColor = true;
            msg2Btn.Click += msg2Btn_Click;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMessage.Location = new Point(306, 187);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(0, 54);
            labelMessage.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelMessage);
            Controls.Add(msg2Btn);
            Controls.Add(msg1Btn);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button msg1Btn;
        private Button msg2Btn;
        private Label labelMessage;
    }
}

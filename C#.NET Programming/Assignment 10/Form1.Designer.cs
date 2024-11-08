namespace ICT407P_Assignment10
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
            label_assignment = new Label();
            label_name = new Label();
            label_enrollnum = new Label();
            textbox_name = new TextBox();
            textbox_enrollnum = new TextBox();
            button_submit = new Button();
            button_exit = new Button();
            SuspendLayout();
            // 
            // label_assignment
            // 
            label_assignment.Anchor = AnchorStyles.Top;
            label_assignment.AutoSize = true;
            label_assignment.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_assignment.Location = new Point(303, 76);
            label_assignment.Name = "label_assignment";
            label_assignment.Size = new Size(216, 26);
            label_assignment.TabIndex = 0;
            label_assignment.Text = "REGISTRATION FORM";
            // 
            // label_name
            // 
            label_name.Anchor = AnchorStyles.Top;
            label_name.AutoSize = true;
            label_name.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_name.Location = new Point(126, 157);
            label_name.Name = "label_name";
            label_name.Size = new Size(84, 26);
            label_name.TabIndex = 1;
            label_name.Text = "Name:- ";
            // 
            // label_enrollnum
            // 
            label_enrollnum.Anchor = AnchorStyles.Top;
            label_enrollnum.AutoSize = true;
            label_enrollnum.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_enrollnum.Location = new Point(126, 226);
            label_enrollnum.Name = "label_enrollnum";
            label_enrollnum.Size = new Size(242, 26);
            label_enrollnum.TabIndex = 2;
            label_enrollnum.Text = "Enrollment Number:-";
            label_enrollnum.Click += label2_Click;
            // 
            // textbox_name
            // 
            textbox_name.Location = new Point(277, 157);
            textbox_name.Name = "textbox_name";
            textbox_name.Size = new Size(287, 27);
            textbox_name.TabIndex = 3;
            // 
            // textbox_enrollnum
            // 
            textbox_enrollnum.Location = new Point(425, 226);
            textbox_enrollnum.Name = "textbox_enrollnum";
            textbox_enrollnum.Size = new Size(287, 27);
            textbox_enrollnum.TabIndex = 4;
            // 
            // button_submit
            // 
            button_submit.Anchor = AnchorStyles.Top;
            button_submit.Location = new Point(274, 307);
            button_submit.Name = "button_submit";
            button_submit.Size = new Size(94, 29);
            button_submit.TabIndex = 5;
            button_submit.Text = "Submit";
            button_submit.UseVisualStyleBackColor = true;
            button_submit.Click += button_submit_Click;
            // 
            // button_exit
            // 
            button_exit.Anchor = AnchorStyles.Top;
            button_exit.Location = new Point(406, 307);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(94, 29);
            button_exit.TabIndex = 6;
            button_exit.Text = "Exit";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_exit);
            Controls.Add(button_submit);
            Controls.Add(textbox_enrollnum);
            Controls.Add(textbox_name);
            Controls.Add(label_enrollnum);
            Controls.Add(label_name);
            Controls.Add(label_assignment);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_assignment;
        private Label label_name;
        private Label label_enrollnum;
        private TextBox textbox_name;
        private TextBox textbox_enrollnum;
        private Button button_submit;
        private Button button_exit;
    }
}

namespace ICT407P_Assignment5_TemparatureConverter
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
            label_detail = new Label();
            label_temp_num = new Label();
            textbox_temp_num = new TextBox();
            label_temp_scale = new Label();
            combobox_temp_scale = new ComboBox();
            button_convert = new Button();
            textbox_result = new TextBox();
            button_exit = new Button();
            SuspendLayout();
            // 
            // label_detail
            // 
            label_detail.Anchor = AnchorStyles.Top;
            label_detail.AutoSize = true;
            label_detail.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_detail.Location = new Point(194, 89);
            label_detail.Name = "label_detail";
            label_detail.Size = new Size(428, 21);
            label_detail.TabIndex = 0;
            label_detail.Text = "Convert Celsius->Fahrenheit or Fahrenheit->Celsius";
            // 
            // label_temp_num
            // 
            label_temp_num.Anchor = AnchorStyles.Top;
            label_temp_num.AutoSize = true;
            label_temp_num.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_temp_num.Location = new Point(39, 174);
            label_temp_num.Name = "label_temp_num";
            label_temp_num.Size = new Size(170, 21);
            label_temp_num.TabIndex = 1;
            label_temp_num.Text = "Enter Temparature:-";
            // 
            // textbox_temp_num
            // 
            textbox_temp_num.Anchor = AnchorStyles.Top;
            textbox_temp_num.Location = new Point(215, 172);
            textbox_temp_num.Name = "textbox_temp_num";
            textbox_temp_num.Size = new Size(145, 27);
            textbox_temp_num.TabIndex = 2;
            // 
            // label_temp_scale
            // 
            label_temp_scale.Anchor = AnchorStyles.Top;
            label_temp_scale.AutoSize = true;
            label_temp_scale.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_temp_scale.Location = new Point(383, 172);
            label_temp_scale.Name = "label_temp_scale";
            label_temp_scale.Size = new Size(239, 21);
            label_temp_scale.TabIndex = 3;
            label_temp_scale.Text = "Choose Temparature Scale:-";
            // 
            // combobox_temp_scale
            // 
            combobox_temp_scale.Anchor = AnchorStyles.Top;
            combobox_temp_scale.FormattingEnabled = true;
            combobox_temp_scale.Items.AddRange(new object[] { "Degree C", "Degree F" });
            combobox_temp_scale.Location = new Point(628, 170);
            combobox_temp_scale.Name = "combobox_temp_scale";
            combobox_temp_scale.Size = new Size(112, 28);
            combobox_temp_scale.TabIndex = 4;
            // 
            // button_convert
            // 
            button_convert.Anchor = AnchorStyles.Top;
            button_convert.Location = new Point(194, 228);
            button_convert.Name = "button_convert";
            button_convert.Size = new Size(191, 54);
            button_convert.TabIndex = 5;
            button_convert.Text = "Convert Temparature";
            button_convert.UseVisualStyleBackColor = true;
            button_convert.Click += button_convert_Click;
            // 
            // textbox_result
            // 
            textbox_result.Anchor = AnchorStyles.Top;
            textbox_result.Location = new Point(194, 320);
            textbox_result.Name = "textbox_result";
            textbox_result.Size = new Size(428, 27);
            textbox_result.TabIndex = 6;
            // 
            // button_exit
            // 
            button_exit.Anchor = AnchorStyles.Top;
            button_exit.Location = new Point(431, 228);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(191, 54);
            button_exit.TabIndex = 7;
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
            Controls.Add(textbox_result);
            Controls.Add(button_convert);
            Controls.Add(combobox_temp_scale);
            Controls.Add(label_temp_scale);
            Controls.Add(textbox_temp_num);
            Controls.Add(label_temp_num);
            Controls.Add(label_detail);
            Name = "Form1";
            Text = "Temparature Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_detail;
        private Label label_temp_num;
        private TextBox textbox_temp_num;
        private Label label_temp_scale;
        private ComboBox combobox_temp_scale;
        private Button button_convert;
        private TextBox textbox_result;
        private Button button_exit;
    }
}

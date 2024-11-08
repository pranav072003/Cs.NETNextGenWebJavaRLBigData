namespace ICT407P_Assignment9
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
            button_exit = new Button();
            listbox_assignment = new ListBox();
            combobox_assignment = new ComboBox();
            label_assignment = new Label();
            richtextbox_assignment = new RichTextBox();
            button_detail = new Button();
            button_threading = new Button();
            SuspendLayout();
            // 
            // button_exit
            // 
            button_exit.Anchor = AnchorStyles.Top;
            button_exit.Location = new Point(663, 349);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(94, 29);
            button_exit.TabIndex = 0;
            button_exit.Text = "Exit";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // listbox_assignment
            // 
            listbox_assignment.Anchor = AnchorStyles.Top;
            listbox_assignment.FormattingEnabled = true;
            listbox_assignment.Items.AddRange(new object[] { "Select one of the options to view details:- ", "CSE", "IT", "ECE" });
            listbox_assignment.Location = new Point(31, 82);
            listbox_assignment.Name = "listbox_assignment";
            listbox_assignment.Size = new Size(398, 224);
            listbox_assignment.TabIndex = 1;
            listbox_assignment.SelectedIndexChanged += listbox_assignment_SelectedIndexChanged;
            // 
            // combobox_assignment
            // 
            combobox_assignment.Anchor = AnchorStyles.Top;
            combobox_assignment.FormattingEnabled = true;
            combobox_assignment.Items.AddRange(new object[] { "2021", "2022", "2023" });
            combobox_assignment.Location = new Point(476, 278);
            combobox_assignment.Name = "combobox_assignment";
            combobox_assignment.Size = new Size(281, 28);
            combobox_assignment.TabIndex = 2;
            combobox_assignment.SelectedIndexChanged += combobox_assignment_SelectedIndexChanged;
            // 
            // label_assignment
            // 
            label_assignment.Anchor = AnchorStyles.Top;
            label_assignment.AutoSize = true;
            label_assignment.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_assignment.Location = new Point(476, 82);
            label_assignment.MaximumSize = new Size(300, 0);
            label_assignment.Name = "label_assignment";
            label_assignment.Size = new Size(294, 138);
            label_assignment.TabIndex = 3;
            label_assignment.Text = "Hello there! Please interact with the listbox and combobox options to select some inputs. Chosen options will be displayed in the testbox on the bottom left";
            // 
            // richtextbox_assignment
            // 
            richtextbox_assignment.Anchor = AnchorStyles.Top;
            richtextbox_assignment.Location = new Point(31, 318);
            richtextbox_assignment.Name = "richtextbox_assignment";
            richtextbox_assignment.Size = new Size(218, 120);
            richtextbox_assignment.TabIndex = 4;
            richtextbox_assignment.Text = "";
            // 
            // button_detail
            // 
            button_detail.Anchor = AnchorStyles.Top;
            button_detail.Location = new Point(536, 349);
            button_detail.Name = "button_detail";
            button_detail.Size = new Size(94, 29);
            button_detail.TabIndex = 5;
            button_detail.Text = "Get Details";
            button_detail.UseVisualStyleBackColor = true;
            button_detail.Click += button_detail_Click;
            // 
            // button_threading
            // 
            button_threading.Anchor = AnchorStyles.Top;
            button_threading.Location = new Point(310, 349);
            button_threading.Name = "button_threading";
            button_threading.Size = new Size(168, 62);
            button_threading.TabIndex = 6;
            button_threading.Text = "Perform Multithreading";
            button_threading.UseVisualStyleBackColor = true;
            button_threading.Click += button_threading_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_threading);
            Controls.Add(button_detail);
            Controls.Add(richtextbox_assignment);
            Controls.Add(label_assignment);
            Controls.Add(combobox_assignment);
            Controls.Add(listbox_assignment);
            Controls.Add(button_exit);
            Name = "Form1";
            Text = "Demonstration of ComboBox, ListBox and Multithreading";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_exit;
        private ListBox listbox_assignment;
        private ComboBox combobox_assignment;
        private Label label_assignment;
        private RichTextBox richtextbox_assignment;
        private Button button_detail;
        private Button button_threading;
    }
}

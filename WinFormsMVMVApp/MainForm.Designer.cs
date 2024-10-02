namespace WinFormsMVMVApp
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
            listBoxEmployees = new ListBox();
            textBoxName = new TextBox();
            numericUpDownAge = new NumericUpDown();
            buttonSave = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            SuspendLayout();
            // 
            // listBoxEmployees
            // 
            listBoxEmployees.FormattingEnabled = true;
            listBoxEmployees.ItemHeight = 30;
            listBoxEmployees.Location = new Point(14, 15);
            listBoxEmployees.Margin = new Padding(5, 6, 5, 6);
            listBoxEmployees.Name = "listBoxEmployees";
            listBoxEmployees.Size = new Size(310, 424);
            listBoxEmployees.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(376, 15);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(362, 36);
            textBoxName.TabIndex = 1;
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Location = new Point(376, 72);
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(362, 36);
            numericUpDownAge.TabIndex = 2;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(376, 146);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(362, 54);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(376, 223);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(362, 54);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 454);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSave);
            Controls.Add(numericUpDownAge);
            Controls.Add(textBoxName);
            Controls.Add(listBoxEmployees);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxEmployees;
        private TextBox textBoxName;
        private NumericUpDown numericUpDownAge;
        private Button buttonSave;
        private Button buttonDelete;
    }
}

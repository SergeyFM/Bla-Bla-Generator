namespace WinFormsAppDemo {
    partial class mainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            blaBlaTextbox = new TextBox();
            generateButton = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            btnClear = new Button();
            btnExport = new Button();
            btnImport = new Button();
            textBox_NumberOfSentences = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // blaBlaTextbox
            // 
            blaBlaTextbox.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            blaBlaTextbox.Location = new Point(41, 24);
            blaBlaTextbox.Multiline = true;
            blaBlaTextbox.Name = "blaBlaTextbox";
            blaBlaTextbox.ScrollBars = ScrollBars.Vertical;
            blaBlaTextbox.Size = new Size(714, 299);
            blaBlaTextbox.TabIndex = 0;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(41, 358);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(104, 41);
            generateButton.TabIndex = 1;
            generateButton.Text = "GENERATE!";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(480, 358);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(58, 41);
            btnSave.TabIndex = 2;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(544, 358);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(58, 41);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "LOAD";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(391, 358);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(58, 41);
            btnClear.TabIndex = 2;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(634, 358);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(58, 41);
            btnExport.TabIndex = 2;
            btnExport.Text = "EXPORT";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(698, 358);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(58, 41);
            btnImport.TabIndex = 2;
            btnImport.Text = "IMPORT";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // textBox_NumberOfSentences
            // 
            textBox_NumberOfSentences.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_NumberOfSentences.Location = new Point(162, 359);
            textBox_NumberOfSentences.Name = "textBox_NumberOfSentences";
            textBox_NumberOfSentences.Size = new Size(100, 39);
            textBox_NumberOfSentences.TabIndex = 3;
            textBox_NumberOfSentences.Text = "20";
            textBox_NumberOfSentences.TextAlign = HorizontalAlignment.Center;
            textBox_NumberOfSentences.KeyDown += textBox_NumberOfSentences_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 400);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 4;
            label1.Text = "sentences";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(556, 400);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 5;
            label2.Text = "to/from DB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(710, 400);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 6;
            label3.Text = "to/from a file";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(407, 400);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 7;
            label4.Text = "the window";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_NumberOfSentences);
            Controls.Add(btnImport);
            Controls.Add(btnExport);
            Controls.Add(btnLoad);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(generateButton);
            Controls.Add(blaBlaTextbox);
            Name = "mainForm";
            Text = "Bla-bla generator";
            Load += mainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox blaBlaTextbox;
        private Button generateButton;
        private Button btnSave;
        private Button btnLoad;
        private Button btnClear;
        private Button btnExport;
        private Button btnImport;
        private TextBox textBox_NumberOfSentences;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
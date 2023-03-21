namespace WinFormsAppDemo
{
    partial class mainForm
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
            blaBlaTextbox = new TextBox();
            generateButton = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            btnClear = new Button();
            btnExport = new Button();
            btnImport = new Button();
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
            btnSave.Location = new Point(265, 358);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(58, 41);
            btnSave.TabIndex = 2;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(329, 358);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(58, 41);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "LOAD";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(176, 358);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(58, 41);
            btnClear.TabIndex = 2;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(419, 358);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(58, 41);
            btnExport.TabIndex = 2;
            btnExport.Text = "EXPORT";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(483, 358);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(58, 41);
            btnImport.TabIndex = 2;
            btnImport.Text = "IMPORT";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnImport);
            Controls.Add(btnExport);
            Controls.Add(btnLoad);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(generateButton);
            Controls.Add(blaBlaTextbox);
            Name = "mainForm";
            Text = "Bla-bla generator";
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
    }
}
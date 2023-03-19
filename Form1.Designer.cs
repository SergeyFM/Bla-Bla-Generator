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
            SuspendLayout();
            // 
            // blaBlaTextbox
            // 
            blaBlaTextbox.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            blaBlaTextbox.Location = new Point(41, 24);
            blaBlaTextbox.Multiline = true;
            blaBlaTextbox.Name = "blaBlaTextbox";
            blaBlaTextbox.ScrollBars = ScrollBars.Vertical;
            blaBlaTextbox.Size = new Size(715, 299);
            blaBlaTextbox.TabIndex = 0;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(41, 358);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(104, 41);
            generateButton.TabIndex = 1;
            generateButton.Text = "Generate it!";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(240, 358);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(58, 41);
            btnSave.TabIndex = 2;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(304, 358);
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
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoad);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(generateButton);
            Controls.Add(blaBlaTextbox);
            Name = "mainForm";
            Text = "Bla bla generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox blaBlaTextbox;
        private Button generateButton;
        private Button btnSave;
        private Button btnLoad;
        private Button btnClear;
    }
}
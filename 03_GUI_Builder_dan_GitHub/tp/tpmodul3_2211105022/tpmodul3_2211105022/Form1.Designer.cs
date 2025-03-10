namespace tpmodul3_2211105022
{
    partial class Form1
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
            this.nameInput = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.nameOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameInput
            // 
            this.nameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.Location = new System.Drawing.Point(67, 128);
            this.nameInput.Multiline = true;
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(353, 87);
            this.nameInput.TabIndex = 0;
            this.nameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameInput.TextChanged += new System.EventHandler(this.nameInput_TextChanged);
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(442, 128);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(301, 87);
            this.submit.TabIndex = 1;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameOutput
            // 
            this.nameOutput.AutoSize = true;
            this.nameOutput.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOutput.Location = new System.Drawing.Point(377, 273);
            this.nameOutput.Name = "nameOutput";
            this.nameOutput.Size = new System.Drawing.Size(92, 32);
            this.nameOutput.TabIndex = 2;
            this.nameOutput.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nameOutput);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.nameInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label nameOutput;
    }
}


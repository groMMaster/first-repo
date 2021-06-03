namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResponseForm = new System.Windows.Forms.CheckedListBox();
            this.JumpButton = new System.Windows.Forms.Button();
            this.GraphicСondition = new System.Windows.Forms.PictureBox();
            this.TextСondition = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GraphicСondition)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.ResponseForm.FormattingEnabled = true;
            this.ResponseForm.Location = new System.Drawing.Point(469, 317);
            this.ResponseForm.Name = "ResponseForm";
            this.ResponseForm.Size = new System.Drawing.Size(432, 109);
            this.ResponseForm.TabIndex = 0;
            this.ResponseForm.SelectedIndexChanged += new System.EventHandler(this.ResponseForm_SelectedIndexChanged);
            // 
            // JumpButton
            // 
            this.JumpButton.Location = new System.Drawing.Point(469, 432);
            this.JumpButton.Name = "JumpButton";
            this.JumpButton.Size = new System.Drawing.Size(432, 58);
            this.JumpButton.TabIndex = 1;
            this.JumpButton.Text = "JumpButton";
            this.JumpButton.UseVisualStyleBackColor = true;
            this.JumpButton.Click += new System.EventHandler(this.JumpButton_Click);
            // 
            // GraphicСondition
            // 
            this.GraphicСondition.Location = new System.Drawing.Point(27, 33);
            this.GraphicСondition.Name = "GraphicСondition";
            this.GraphicСondition.Size = new System.Drawing.Size(393, 393);
            this.GraphicСondition.TabIndex = 2;
            this.GraphicСondition.TabStop = false;
            // 
            // TextСondition
            // 
            this.TextСondition.AutoSize = true;
            this.TextСondition.Location = new System.Drawing.Point(469, 33);
            this.TextСondition.Name = "TextСondition";
            this.TextСondition.Size = new System.Drawing.Size(35, 13);
            this.TextСondition.TabIndex = 3;
            this.TextСondition.Text = "TextСondition";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp4.Resource1.Background;
            this.ClientSize = new System.Drawing.Size(944, 601);
            this.Controls.Add(this.TextСondition);
            this.Controls.Add(this.GraphicСondition);
            this.Controls.Add(this.JumpButton);
            this.Controls.Add(this.ResponseForm);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GraphicСondition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ResponseForm;
        private System.Windows.Forms.Button JumpButton;
        private System.Windows.Forms.PictureBox GraphicСondition;
        private System.Windows.Forms.Label TextСondition;
    }
}


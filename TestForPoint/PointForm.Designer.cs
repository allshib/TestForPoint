namespace TestForPoint
{
    partial class PointForm
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
            this.bthCreate = new System.Windows.Forms.Button();
            this.bthSort = new System.Windows.Forms.Button();
            this.bthSerialize = new System.Windows.Forms.Button();
            this.bthDeserialize = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bthCreate
            // 
            this.bthCreate.Location = new System.Drawing.Point(30, 346);
            this.bthCreate.Name = "bthCreate";
            this.bthCreate.Size = new System.Drawing.Size(142, 69);
            this.bthCreate.TabIndex = 0;
            this.bthCreate.Text = "Create";
            this.bthCreate.UseVisualStyleBackColor = true;
            this.bthCreate.Click += new System.EventHandler(this.bthCreate_Click);
            // 
            // bthSort
            // 
            this.bthSort.Location = new System.Drawing.Point(213, 346);
            this.bthSort.Name = "bthSort";
            this.bthSort.Size = new System.Drawing.Size(142, 69);
            this.bthSort.TabIndex = 1;
            this.bthSort.Text = "Sort";
            this.bthSort.UseVisualStyleBackColor = true;
            this.bthSort.Click += new System.EventHandler(this.bthSort_Click_1);
            // 
            // bthSerialize
            // 
            this.bthSerialize.Location = new System.Drawing.Point(409, 346);
            this.bthSerialize.Name = "bthSerialize";
            this.bthSerialize.Size = new System.Drawing.Size(142, 69);
            this.bthSerialize.TabIndex = 2;
            this.bthSerialize.Text = "Serialize";
            this.bthSerialize.UseVisualStyleBackColor = true;
            this.bthSerialize.Click += new System.EventHandler(this.bthSerialize_Click_1);
            // 
            // bthDeserialize
            // 
            this.bthDeserialize.Location = new System.Drawing.Point(597, 346);
            this.bthDeserialize.Name = "bthDeserialize";
            this.bthDeserialize.Size = new System.Drawing.Size(142, 69);
            this.bthDeserialize.TabIndex = 3;
            this.bthDeserialize.Text = "Deserialize";
            this.bthDeserialize.UseVisualStyleBackColor = true;
            this.bthDeserialize.Click += new System.EventHandler(this.bthDeserialize_Click_1);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(30, 39);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(709, 290);
            this.listBox.TabIndex = 4;
            // 
            // PointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.bthDeserialize);
            this.Controls.Add(this.bthSerialize);
            this.Controls.Add(this.bthSort);
            this.Controls.Add(this.bthCreate);
            this.Name = "PointForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bthCreate;
        private System.Windows.Forms.Button bthSort;
        private System.Windows.Forms.Button bthSerialize;
        private System.Windows.Forms.Button bthDeserialize;
        private System.Windows.Forms.ListBox listBox;
    }
}


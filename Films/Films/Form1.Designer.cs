namespace Films
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
            this.listOfClasses = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.listCreateObjects = new System.Windows.Forms.ListBox();
            this.delete = new System.Windows.Forms.Button();
            this.informationList = new System.Windows.Forms.ListBox();
            this.editionField = new System.Windows.Forms.RichTextBox();
            this.textValue = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.cleanMyList = new System.Windows.Forms.Button();
            this.serialization = new System.Windows.Forms.Button();
            this.deserialization = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listOfClasses
            // 
            this.listOfClasses.FormattingEnabled = true;
            this.listOfClasses.Items.AddRange(new object[] {
            "Cartoons",
            "Fiction",
            "Melodrama"});
            this.listOfClasses.Location = new System.Drawing.Point(12, 23);
            this.listOfClasses.Name = "listOfClasses";
            this.listOfClasses.Size = new System.Drawing.Size(152, 21);
            this.listOfClasses.TabIndex = 0;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(184, 23);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(101, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // listCreateObjects
            // 
            this.listCreateObjects.FormattingEnabled = true;
            this.listCreateObjects.Location = new System.Drawing.Point(12, 63);
            this.listCreateObjects.Name = "listCreateObjects";
            this.listCreateObjects.Size = new System.Drawing.Size(152, 160);
            this.listCreateObjects.TabIndex = 2;
            this.listCreateObjects.SelectedIndexChanged += new System.EventHandler(this.listCreateObjects_SelectedIndexChanged);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(184, 63);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(101, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // informationList
            // 
            this.informationList.FormattingEnabled = true;
            this.informationList.Location = new System.Drawing.Point(12, 243);
            this.informationList.Name = "informationList";
            this.informationList.Size = new System.Drawing.Size(164, 147);
            this.informationList.TabIndex = 4;
            // 
            // editionField
            // 
            this.editionField.Location = new System.Drawing.Point(337, 157);
            this.editionField.Name = "editionField";
            this.editionField.Size = new System.Drawing.Size(212, 183);
            this.editionField.TabIndex = 5;
            this.editionField.Text = "";
            // 
            // textValue
            // 
            this.textValue.Location = new System.Drawing.Point(337, 358);
            this.textValue.Name = "textValue";
            this.textValue.Size = new System.Drawing.Size(152, 20);
            this.textValue.TabIndex = 6;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(521, 358);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 7;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(184, 107);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(101, 23);
            this.edit.TabIndex = 8;
            this.edit.Text = "редактировать";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // cleanMyList
            // 
            this.cleanMyList.Location = new System.Drawing.Point(184, 155);
            this.cleanMyList.Name = "cleanMyList";
            this.cleanMyList.Size = new System.Drawing.Size(101, 29);
            this.cleanMyList.TabIndex = 9;
            this.cleanMyList.Text = "очистить список";
            this.cleanMyList.UseVisualStyleBackColor = true;
            this.cleanMyList.Click += new System.EventHandler(this.cleanMyList_Click);
            // 
            // serialization
            // 
            this.serialization.Location = new System.Drawing.Point(414, 23);
            this.serialization.Name = "serialization";
            this.serialization.Size = new System.Drawing.Size(115, 23);
            this.serialization.TabIndex = 10;
            this.serialization.Text = "сериализация";
            this.serialization.UseVisualStyleBackColor = true;
            this.serialization.Click += new System.EventHandler(this.serialization_Click);
            // 
            // deserialization
            // 
            this.deserialization.Location = new System.Drawing.Point(414, 76);
            this.deserialization.Name = "deserialization";
            this.deserialization.Size = new System.Drawing.Size(115, 24);
            this.deserialization.TabIndex = 11;
            this.deserialization.Text = "десириализация";
            this.deserialization.UseVisualStyleBackColor = true;
            this.deserialization.Click += new System.EventHandler(this.deserialization_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "выберите файл (формат dll)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 269);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 13;
            // 
            // AddClass
            // 
            this.AddClass.Location = new System.Drawing.Point(184, 308);
            this.AddClass.Name = "AddClass";
            this.AddClass.Size = new System.Drawing.Size(101, 23);
            this.AddClass.TabIndex = 14;
            this.AddClass.Text = "добавить класс";
            this.AddClass.UseVisualStyleBackColor = true;
            this.AddClass.Click += new System.EventHandler(this.AddClass_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 402);
            this.Controls.Add(this.AddClass);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deserialization);
            this.Controls.Add(this.serialization);
            this.Controls.Add(this.cleanMyList);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.textValue);
            this.Controls.Add(this.editionField);
            this.Controls.Add(this.informationList);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.listCreateObjects);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.listOfClasses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listOfClasses;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ListBox listCreateObjects;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.ListBox informationList;
        private System.Windows.Forms.RichTextBox editionField;
        private System.Windows.Forms.TextBox textValue;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button cleanMyList;
        private System.Windows.Forms.Button serialization;
        private System.Windows.Forms.Button deserialization;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddClass;
    }
}


namespace Notetaker
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
            this.titleBox = new System.Windows.Forms.TextBox();
            this.noteBox = new System.Windows.Forms.TextBox();
            this.savedNotesGrid = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.savedNotesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(12, 27);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(248, 20);
            this.titleBox.TabIndex = 0;
            // 
            // noteBox
            // 
            this.noteBox.Location = new System.Drawing.Point(12, 73);
            this.noteBox.Multiline = true;
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(248, 261);
            this.noteBox.TabIndex = 1;
            // 
            // savedNotesGrid
            // 
            this.savedNotesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.savedNotesGrid.Location = new System.Drawing.Point(598, 61);
            this.savedNotesGrid.Name = "savedNotesGrid";
            this.savedNotesGrid.Size = new System.Drawing.Size(172, 261);
            this.savedNotesGrid.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(13, 340);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(89, 48);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save Note";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(108, 340);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(89, 48);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Load Note";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(108, 390);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(89, 48);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete Note";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Note Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Note ";
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(13, 394);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(89, 48);
            this.newButton.TabIndex = 8;
            this.newButton.Text = "New Note";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.savedNotesGrid);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.titleBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.savedNotesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox noteBox;
        private System.Windows.Forms.DataGridView savedNotesGrid;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button newButton;
    }
}


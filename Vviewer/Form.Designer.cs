using Vviewer.Properties;

namespace Vviewer
{
    partial class UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.Drop = new System.Windows.Forms.Panel();
            this.Control = new System.Windows.Forms.GroupBox();
            this.listName = new System.Windows.Forms.ListBox();
            this.imgBOX = new System.Windows.Forms.PictureBox();
            this.FolderSource = new System.Windows.Forms.TextBox();
            this.FolderSave = new System.Windows.Forms.TextBox();
            this.SelectFolderSource = new System.Windows.Forms.Button();
            this.SelectFolderSave = new System.Windows.Forms.Button();
            this.Сlear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveCurrent = new System.Windows.Forms.Button();
            this.SaveAll = new System.Windows.Forms.Button();
            this.ViolationtApply = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Drop.SuspendLayout();
            this.Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBOX)).BeginInit();
            this.SuspendLayout();
            // 
            // Drop
            // 
            this.Drop.AllowDrop = true;
            this.Drop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Drop.Controls.Add(this.Control);
            this.Drop.Controls.Add(this.listName);
            this.Drop.Controls.Add(this.imgBOX);
            this.Drop.Location = new System.Drawing.Point(2, 2);
            this.Drop.Name = "Drop";
            this.Drop.Size = new System.Drawing.Size(1496, 816);
            this.Drop.TabIndex = 0;
            this.Drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.Drop_DragEnter);
            // 
            // Control
            // 
            this.Control.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Control.Controls.Add(this.comboBox1);
            this.Control.Controls.Add(this.ViolationtApply);
            this.Control.Controls.Add(this.SaveAll);
            this.Control.Controls.Add(this.SaveCurrent);
            this.Control.Controls.Add(this.label1);
            this.Control.Controls.Add(this.Сlear);
            this.Control.Controls.Add(this.SelectFolderSave);
            this.Control.Controls.Add(this.SelectFolderSource);
            this.Control.Controls.Add(this.FolderSave);
            this.Control.Controls.Add(this.FolderSource);
            this.Control.Location = new System.Drawing.Point(4, 723);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(1489, 91);
            this.Control.TabIndex = 4;
            this.Control.TabStop = false;
            // 
            // listName
            // 
            this.listName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listName.ForeColor = System.Drawing.Color.Black;
            this.listName.FormattingEnabled = true;
            this.listName.ItemHeight = 19;
            this.listName.Location = new System.Drawing.Point(3, 3);
            this.listName.Name = "listName";
            this.listName.Size = new System.Drawing.Size(204, 726);
            this.listName.TabIndex = 3;
            // 
            // imgBOX
            // 
            this.imgBOX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgBOX.BackColor = System.Drawing.Color.Gray;
            this.imgBOX.Image = global::Vviewer.Properties.Resources.filenotselected;
            this.imgBOX.Location = new System.Drawing.Point(213, 3);
            this.imgBOX.Name = "imgBOX";
            this.imgBOX.Size = new System.Drawing.Size(1280, 720);
            this.imgBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBOX.TabIndex = 2;
            this.imgBOX.TabStop = false;
            // 
            // FolderSource
            // 
            this.FolderSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderSource.Location = new System.Drawing.Point(783, 14);
            this.FolderSource.Name = "FolderSource";
            this.FolderSource.Size = new System.Drawing.Size(444, 29);
            this.FolderSource.TabIndex = 0;
            // 
            // FolderSave
            // 
            this.FolderSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderSave.Location = new System.Drawing.Point(783, 52);
            this.FolderSave.Name = "FolderSave";
            this.FolderSave.Size = new System.Drawing.Size(444, 29);
            this.FolderSave.TabIndex = 1;
            // 
            // SelectFolderSource
            // 
            this.SelectFolderSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectFolderSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFolderSource.Location = new System.Drawing.Point(497, 9);
            this.SelectFolderSource.Name = "SelectFolderSource";
            this.SelectFolderSource.Size = new System.Drawing.Size(280, 38);
            this.SelectFolderSource.TabIndex = 2;
            this.SelectFolderSource.Text = "Select download folder";
            this.SelectFolderSource.UseVisualStyleBackColor = true;
            // 
            // SelectFolderSave
            // 
            this.SelectFolderSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectFolderSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFolderSave.Location = new System.Drawing.Point(497, 49);
            this.SelectFolderSave.Name = "SelectFolderSave";
            this.SelectFolderSave.Size = new System.Drawing.Size(280, 38);
            this.SelectFolderSave.TabIndex = 3;
            this.SelectFolderSave.Text = "Select a folder to save";
            this.SelectFolderSave.UseVisualStyleBackColor = true;
            // 
            // Сlear
            // 
            this.Сlear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Сlear.Location = new System.Drawing.Point(3, 49);
            this.Сlear.Name = "Сlear";
            this.Сlear.Size = new System.Drawing.Size(202, 38);
            this.Сlear.TabIndex = 4;
            this.Сlear.Text = "Сlear";
            this.Сlear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Files: ";
            // 
            // SaveCurrent
            // 
            this.SaveCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCurrent.Location = new System.Drawing.Point(1267, 9);
            this.SaveCurrent.Name = "SaveCurrent";
            this.SaveCurrent.Size = new System.Drawing.Size(220, 38);
            this.SaveCurrent.TabIndex = 6;
            this.SaveCurrent.Text = "Save Current";
            this.SaveCurrent.UseVisualStyleBackColor = true;
            // 
            // SaveAll
            // 
            this.SaveAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAll.Location = new System.Drawing.Point(1267, 49);
            this.SaveAll.Name = "SaveAll";
            this.SaveAll.Size = new System.Drawing.Size(220, 38);
            this.SaveAll.TabIndex = 7;
            this.SaveAll.Text = "Save All";
            this.SaveAll.UseVisualStyleBackColor = true;
            // 
            // ViolationtApply
            // 
            this.ViolationtApply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ViolationtApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViolationtApply.Location = new System.Drawing.Point(240, 49);
            this.ViolationtApply.Name = "ViolationtApply";
            this.ViolationtApply.Size = new System.Drawing.Size(220, 38);
            this.ViolationtApply.TabIndex = 8;
            this.ViolationtApply.Text = "Apply";
            this.ViolationtApply.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(240, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 32);
            this.comboBox1.TabIndex = 9;
            // 
            // UI
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1500, 821);
            this.Controls.Add(this.Drop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1515, 860);
            this.Name = "UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vviewer";
            this.Load += new System.EventHandler(this.UI_Load);
            this.Drop.ResumeLayout(false);
            this.Control.ResumeLayout(false);
            this.Control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBOX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Drop;
        private System.Windows.Forms.PictureBox imgBOX;
        private System.Windows.Forms.ListBox listName;
        private System.Windows.Forms.GroupBox Control;
        private System.Windows.Forms.TextBox FolderSave;
        private System.Windows.Forms.TextBox FolderSource;
        private System.Windows.Forms.Button SelectFolderSave;
        private System.Windows.Forms.Button SelectFolderSource;
        private System.Windows.Forms.Button Сlear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveAll;
        private System.Windows.Forms.Button SaveCurrent;
        private System.Windows.Forms.Button ViolationtApply;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}


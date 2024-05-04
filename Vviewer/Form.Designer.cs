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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Control = new System.Windows.Forms.GroupBox();
            this.CameraBox = new System.Windows.Forms.ComboBox();
            this.ViolatiosBox = new System.Windows.Forms.ComboBox();
            this.ViolationtApply = new System.Windows.Forms.Button();
            this.SaveAll = new System.Windows.Forms.Button();
            this.SaveCurrent = new System.Windows.Forms.Button();
            this.CountFiles = new System.Windows.Forms.Label();
            this.Сlear = new System.Windows.Forms.Button();
            this.SelectFolderSave = new System.Windows.Forms.Button();
            this.SelectFolderSource = new System.Windows.Forms.Button();
            this.FolderSave = new System.Windows.Forms.TextBox();
            this.FolderSource = new System.Windows.Forms.TextBox();
            this.listName = new System.Windows.Forms.ListBox();
            this.imgBOX = new System.Windows.Forms.PictureBox();
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
            this.Drop.Controls.Add(this.progressBar);
            this.Drop.Controls.Add(this.Control);
            this.Drop.Controls.Add(this.listName);
            this.Drop.Controls.Add(this.imgBOX);
            this.Drop.Location = new System.Drawing.Point(2, 2);
            this.Drop.Name = "Drop";
            this.Drop.Size = new System.Drawing.Size(1496, 816);
            this.Drop.TabIndex = 0;
            this.Drop.DragDrop += new System.Windows.Forms.DragEventHandler(this.Drop_DragDrop);
            this.Drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.Drop_DragEnter);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(219, 682);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1267, 35);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 6;
            this.progressBar.Visible = false;
            // 
            // Control
            // 
            this.Control.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Control.Controls.Add(this.CameraBox);
            this.Control.Controls.Add(this.ViolatiosBox);
            this.Control.Controls.Add(this.ViolationtApply);
            this.Control.Controls.Add(this.SaveAll);
            this.Control.Controls.Add(this.SaveCurrent);
            this.Control.Controls.Add(this.CountFiles);
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
            // CameraBox
            // 
            this.CameraBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CameraBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CameraBox.FormattingEnabled = true;
            this.CameraBox.Location = new System.Drawing.Point(399, 10);
            this.CameraBox.Name = "CameraBox";
            this.CameraBox.Size = new System.Drawing.Size(180, 32);
            this.CameraBox.TabIndex = 10;
            this.CameraBox.SelectedIndexChanged += new System.EventHandler(this.CameraBox_SelectedIndexChanged);
            // 
            // ViolatiosBox
            // 
            this.ViolatiosBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ViolatiosBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViolatiosBox.FormattingEnabled = true;
            this.ViolatiosBox.Location = new System.Drawing.Point(215, 10);
            this.ViolatiosBox.Name = "ViolatiosBox";
            this.ViolatiosBox.Size = new System.Drawing.Size(180, 32);
            this.ViolatiosBox.TabIndex = 9;
            this.ViolatiosBox.SelectedIndexChanged += new System.EventHandler(this.ViolatiosBox_SelectedIndexChanged);
            // 
            // ViolationtApply
            // 
            this.ViolationtApply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ViolationtApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViolationtApply.Location = new System.Drawing.Point(215, 49);
            this.ViolationtApply.Name = "ViolationtApply";
            this.ViolationtApply.Size = new System.Drawing.Size(364, 38);
            this.ViolationtApply.TabIndex = 8;
            this.ViolationtApply.Text = "Apply";
            this.ViolationtApply.UseVisualStyleBackColor = true;
            this.ViolationtApply.Click += new System.EventHandler(this.ViolationtApply_Click);
            // 
            // SaveAll
            // 
            this.SaveAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAll.Location = new System.Drawing.Point(1295, 49);
            this.SaveAll.Name = "SaveAll";
            this.SaveAll.Size = new System.Drawing.Size(192, 38);
            this.SaveAll.TabIndex = 7;
            this.SaveAll.Text = "Save All";
            this.SaveAll.UseVisualStyleBackColor = true;
            this.SaveAll.Click += new System.EventHandler(this.SaveAll_Click);
            // 
            // SaveCurrent
            // 
            this.SaveCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCurrent.Location = new System.Drawing.Point(1295, 9);
            this.SaveCurrent.Name = "SaveCurrent";
            this.SaveCurrent.Size = new System.Drawing.Size(192, 38);
            this.SaveCurrent.TabIndex = 6;
            this.SaveCurrent.Text = "Save Current";
            this.SaveCurrent.UseVisualStyleBackColor = true;
            this.SaveCurrent.Click += new System.EventHandler(this.SaveCurrent_Click);
            // 
            // CountFiles
            // 
            this.CountFiles.AutoSize = true;
            this.CountFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountFiles.Location = new System.Drawing.Point(5, 9);
            this.CountFiles.Name = "CountFiles";
            this.CountFiles.Size = new System.Drawing.Size(110, 31);
            this.CountFiles.TabIndex = 5;
            this.CountFiles.Text = "Files: 0";
            // 
            // Сlear
            // 
            this.Сlear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Сlear.Location = new System.Drawing.Point(3, 49);
            this.Сlear.Name = "Сlear";
            this.Сlear.Size = new System.Drawing.Size(202, 38);
            this.Сlear.TabIndex = 4;
            this.Сlear.Text = "Сlear";
            this.Сlear.UseVisualStyleBackColor = true;
            this.Сlear.Click += new System.EventHandler(this.Сlear_Click);
            // 
            // SelectFolderSave
            // 
            this.SelectFolderSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectFolderSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFolderSave.Location = new System.Drawing.Point(591, 49);
            this.SelectFolderSave.Name = "SelectFolderSave";
            this.SelectFolderSave.Size = new System.Drawing.Size(284, 38);
            this.SelectFolderSave.TabIndex = 3;
            this.SelectFolderSave.Text = "Select a folder to save";
            this.SelectFolderSave.UseVisualStyleBackColor = true;
            this.SelectFolderSave.Click += new System.EventHandler(this.SelectFolderSave_Click);
            // 
            // SelectFolderSource
            // 
            this.SelectFolderSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectFolderSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFolderSource.Location = new System.Drawing.Point(591, 9);
            this.SelectFolderSource.Name = "SelectFolderSource";
            this.SelectFolderSource.Size = new System.Drawing.Size(284, 38);
            this.SelectFolderSource.TabIndex = 2;
            this.SelectFolderSource.Text = "Select download folder";
            this.SelectFolderSource.UseVisualStyleBackColor = true;
            this.SelectFolderSource.Click += new System.EventHandler(this.SelectFolderSource_Click);
            // 
            // FolderSave
            // 
            this.FolderSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FolderSave.Location = new System.Drawing.Point(881, 52);
            this.FolderSave.Name = "FolderSave";
            this.FolderSave.Size = new System.Drawing.Size(398, 26);
            this.FolderSave.TabIndex = 1;
            // 
            // FolderSource
            // 
            this.FolderSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FolderSource.Location = new System.Drawing.Point(881, 14);
            this.FolderSource.Name = "FolderSource";
            this.FolderSource.Size = new System.Drawing.Size(398, 26);
            this.FolderSource.TabIndex = 0;
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
            this.listName.SelectedIndexChanged += new System.EventHandler(this.listName_SelectedIndexChanged);
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
            // UI
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1500, 825);
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
        private System.Windows.Forms.Label CountFiles;
        private System.Windows.Forms.Button SaveAll;
        private System.Windows.Forms.Button SaveCurrent;
        private System.Windows.Forms.Button ViolationtApply;
        private System.Windows.Forms.ComboBox ViolatiosBox;
        private System.Windows.Forms.ComboBox CameraBox;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}


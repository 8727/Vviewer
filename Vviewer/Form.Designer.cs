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
            this.Drop.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.imgBOX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Drop;
        private System.Windows.Forms.PictureBox imgBOX;
        private System.Windows.Forms.ListBox listName;
        private System.Windows.Forms.GroupBox Control;
    }
}


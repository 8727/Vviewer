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
            this.SuspendLayout();
            // 
            // Drop
            // 
            this.Drop.AllowDrop = true;
            this.Drop.Location = new System.Drawing.Point(2, 2);
            this.Drop.Name = "Drop";
            this.Drop.Size = new System.Drawing.Size(1496, 816);
            this.Drop.TabIndex = 0;
            this.Drop.DragEnter += new System.Windows.Forms.DragEventHandler(this.Drop_DragEnter);
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
            this.Text = "Violation viewer";
            this.Load += new System.EventHandler(this.UI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Drop;
    }
}


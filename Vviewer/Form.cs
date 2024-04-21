using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vviewer
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        void UI_Load(object sender, EventArgs e)
        {

        }

        async void Drop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            await Task.Run(async () =>
            {
              Pen pen = new Pen(Color.Black, 4);
              for (int i = 40; i > 20; i--, await Task.Delay(15))
              {
                Drop.CreateGraphics().Clear(SystemColors.Control);
                pen.DashPattern = new float[] { 20, i };
                Drop.CreateGraphics().DrawRectangle(pen, 1, 1, Drop.Width - 2, Drop.Height - 2);
              }
            });
        }
    }
}

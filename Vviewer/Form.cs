using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

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

        string NameCreation(string name)
        {
            Regex regex = new Regex(@"\d{4}-");
            if (regex.IsMatch(name))
            {
                int number = (int.Parse(name.Remove(name.IndexOf("-"))) + 1);
                name = number.ToString("0000") + name.Substring(4);
            }
            else
            {
                name = "0000-" + name;
            }

            if (ListFiles.ContainsKey(name))
            {
                name = NameCreation(name);
            }
            return name;
        }

        async void Drop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            await Task.Run(async () =>
            {
              Pen pen = new Pen(Color.Red, 4);
              for (int i = 40; i > 20; i--, await Task.Delay(15))
              {
                Drop.CreateGraphics().Clear(SystemColors.Control);
                pen.DashPattern = new float[] { 20, i };
                Drop.CreateGraphics().DrawRectangle(pen, 1, 1, Drop.Width - 2, Drop.Height - 2);
              }
            });
        }

        private void Drop_DragDrop(object sender, DragEventArgs e)
        {
            XmlDocument xFile = new XmlDocument();
            foreach (string obj in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                if (Directory.Exists(obj))
                {
                    ReadFolder(obj);
                }
                else
                {
                    xFile.Load(obj);
                    if (xFile.SelectSingleNode("//v_photo_ts") != null)
                    {
                        XmlNodeList xmlregno = xFile.GetElementsByTagName("v_regno");
                        string regno = xmlregno[0].InnerText;

                        if (!regno.Equals("{db.CarNumber}"))
                        {
                            String NameFile = Path.GetFileName(obj);

                            if (ListFiles.ContainsKey(NameFile))
                            {
                                NameFile = NameCreation(NameFile);
                            }

                            ListFiles.Add(NameFile, obj);
                            listName.Items.Add(NameFile);
                        }
                    }
                }
            }

            if (listName.Items.Count > 0)
            {
                listName.SetSelected(0, true);
            }
        }

        private void listName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCountry = listName.SelectedItem.ToString();
            string x = (string)ListFiles[selectedCountry];
            ViewerIMG(x);
            //label1.Text = selectedCountry;
        }



        private void Сlear_Click(object sender, EventArgs e)
        {
            listName.Items.Clear();
/*            ListFiles.Clear();*/
            imgBOX.Image = global::Vviewer.Properties.Resources.filenotselected;
        }

        private void ViolationtApply_Click(object sender, EventArgs e)
        {

        }

        private void SelectFolderSource_Click(object sender, EventArgs e)
        {

        }

        private void SelectFolderSave_Click(object sender, EventArgs e)
        {

        }

        private void SaveCurrent_Click(object sender, EventArgs e)
        {

        }

        private void SaveAll_Click(object sender, EventArgs e)
        {

        }



        void ReadFolder(string path)
        {
            XmlDocument xFile = new XmlDocument();
            string[] tempfiles = Directory.GetFiles(path, "*.xml", SearchOption.AllDirectories);

            if (!Application.OpenForms.OfType<Form2>().Any())
            {
                secondForm = new Form2();
                secondForm.progressbarValue = 0;
                secondForm.progressbarMax = tempfiles.Count();
                secondForm.Show();
            }

            foreach (string file in tempfiles)
            {
                secondForm.progressbarValue++;
                xFile.Load(file);
                if (xFile.SelectSingleNode("//v_photo_ts") != null)
                {
                    XmlNodeList xmlregno = xFile.GetElementsByTagName("v_regno");
                    string regno = xmlregno[0].InnerText;

                    if (!regno.Equals("{db.CarNumber}"))
                    {

                        String NameFile = Path.GetFileName(file);

                        if (ListFiles.ContainsKey(NameFile))
                        {
                            NameFile = NameCreation(NameFile);
                        }

                        ListFiles.Add(NameFile, file);
                        listName.Items.Add(NameFile);
                    }
                }
            }
        }

        void ViewerIMG(string pathXML)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(pathXML);

            XmlNodeList img = xDoc.GetElementsByTagName("v_photo_ts");

            var bytes = Convert.FromBase64String(img[0].InnerText);
            MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length);
            ms.Write(bytes, 0, bytes.Length);
            Image image = Image.FromStream(ms, true);
            ms.Close();
            GC.Collect();

            imgBOX.Image = image;
        }

        void SaveViolation(string pathXML, string saveFolder)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(pathXML);

            if (xDoc.SelectSingleNode("//v_photo_ts") != null)
            {
                FileInfo fil;

                XmlNodeList violation_check_time = xDoc.GetElementsByTagName("v_time_check");

                string data = violation_check_time[0].InnerText.Remove(violation_check_time[0].InnerText.IndexOf("T"));
                string datatime = violation_check_time[0].InnerText.Remove(violation_check_time[0].InnerText.IndexOf(".") - 3);
                datatime = datatime.Substring(datatime.IndexOf("T") + 1);

                XmlNodeList violation_camera = xDoc.GetElementsByTagName("v_camera");
                XmlNodeList violation_regno = xDoc.GetElementsByTagName("v_regno");
                XmlNodeList violation_pr_viol = xDoc.GetElementsByTagName("v_pr_viol");
                XmlNodeList violation_photo_ts = xDoc.GetElementsByTagName("v_photo_ts");
                XmlNodeList violation_type_photo = xDoc.GetElementsByTagName("v_type_photo");
                XmlNodeList violation_photo_extra = xDoc.GetElementsByTagName("v_photo_extra");

                DirectoryInfo dirInfo = new DirectoryInfo(saveFolder + "\\" + data);
                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                }

                string fileName = "\\" + data + "\\" + datatime.Replace(':', '.') + "_" + violation_camera[0].InnerText + "_" + violation_pr_viol[0].InnerText + "_" + violation_regno[0].InnerText;

                var bytes = Convert.FromBase64String(violation_photo_ts[0].InnerText);

                fil = new FileInfo(saveFolder + fileName + ".jpg");
                using (Stream sw = fil.OpenWrite())
                {
                    sw.Write(bytes, 0, bytes.Length);
                    sw.Close();
                }

                GC.Collect();

                int index = violation_type_photo.Count;

                while (index > 0)
                {
                    bytes = Convert.FromBase64String(violation_photo_extra[index - 1].InnerText);

                    switch (violation_type_photo[index - 1].InnerText)
                    {
                        case "0":
                            fil = new FileInfo(saveFolder + fileName + "_extra_" + index + ".jpg");
                            break;
                        case "1":
                            fil = new FileInfo(saveFolder + fileName + "_extra_" + index + ".jpg");
                            break;
                        case "2":
                            fil = new FileInfo(saveFolder + fileName + "_Video_" + index + ".webm");
                            break;
                        case "3":
                            fil = new FileInfo(saveFolder + fileName + "_Video_" + index + ".mp4");
                            break;
                        case "4":
                            fil = new FileInfo(saveFolder + fileName + "_PDF_" + index + ".pdf");
                            break;
                        case "5":
                            fil = new FileInfo(saveFolder + fileName + "_XML_" + index + ".xml");
                            break;
                        default:
                            fil = new FileInfo(saveFolder + fileName + "_extra_" + index + ".jpg");
                            break;
                    }

                    using (Stream sw = fil.OpenWrite())
                    {
                        sw.Write(bytes, 0, bytes.Length);
                        sw.Close();
                    }
                    GC.Collect();

                    index--;
                }
            }

        }



    }
}

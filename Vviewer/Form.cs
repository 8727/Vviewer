using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Reflection;
using static System.Net.WebRequestMethods;

namespace Vviewer
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        Hashtable ListFiles = new Hashtable();
        List<String> NaneList = new List<String>();


        Hashtable ViolationCode = new Hashtable();

        void HashVuolation()
        {
            ViolationCode.Add("0", "0 - Stream");
            ViolationCode.Add("2", "2 - OverSpeed");
            ViolationCode.Add("4", "4 - WrongDirection");
            ViolationCode.Add("5", "5 - BusLane");
            ViolationCode.Add("10", "10 - RedLightCross");
            ViolationCode.Add("31", "31 - SeatBelt");
            ViolationCode.Add("81", "81 - WrongCross");
            ViolationCode.Add("83", "83 - StopLine");
            ViolationCode.Add("90", "90 - WrongTurnTwoFrontier");
            ViolationCode.Add("112", "112 - WrongLineTurn");
            ViolationCode.Add("113", "113 - NoForwardZnak");
            ViolationCode.Add("114", "114 - NoUTurnOnlyForward");
            ViolationCode.Add("127", "127 - Lights");
        }

        void UI_Load(object sender, EventArgs e)
        {
            string folders = Application.StartupPath.ToString();
            FolderSource.Text = folders;
            FolderSave.Text = folders;
            ViolatiosBox.Items.Add("ALL - Violations");
            ViolatiosBox.SelectedIndex = 0;
            HashVuolation();

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

        void Drop_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string obj in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                if (Directory.Exists(obj))
                {
                    ReadFolder(obj);
                }
                else
                {
                    ReadFile(obj);
                }
            }

            if (listName.Items.Count > 0)
            {
                listName.SetSelected(0, true);
                CountFiles.Text = "Files: " + listName.Items.Count.ToString();
            }
            else
            {
                CountFiles.Text = "Files: 0";
            }
            Drop.CreateGraphics().Clear(SystemColors.Control);
        }

        void listName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCountry = listName.SelectedItem.ToString();
            string x = (string)ListFiles[selectedCountry];
            ViewerIMG(x);
        }



        void Сlear_Click(object sender, EventArgs e)
        {
            listName.Items.Clear();
            ListFiles.Clear();
            ViolatiosBox.Items.Clear();
            CountFiles.Text = "Files: 0";
            imgBOX.Image = global::Vviewer.Properties.Resources.filenotselected;
        }

        void ViolationtApply_Click(object sender, EventArgs e)
        {

        }

        void SelectFolderSource_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = FolderSource.Text;
            dialog.IsFolderPicker = true;
            dialog.Multiselect = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                FolderSource.Text = dialog.FileName;
                ReadFolder(FolderSource.Text);
            }

            if (listName.Items.Count > 0)
            {
                listName.SetSelected(0, true);
                CountFiles.Text = "Files: " + listName.Items.Count.ToString();
            }
            else
            {
                CountFiles.Text = "Files: 0";
            }
        }

        void SelectFolderSave_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = FolderSave.Text;
            dialog.IsFolderPicker = true;
            dialog.Multiselect = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                FolderSave.Text = dialog.FileName;
            }
        }

        void SaveCurrent_Click(object sender, EventArgs e)
        {
            if (listName.Items.Count > 0)
            {
                Сlear.Enabled = false;
                SelectFolderSource.Enabled = false;
                SelectFolderSave.Enabled = false;
                SaveCurrent.Enabled = false;
                SaveAll.Enabled = false;

                string selectedCountry = listName.SelectedItem.ToString();
                string filePatch = (string)ListFiles[selectedCountry];
                SaveViolation(filePatch, FolderSave.Text);

                Сlear.Enabled = true;
                SelectFolderSource.Enabled = true;
                SelectFolderSave.Enabled = true;
                SaveCurrent.Enabled = true;
                SaveAll.Enabled = true;
            }
        }

        void SaveAll_Click(object sender, EventArgs e)
        {
            if (listName.Items.Count > 0)
            {
                Сlear.Enabled = false;
                SelectFolderSource.Enabled = false;
                SelectFolderSave.Enabled = false;
                SaveCurrent.Enabled = false;
                SaveAll.Enabled = false;


                ICollection keys = ListFiles.Keys;
                int y = 0;
                foreach (string name in keys)
                {
                    string x = (string)ListFiles[name];
                    listName.SetSelected(y, true);
                    SaveViolation(x, FolderSave.Text);
                    y++;
                }

                Сlear.Enabled = true;
                SelectFolderSource.Enabled = true;
                SelectFolderSave.Enabled = true;
                SaveCurrent.Enabled = true;
                SaveAll.Enabled = true;
            }
        }



        void ReadFile(string filename)
        {
            XmlDocument xFile = new XmlDocument();
            xFile.Load(filename);
            if (xFile.SelectSingleNode("//v_photo_ts") != null)
            {
                XmlNodeList violation_box = xFile.GetElementsByTagName("v_pr_viol");
                XmlNodeList xmlregno = xFile.GetElementsByTagName("v_regno");
                string regno = xmlregno[0].InnerText;

                if (!regno.Equals("{db.CarNumber}"))
                {
                    String NameFile = Path.GetFileName(filename);

                    if (ListFiles.ContainsKey(NameFile))
                    {
                        NameFile = NameCreation(NameFile);
                    }

                    ListFiles.Add(NameFile, filename);
                    listName.Items.Add(NameFile);

                    if (ViolatiosBox.FindString(violation_box[0].InnerText) == -1)
                    {
                        if (ViolationCode.ContainsKey(violation_box[0].InnerText))
                        {
                            ViolatiosBox.Items.Add((string)ViolationCode[violation_box[0].InnerText]);
                        }
                        else
                        {
                            ViolatiosBox.Items.Add(violation_box[0].InnerText);
                        }
                    }
                }
            }
        }

        void ReadFolder(string path)
        {
            string[] tempfiles = Directory.GetFiles(path, "*.xml", SearchOption.AllDirectories);

/*            if (!Application.OpenForms.OfType<Form2>().Any())
            {
                secondForm = new Form2();
                secondForm.progressbarValue = 0;
                secondForm.progressbarMax = tempfiles.Count();
                secondForm.Show();
            }*/

            foreach (string file in tempfiles)
            {
                //secondForm.progressbarValue++;
                ReadFile(file);
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

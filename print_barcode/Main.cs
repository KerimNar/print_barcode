using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace print_barcode
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            this.mK_001_VW_GnlListTableAdapter1.Fill(this.lOGODBDataSet1.MK_001_VW_GnlList);

            xmlHelper = new XmlHelper();
            if (!File.Exists("SettingSize"))
            {
                SettingSize p = new SettingSize
                {
                    PaperHeight = 79,
                    PaperWidth = 200,
                    BarcodeHeight = 25,
                    BarcodeX = 40,
                    BarcodeY = 35,
                    NameX = 10,
                    NameY = 8,
                    CodeX = 50,
                    CodeY = 35
                };

                xmlHelper.XmlFileWrite(p);
            }

            settingSize = xmlHelper.XmlFileLoad();
        }

        Zen.Barcode.Code128BarcodeDraw cd128 = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
        XmlHelper xmlHelper;
        SettingSize settingSize;
        string textBoxBarcode = "";
        string textBoxText = "";

        private void button1_Click(object sender, EventArgs e)
        {
            getSellectRows();
        }

        private void getSellectRows()
        {
            ArrayList rows = new ArrayList();

            // Add the selected rows to the list.
            Int32[] selectedRowHandles = gridView1.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                int selectedRowHandle = selectedRowHandles[i];
                if (selectedRowHandle >= 0)
                    rows.Add(gridView1.GetDataRow(selectedRowHandle));
            }
            try
            {
                gridView1.BeginUpdate();
                for (int i = 0; i < rows.Count; i++)
                {
                    DataRow row = rows[i] as DataRow;
                    // Change the field value.
                    textBoxBarcode = row["ITMCODE"].ToString().Replace(".", "");
                    textBoxText = row["ITMNAME"].ToString();
                    print();
                }
            }
            finally
            {
                gridView1.EndUpdate();
            }
        }

        public void yazdir(object sender, PrintPageEventArgs e)
        {
            if (textBoxText.Length > 25)
            {
                e.Graphics.DrawString(textBoxText.Substring(0, 25), this.Font, new SolidBrush(Color.Black), settingSize.NameX, settingSize.NameY);
                e.Graphics.DrawString(textBoxText.Substring(25, textBoxText.Length - 25), this.Font, new SolidBrush(Color.Black), settingSize.NameX, settingSize.NameY + 10);
            }
            else
            {
                e.Graphics.DrawString(textBoxText, this.Font, new SolidBrush(Color.Black), settingSize.NameX, settingSize.NameY);
                e.Graphics.DrawString("", this.Font, new SolidBrush(Color.Black), settingSize.NameX, settingSize.NameY + 10);
            }
            e.Graphics.DrawImage(pictureBox1.Image, settingSize.BarcodeX, settingSize.BarcodeY);
            e.Graphics.DrawString(textBoxBarcode, this.Font, new SolidBrush(Color.Black), settingSize.CodeX, pictureBox1.Image.Height+ settingSize.CodeY);
        }

        private void print()
        {
            if (textBoxBarcode != "" && textBoxText != "")
            {
                pictureBox1.Image = cd128.Draw(textBoxBarcode, settingSize.BarcodeHeight);
            }
            else
            {
                MessageBox.Show("Empy text.");
            }

            if (textBoxBarcode != null && textBoxText != null)
            {
                PrintDocument dos = new PrintDocument();
                PrinterSettings settings = new PrinterSettings();
                string defaultPrinterName = settings.PrinterName;
                dos.PrinterSettings.PrinterName = defaultPrinterName;
                dos.PrinterSettings.DefaultPageSettings.Landscape = true;
                dos.PrintPage += new PrintPageEventHandler(yazdir);
                dos.DefaultPageSettings.PaperSize = new PaperSize("A", settingSize.PaperWidth, settingSize.PaperHeight);
                dos.Print();
                //textBox1.Clear();
                //textBox2.Clear();
                //pictureBox1.Image = null;
            }
            else
            {
                MessageBox.Show("Empy text");
            }
        }

        private void Button2_ClickAsync(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
        
    }

    public class SettingSize
    {
        public int PaperHeight { get; set; }
        public int PaperWidth { get; set; }


        public int BarcodeHeight { get; set; }
        public int BarcodeX { get; set; }
        public int BarcodeY { get; set; }

        public int NameX { get; set; }
        public int NameY { get; set; }


        public int CodeX { get; set; }
        public int CodeY { get; set; }
    }

    public class XmlHelper
    {
        public void XmlFileWrite(SettingSize p)
        {
            //SettingSize p = new SettingSize();
            //p.PaperHeight = 0;
            //p.PaperWidth = 0;

            XmlSerializer x = new XmlSerializer(p.GetType());
            x.Serialize(Console.Out, p);
            Console.WriteLine();
            Console.ReadLine();

            //first serialize the object to memory stream,
            //in case of exception, the original file is not corrupted
            using (MemoryStream ms = new MemoryStream())
            {

                var writer = new System.IO.StreamWriter(ms);
                var serializer = new XmlSerializer(p.GetType());
                serializer.Serialize(writer, p);
                writer.Flush();

                File.WriteAllBytes("SettingSize", ms.ToArray());
            }
        }
        public SettingSize XmlFileLoad()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(SettingSize));
            using (FileStream fileStream = new FileStream("SettingSize", FileMode.Open))
            {
                SettingSize result = (SettingSize)serializer.Deserialize(fileStream);
                return result;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing.Text;

namespace print_barcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            xmlHelper = new XmlHelper();
            settingSize = xmlHelper.XmlFileLoad();
            textBoxPaperHeight.Text = settingSize.PaperHeight.ToString();
            textBoxPaperWidth.Text = settingSize.PaperWidth.ToString();
            textBoxBarcodeHeight.Text = settingSize.BarcodeHeight.ToString();
            textBoxBarcodeX.Text = settingSize.BarcodeX.ToString();
            textBoxBarcodeY.Text = settingSize.BarcodeY.ToString();
            textBoxNameX.Text = settingSize.NameX.ToString();
            textBoxNameY.Text = settingSize.NameY.ToString();
            textBoxCodeX.Text = settingSize.CodeX.ToString();
            textBoxCodeY.Text = settingSize.CodeY.ToString();
        }

        Zen.Barcode.Code128BarcodeDraw cd128 = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
        XmlHelper xmlHelper;
        SettingSize settingSize;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxBarcode.Text != "" && textBoxText.Text != "")
            {
                pictureBox1.Image = cd128.Draw(textBoxBarcode.Text, Convert.ToInt16(textBoxBarcodeHeight.Text));

                buttonPrint.Enabled = true;
            }
            else
            {
                MessageBox.Show("Empy text.");
            }

        }
        public void yazdir(object sender, PrintPageEventArgs e)
        {

            e.Graphics.DrawString(textBoxText.Text, this.Font, new SolidBrush(Color.Black), Convert.ToInt16(textBoxNameX.Text), Convert.ToInt16(textBoxNameY.Text));
            e.Graphics.DrawImage(pictureBox1.Image, Convert.ToInt16(textBoxBarcodeX.Text), Convert.ToInt16(textBoxBarcodeY.Text));
            e.Graphics.DrawString(textBoxBarcode.Text, this.Font, new SolidBrush(Color.Black), Convert.ToInt16(textBoxCodeX.Text), pictureBox1.Image.Height+ Convert.ToInt16(textBoxCodeY.Text));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxBarcode.Text!=null&&textBoxText.Text!=null)
            {
                PrintDocument dos = new PrintDocument();
                PrinterSettings settings = new PrinterSettings();
                string defaultPrinterName = settings.PrinterName;
                dos.PrinterSettings.PrinterName = defaultPrinterName;
                dos.PrinterSettings.DefaultPageSettings.Landscape = true;
                dos.PrintPage += new PrintPageEventHandler(yazdir);
                dos.DefaultPageSettings.PaperSize = new PaperSize("A", Convert.ToInt16(textBoxPaperWidth.Text), Convert.ToInt16(textBoxPaperHeight.Text));
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                settingSize.PaperHeight = Convert.ToInt16(textBoxPaperHeight.Text);
                settingSize.PaperWidth = Convert.ToInt16(textBoxPaperWidth.Text);
                settingSize.BarcodeHeight = Convert.ToInt16(textBoxBarcodeHeight.Text);
                settingSize.BarcodeX = Convert.ToInt16(textBoxBarcodeX.Text);
                settingSize.BarcodeY = Convert.ToInt16(textBoxBarcodeY.Text);
                settingSize.NameX = Convert.ToInt16(textBoxNameX.Text);
                settingSize.NameY = Convert.ToInt16(textBoxNameY.Text);
                settingSize.CodeX = Convert.ToInt16(textBoxCodeX.Text);
                settingSize.CodeY = Convert.ToInt16(textBoxCodeY.Text);

                xmlHelper.XmlFileWrite(settingSize);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex+"");
            }
            this.Close();
        }
    }
}

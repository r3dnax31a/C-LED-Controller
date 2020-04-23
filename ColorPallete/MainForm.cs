using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;

namespace ColorPallete
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        public SerialPort port = new SerialPort("COM7", 9600);

        private void pictureBoxColorWheel_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Bitmap bitmap = new Bitmap(pictureBoxColorWheel.Image);
                Color color = bitmap.GetPixel(e.X, e.Y);
                pictureBoxSelectedColor.BackColor = color;

                labelAlphaValue.Text = color.Name.ToString();
                labelRedValue.Text = color.R.ToString();
                labelGreenValue.Text = color.G.ToString();
                labelBlueValue.Text = color.B.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void pictureBoxColorWheel_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {

                Bitmap bitmap = new Bitmap(pictureBoxColorWheel.Image);
                Color color = bitmap.GetPixel(e.X, e.Y);
                pictureBoxSavedColor.BackColor = color;

                labelHexVal.Text = color.Name.ToString();
                labelRedVal.Text = color.R.ToString();
                labelGreenVal.Text = color.G.ToString();
                labelBlueVal.Text = color.B.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void pictureBoxColorWheel_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxSelectedColor.BackColor = Color.White;
            labelAlphaValue.Text = "ffffffff";
            labelRedValue.Text = "255";
            labelGreenValue.Text = "255";
            labelBlueValue.Text = "255";
        }




        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (string Portname in SerialPort.GetPortNames())
                comboBoxPorts.Items.Add(Portname);

        }

        private void buttonConnect_MouseClick(object sender, MouseEventArgs e)
        {
            
            port.Open();
        }

        private void buttonSendColor_Click(object sender, EventArgs e)
        {
            string str = labelRedVal.Text + "A" + labelGreenVal.Text + "B" + labelBlueVal.Text;
            port.WriteLine(str);
        }

        private void comboBoxPorts_Leave(object sender, EventArgs e)
        {
           
        }
    }
}

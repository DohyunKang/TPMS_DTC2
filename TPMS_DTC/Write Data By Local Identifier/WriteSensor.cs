using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPMS_DTC
{
    public partial class WriteSensor : Form
    {
        public byte[] SensorMessageBytes { get; private set; }

        public WriteSensor()
        {
            InitializeComponent();
            InitializeDefaultValues();
        }

        private void InitializeDefaultValues()
        {
            // ws_byte3~6, ws_byte7~10, ws_byte11~14, ws_byte15~18 기본값 설정
            SetSensorBytes(3, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            SetSensorBytes(7, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            SetSensorBytes(11, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            SetSensorBytes(15, new byte[] { 0x00, 0x00, 0x00, 0x00 });
        }

        private void SetSensorBytes(int startIndex, byte[] values)
        {
            for (int i = 0; i < 4; i++)
            {
                string textBoxName = "ws_byte" + (startIndex + i).ToString();
                TextBox textBox = this.Controls.Find(textBoxName, true).FirstOrDefault() as TextBox;
                if (textBox != null)
                {
                    textBox.Text = values[i].ToString("X2"); // 헥사 값으로 표시
                }
            }
        }

        private void SensorsIDCreate_Click(object sender, EventArgs e)
        {
            byte[] message = new byte[18];
            message[0] = 0x3B; // ws_byte1
            message[1] = 0x8B; // ws_byte2

            for (int i = 2; i < 18; i++)
            {
                string textBoxName = "ws_byte" + (i + 1).ToString();
                TextBox textBox = this.Controls.Find(textBoxName, true).FirstOrDefault() as TextBox;
                if (textBox != null)
                {
                    int value;
                    if (int.TryParse(textBox.Text, System.Globalization.NumberStyles.HexNumber, null, out value))
                    {
                        message[i] = (byte)value;
                    }
                    else
                    {
                        MessageBox.Show("Invalid input in " + textBoxName + ". Please enter a valid hexadecimal value.");
                        return;
                    }
                }
            }

            SensorMessageBytes = message;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Default1Button1_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                SetSensorBytes(3, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            }
        }

        private void Default2Button1_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                SetSensorBytes(3, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF });
            }
        }

        private void Default1Button2_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                SetSensorBytes(7, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            }
        }

        private void Default2Button2_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                SetSensorBytes(7, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF });
            }
        }

        private void Default1Button3_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                SetSensorBytes(11, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            }
        }

        private void Default2Button3_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                SetSensorBytes(11, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF });
            }
        }

        private void Default1Button4_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                SetSensorBytes(15, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            }
        }

        private void Default2Button4_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                SetSensorBytes(15, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF });
            }
        }
    }
}

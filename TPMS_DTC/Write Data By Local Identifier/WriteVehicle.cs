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
    public partial class WriteVehicle : Form
    {
        // 입력된 바이트 데이터를 저장할 속성
        public byte[] VehicleMessageBytes { get; private set; }

        public WriteVehicle()
        {
            InitializeComponent();
        }

        private void VehicleMessageCreate_Click(object sender, EventArgs e)
        {
            // 고정 값: 0x3B, 0x91
            byte[] message = new byte[8];
            message[0] = 0x3B; // wv_byte1
            message[1] = 0x91; // wv_byte2

            bool isValid = true;

            // wv_byte3 ~ wv_byte8 입력값을 ASCII에서 Hex로 변환
            for (int i = 2; i < 8; i++)
            {
                string boxName = string.Format("wv_byte{0}", i + 1); // TextBox 이름 가져오기
                TextBox textBox = this.Controls.Find(boxName, true).FirstOrDefault() as TextBox;

                if (textBox != null && !string.IsNullOrWhiteSpace(textBox.Text))
                {
                    if (textBox.Text.Length > 0)
                    {
                        char inputChar = textBox.Text[0]; // 첫 번째 문자 가져오기
                        message[i] = (byte)inputChar; // ASCII 값을 Hex로 변환
                    }
                    else
                    {
                        message[i] = 0x00; // 빈 값은 0으로 처리
                    }
                }
                else
                {
                    message[i] = 0x00; // TextBox가 없거나 값이 없으면 0으로 처리
                }
            }

            // 메시지 검증
            if (isValid)
            {
                VehicleMessageBytes = message; // 메시지 저장
                this.DialogResult = DialogResult.OK; // 폼 닫기
                this.Close();
            }
            else
            {
                MessageBox.Show("유효하지 않은 입력값이 포함되어 있습니다.");
            }
        }

        private void tbpn_DataByte_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

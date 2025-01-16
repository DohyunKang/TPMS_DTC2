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
    public partial class WriteVIN : Form
    {
        // 생성된 메시지를 저장할 속성
        public byte[] VINMessageBytes { get; private set; }

        public WriteVIN()
        {
            InitializeComponent();
        }

        // 메시지 생성 버튼 클릭 시 처리
        private void VINMessageCreate_Click(object sender, EventArgs e)
        {
            // 고정 값: 0x3B, 0x90
            byte[] message = new byte[19];
            message[0] = 0x3B; // wvh_byte1
            message[1] = 0x90; // wvh_byte2

            bool isValid = true;

            // wvh_byte3 ~ wvh_byte19: ASCII 입력값을 HEX로 변환
            for (int i = 2; i < 19; i++)
            {
                string boxName = string.Format("wvh_byte{0}", i + 1); // TextBox 이름 찾기
                TextBox textBox = this.Controls.Find(boxName, true).FirstOrDefault() as TextBox;

                if (textBox != null && !string.IsNullOrWhiteSpace(textBox.Text))
                {
                    string asciiValue = textBox.Text.Trim(); // ASCII 입력값
                    if (asciiValue.Length == 1) // 한 글자씩 처리
                    {
                        message[i] = (byte)asciiValue[0]; // ASCII를 HEX로 변환
                    }
                    else
                    {
                        MessageBox.Show(string.Format("wvh_byte{0}에 한 글자만 입력해주세요.", i + 1));
                        isValid = false;
                        break;
                    }
                }
                else
                {
                    MessageBox.Show(string.Format("wvh_byte{0} 값이 비어있습니다.", i + 1));
                    isValid = false;
                    break;
                }
            }

            // 유효성 검증 후 메시지 저장
            if (isValid)
            {
                VINMessageBytes = message; // 메시지 저장
                this.DialogResult = DialogResult.OK; // 폼 닫기
                this.Close();
            }
            else
            {
                MessageBox.Show("메시지를 생성할 수 없습니다. 입력값을 확인해주세요.");
            }
        }
    }
}

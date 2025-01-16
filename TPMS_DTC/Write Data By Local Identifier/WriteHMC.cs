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
    public partial class WriteHMC : Form
    {
        // 생성된 메시지를 저장할 속성
        public byte[] HMCMessageBytes { get; private set; }

        public WriteHMC()
        {
            InitializeComponent();

            // 라디오 버튼 이벤트 핸들러 등록
            sensorRadio4.CheckedChanged += Radio_CheckedChanged;
            sensorRadio5.CheckedChanged += Radio_CheckedChanged;
            HighLineRadio.CheckedChanged += Radio_CheckedChanged;
            LowLineRadio.CheckedChanged += Radio_CheckedChanged;
            MHzRadio315.CheckedChanged += Radio_CheckedChanged;
            MHzRadio433.CheckedChanged += Radio_CheckedChanged;
        }

        // 라디오 버튼 선택 시 처리
        private void Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (sensorRadio4.Checked)
            {
                SetByteValue(3, "04");
            }
            else if (sensorRadio5.Checked)
            {
                SetByteValue(3, "05");
            }

            if (HighLineRadio.Checked)
            {
                SetByteValue(4, "02");
            }
            else if (LowLineRadio.Checked)
            {
                SetByteValue(4, "01");
            }

            if (MHzRadio315.Checked)
            {
                SetByteValue(5, "01");
            }
            else if (MHzRadio433.Checked)
            {
                SetByteValue(5, "02");
            }
        }

        // 특정 바이트 값 설정 (wh_byteN의 TextBox 업데이트)
        private void SetByteValue(int byteIndex, string value)
        {
            string boxName = string.Format("wh_byte{0}", byteIndex);
            TextBox textBox = this.Controls.Find(boxName, true).FirstOrDefault() as TextBox;

            if (textBox != null)
            {
                textBox.Text = value; // UI에 값 표시 (Hex)
            }
        }

        // 메시지 생성 버튼 클릭 시 처리
        private void HMCMessageCreate_Click(object sender, EventArgs e)
        {
            // 고정 값: 0x3B, 0x86
            byte[] message = new byte[5];
            message[0] = 0x3B; // wh_byte1
            message[1] = 0x86; // wh_byte2

            bool isValid = true;

            // wh_byte3 ~ wh_byte5: 라디오 버튼에 따라 값 설정
            for (int i = 2; i < 5; i++)
            {
                string boxName = string.Format("wh_byte{0}", i + 1);
                TextBox textBox = this.Controls.Find(boxName, true).FirstOrDefault() as TextBox;

                if (textBox != null && !string.IsNullOrWhiteSpace(textBox.Text))
                {
                    try
                    {
                        message[i] = Convert.ToByte(textBox.Text, 16); // 입력값을 Hex로 변환하여 저장
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show(string.Format("wh_byte{0}에 올바른 값을 입력해주세요.", i + 1));
                        isValid = false;
                    }
                }
                else
                {
                    MessageBox.Show(string.Format("wh_byte{0} 값이 비어있습니다.", i + 1));
                    isValid = false;
                }
            }

            // 유효성 검증 후 메시지 저장
            if (isValid)
            {
                HMCMessageBytes = message; // 메시지 저장
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

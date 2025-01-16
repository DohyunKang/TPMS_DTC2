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
    public partial class WriteECU : Form
    {
        // 생성된 메시지를 저장할 속성
        public byte[] ECUMessageBytes { get; private set; }

        public WriteECU()
        {
            InitializeComponent();

            // 라디오 버튼 선택 시 UI에 값을 채우는 이벤트 핸들러 추가
            HighLineRadio.CheckedChanged += Radio_CheckedChanged;
            LowLineRadio.CheckedChanged += Radio_CheckedChanged;
        }

        // 라디오 버튼 변경 시 처리
        private void Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (HighLineRadio.Checked)
            {
                SetBytes7To15("HIGH_LINE");
            }
            else if (LowLineRadio.Checked)
            {
                SetBytes7To15("LOW_LINE");
            }
        }

        // we_byte7 ~ we_byte15에 값 설정 (ASCII로 UI 표시)
        private void SetBytes7To15(string value)
        {
            string paddedValue = value.PadRight(9, '\0'); // 길이를 9로 맞춤
            for (int i = 6; i < 15; i++)
            {
                string boxName = string.Format("we_byte{0}", i + 1);
                TextBox textBox = this.Controls.Find(boxName, true).FirstOrDefault() as TextBox;
                if (textBox != null)
                {
                    textBox.Text = paddedValue[i - 6].ToString(); // UI에 ASCII 표시
                }
            }
        }

        // 메시지 생성 버튼 클릭 시 처리
        private void ECUMessageCreate_Click(object sender, EventArgs e)
        {
            // 고정 값: 0x3B, 0x80
            byte[] message = new byte[18];
            message[0] = 0x3B; // we_byte1
            message[1] = 0x80; // we_byte2

            bool isValid = true;

            // we_byte3 ~ we_byte6: 자유 입력 (ASCII)
            for (int i = 2; i < 6; i++)
            {
                string boxName = string.Format("we_byte{0}", i + 1);
                TextBox textBox = this.Controls.Find(boxName, true).FirstOrDefault() as TextBox;

                if (textBox != null && !string.IsNullOrWhiteSpace(textBox.Text))
                {
                    char inputChar = textBox.Text[0]; // 첫 번째 문자만 가져옴
                    message[i] = (byte)inputChar; // ASCII를 Hex로 변환
                }
                else
                {
                    message[i] = 0x00; // 빈 값은 0으로 처리
                }
            }

            // we_byte7 ~ we_byte15: HIGH_LINE 또는 LOW_LINE
            if (HighLineRadio.Checked)
            {
                SetMessageBytes7To15(message, "HIGH_LINE");
            }
            else if (LowLineRadio.Checked)
            {
                SetMessageBytes7To15(message, "LOW_LINE");
            }
            else
            {
                MessageBox.Show("HIGH_LINE 또는 LOW_LINE을 선택해주세요.");
                isValid = false;
            }

            // we_byte16 ~ we_byte18: 자유 입력 (ASCII)
            for (int i = 15; i < 18; i++)
            {
                string boxName = string.Format("we_byte{0}", i + 1);
                TextBox textBox = this.Controls.Find(boxName, true).FirstOrDefault() as TextBox;

                if (textBox != null && !string.IsNullOrWhiteSpace(textBox.Text))
                {
                    char inputChar = textBox.Text[0]; // 첫 번째 문자만 가져옴
                    message[i] = (byte)inputChar; // ASCII를 Hex로 변환
                }
                else
                {
                    message[i] = 0x00; // 빈 값은 0으로 처리
                }
            }

            // 유효성 검증 후 메시지 저장
            if (isValid)
            {
                ECUMessageBytes = message; // 메시지 저장
                this.DialogResult = DialogResult.OK; // 폼 닫기
                this.Close();
            }
            else
            {
                MessageBox.Show("메시지를 생성할 수 없습니다. 입력값을 확인해주세요.");
            }
        }

        // 메시지의 7번 ~ 15번 바이트 설정
        private void SetMessageBytes7To15(byte[] message, string value)
        {
            string paddedValue = value.PadRight(9, '\0'); // 길이를 9로 맞춤
            for (int i = 6; i < 15; i++)
            {
                message[i] = (byte)paddedValue[i - 6]; // ASCII를 Hex로 변환
            }
        }
    }
}

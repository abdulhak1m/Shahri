using System;
using System.IO;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace ProjectVoice
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer speech;
        public Form1()
        {
            InitializeComponent();
            Close.Click += (s, e) => { Close(); };
            int move = 0, moveX = 0, moveY = 0;
            panel_Top.MouseDown += (s, e) => { move = 1; moveX = e.X; moveY = e.Y; };
            panel_Top.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY); };
            panel_Top.MouseUp += (s, e) => { move = 0; };

            Menu_btn.Click += (s, e) => { panel_Menu.Width = panel_Menu.Width == 200 ? 65 : 200; };

            Pause_btn.Click += (s, e) => { speech.Pause(); };
            Resume_btn.Click += (s, e) => { speech.Resume(); };
        }

        void Read_btn_Click(object sender, EventArgs e)
        {
            speech = new SpeechSynthesizer();
            speech.Rate = trkSpeed.Value;
            speech.Volume = trkVolum.Value;
            speech.SpeakAsync(txt_Speak.Text);
        }

        void Open_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "text files|*.txt";
            fileDialog.ShowDialog();
            string fileName = fileDialog.FileName;
            StreamReader stream = new StreamReader(fileName);
            txt_Speak.Text = stream.ReadToEnd();
            stream.Close();
        }

        void Record_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Wave Files|*.wav";
            saveFile.ShowDialog();
            string fileName;
            fileName = saveFile.FileName;
            speech = new SpeechSynthesizer();
            speech.Rate = trkSpeed.Value;
            speech.Volume = trkVolum.Value;
            speech.SetOutputToWaveFile(fileName);
            speech.Speak(txt_Speak.Text);
            speech.SetOutputToDefaultAudioDevice();
            MessageBox.Show("Сохранение аудио файла, прошло успешно!", "Увндомление системы.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void Exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите выключить программу?", "Уведомление системы!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)
                Close();
        }
    }
}

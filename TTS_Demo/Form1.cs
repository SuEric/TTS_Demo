using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Speech.Synthesis;

namespace TTS_Demo
{
    public partial class Form1 : Form
    {
        private SpeechSynthesizer tts;
        
        public Form1()
        {
            InitializeComponent();

            this.populateLanguagesList();

            Console.WriteLine("Currently using: " + TTSManager.sharedTTSManager.Synth.Voice.Name);
        }

        public void populateLanguagesList()
        {
            List<string> languages = new List<string>();

            foreach (InstalledVoice voice in TTSManager.sharedTTSManager.Synth.GetInstalledVoices())
            {
                languages.Add(voice.VoiceInfo.Name);
            }

            this.languagesList.DataSource = languages;
        }

        private void listenTTSButton_Click(object sender, EventArgs e)
        {
            String str = (String) this.languagesList.SelectedItem;
            TTSManager.sharedTTSManager.Synth.SelectVoice(str);
            TTSManager.sharedTTSManager.Say(textBox.Text);
        }

        private void stopTTSButton_Click(object sender, EventArgs e)
        {
            TTSManager.sharedTTSManager.Synth.SpeakAsyncCancelAll();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Speech.Synthesis;

namespace TTS_Demo
{
    public sealed class TTSManager
    {

        private SpeechSynthesizer synth;
        private int counter;
        
        private TTSManager()
        {
            synth = new SpeechSynthesizer();
            counter = 1;
            synth.SetOutputToDefaultAudioDevice();
            synth.Volume = 100;
            synth.SelectVoice(synth.GetInstalledVoices().FirstOrDefault().VoiceInfo.Name);
        }

        private static readonly Lazy<TTSManager> lazy = new Lazy<TTSManager>(() => new TTSManager());
        public static TTSManager sharedTTSManager { get { return lazy.Value; } }
        public SpeechSynthesizer Synth { get { return synth; } }

        public void Say(String str)
        {
            synth.SpeakAsyncCancelAll();
            //synth.SetOutputToWaveFile(@"C:\audio\Colors_" + counter + ".wav");
            counter++;
            synth.SpeakAsync(str);
        }
    }
}

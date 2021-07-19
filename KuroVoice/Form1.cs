using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Speech.Recognition;

namespace KuroVoice
{
    public partial class Form1 : Form
    {
        readonly SpeechRecognitionEngine engineSpeechRecog = new SpeechRecognitionEngine();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var commands = new Choices();

            commands.Add(new string[] { "hi", "print" });

            var grammarBuilder = new GrammarBuilder();
            grammarBuilder.Append(commands);
            var grammar = new Grammar(grammarBuilder);

            engineSpeechRecog.LoadGrammarAsync(grammar);
            engineSpeechRecog.SetInputToDefaultAudioDevice();
            engineSpeechRecog.SpeechRecognized += EngineSpeechRecog_SpeechRecognized;
        }

        private void EngineSpeechRecog_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "hi":
                    richTextBoxInput.Text += "\nhi.";
                    richTextBoxOutput.Text += "\nhello.";
                    break;
                case "print":
                    richTextBoxInput.Text += "\nprint";
                    richTextBoxOutput.Text += "\nprinting";
                    break;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            engineSpeechRecog.RecognizeAsync(RecognizeMode.Multiple);
            startButton.Enabled = false;
            stopButton.Enabled = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            engineSpeechRecog.RecognizeAsyncStop();
            startButton.Enabled = true;
            stopButton.Enabled = false;
        }
    }
}

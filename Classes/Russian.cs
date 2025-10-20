using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pr10.Classes
{
    public class Russian:Human
    {
        private List<Phrase> Phrases {  get; set; }
        private int stepAudio;
        private int StepAudio
        {
            get { return stepAudio; }
            set
            {
                stepAudio = value;
                if (stepAudio > Phrase.Count - 1)
                    stepAudio = 0;
            
            }
        }
        public Russian(string Name, string Img): base(Name, Img)
        {
            this.Phrases = AllPhrases();
        }

        private override void Speak(Label Phrase)
        {
            Phrase.Content = Phrases[StepAudio]._Phrase;
            MainWindow.MediaPlayer.Open(new Uri(Phrase[StepAudio].Src));
            MainWindow.MediaPlayer.Play();
            StepAudio++;
        }
        public static List<Phrase> AllPhrases()
        {
            List<Phrase> allPhrases = new List<Phrase>();
            allPhrases.Add(new Phrase("Привет", @"..."));
            allPhrases.Add(new Phrase("Как дела?", @"..."));
            allPhrases.Add(new Phrase("Меня зовут Александр", @"..."));
            return allPhrases;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace Pr10.Classes
{
    public class Russian: Human
    {
        private List<Phrase> Phrases { get; set; }
        private int stepAudio;
        private int StepAudio
        {
            get { return stepAudio; }
            set
            {
                stepAudio = value;
                if (stepAudio > Phrases.Count - 1)
                    stepAudio = 0;
            }
        }
        public Russian(string Name, string Img) : base(Name, Img)
        {
            this.Phrases = AllPhrases();
        }

        public override void Speak(Label Phrase)
        {
            Phrase.Content = Phrases[StepAudio]._Phrase;
            MainWindow.MediaPlayer.Open(new Uri(Phrases[StepAudio].Src));
            MainWindow.MediaPlayer.Play();
            StepAudio++;
        }
        public static List<Phrase> AllPhrases()
        {
            List<Phrase> allPhrases = new List<Phrase>();
            allPhrases.Add(new Phrase("Привет", @"C:\Users\student-a502\Desktop\Pr10\Voices\Russian\Hello.mp3"));
            allPhrases.Add(new Phrase("Как дела?", @"C:\Users\student-a502\Desktop\Pr10\Voices\Russian\How are you.mp3"));
            allPhrases.Add(new Phrase("Меня зовут Александр", @"C:\Users\student-a502\Desktop\Pr10\Voices\Russian\My name Aleksander.mp3"));
            return allPhrases;
        }
    }
}

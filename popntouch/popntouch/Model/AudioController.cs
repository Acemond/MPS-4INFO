using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using Microsoft.Xna.Framework.Audio;

namespace popntouch.Model
{
    class AudioController
    {
        #region Properties

        //  SINGLETON
        public static readonly AudioController INSTANCE = new AudioController();

        private AudioEngine audioEngine;
        private WaveBank waveBank;
        private SoundBank soundBank;

        #endregion // Properties
        
        #region Constructors

        private AudioController()
        {
            String path = System.Environment.CurrentDirectory;
            path = path.Replace(@"\bin\Debug", @"\Resources\music");

            audioEngine = new AudioEngine(path + @"\sound.xgs");
            waveBank = new WaveBank(audioEngine, path + @"\Wave Bank.xwb");
            soundBank = new SoundBank(audioEngine, path + @"\Sound Bank.xsb");
        }

        #endregion // Constructors

        #region Methods

        public void playSound(String sound)
        {
            soundBank.PlayCue(sound);
        }
        
        #endregion //Methods
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace popntouch.Model
{
    class Instrument
    {
        #region Properties

        public InstrumentType _name { get; set; }
        public Dictionary<PitchClass, String> _sounds { get; set; }

        #endregion // Properties

        #region Constructors

        //Empty constructor (needed in data template XAML to create the instrument)
        public Instrument() { }

        public Instrument(InstrumentType name,  Dictionary<PitchClass, String> sounds) {
            _name = name;

            // This dictionnary should be initialized in a ModelView class, or a "Party" class which manages all the different part of the application (like "PartieImpl" in Civilization project)
            _sounds = new Dictionary<PitchClass, string>();
            _sounds.Add(PitchClass.A, "a.wav");
            _sounds.Add(PitchClass.B, "b.wav");
            _sounds.Add(PitchClass.C, "c.wav");
            _sounds.Add(PitchClass.D, "d.wav");
            _sounds.Add(PitchClass.E, "e.wav");
            _sounds.Add(PitchClass.F, "f.wav");
            _sounds.Add(PitchClass.G, "g.wav");
        }


        #endregion // Constructors

        #region Methods

        public void playNote(Note n)
        {
            AudioController.INSTANCE.playSound(_sounds[n._pitch]);
        }

        #endregion //Methods
    }
}

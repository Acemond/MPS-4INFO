using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace popntouch.Model
{
    class Note
    {
        #region Properties

        public int _octave { get; set; }
        public NoteValue _duration{ get; set; }
        public PitchClass _pitch { get; set; }

        #endregion // Properties

        #region Constructors

        public Note(int oct, NoteValue value)
        {
            _octave = oct;
            _duration = value;
            _pitch = PitchClass.None;
        }

        // Constructor used by MelodyFactory
        public Note(int oct, NoteValue value, PitchClass p)
        {
            _octave = oct;
            _duration = value;
            _pitch = p;
        }

        #endregion // Constructors

        #region Methods
        #endregion //Methods
    }
}

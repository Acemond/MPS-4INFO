using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace popntouch.Model
{
    class Note
    {
        #region Properties

        public int octave { get; set; }
        public NoteValue duration{ get; set; }
        public PitchClass pitch { get; set; }

        #endregion // Properties

        #region Constructors

        public Note(int oct, NoteValue value)
        {
            octave = oct;
            duration = value;
            pitch = PitchClass.None;
        }

        // Constructor used by MelodyFactory
        public Note(int oct, NoteValue value, PitchClass p)
        {
            octave = oct;
            duration = value;
            pitch = p;
        }

        #endregion // Constructors

        #region Methods
        #endregion //Methods
    }
}

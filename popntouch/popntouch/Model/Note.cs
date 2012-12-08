using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace popntouch.Model
{
    class Note
    {
        #region Constructors

        public Note(int oct, NoteValue value)
        {
            octave = oct;
            duration = value;
            pitch = PitchClass.None;
        }

        #endregion // Constructors

        #region Properties

        public int octave
        {
            get;
            set;
        }

        public NoteValue duration
        {
            get;
            set;
        }

        public PitchClass pitch
        {
            get;
            set;
        }

        #endregion // Properties

        #region Methods
        #endregion //Methods
    }
}

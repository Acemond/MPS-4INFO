using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace popntouch.Model
{
    class NoteBubble
    {
        #region Properties

        public Note _note { get; set; }

        #endregion // Properties
        
        #region Constructors

        public NoteBubble(NoteValue duration = NoteValue.HalfNote, PitchClass pitch = PitchClass.None, int octave = 1)
        {
            _note = new Note(octave, duration, pitch);
        }

        #endregion // Constructors

        #region Methods
        #endregion //Methods
    }
}

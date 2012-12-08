using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace popntouch.Model
{
    class MelodyFactory
    {
        #region Constructors
        private MelodyFactory()
        {
            List<Note> corners = new List<Note>();
            corners.Add(new Note(1, NoteValue.EightNote));

            melodies.Add(Gesture.Corner, corners);
        }

        #endregion // Constructors

        #region Properties

        public MelodyFactory INSTANCE = new MelodyFactory();

        public Dictionary<Gesture, List<Note>> melodies
        {
            get;
            set;
        }

        #endregion // Properties

        #region Methods

        public Melody createMelody(Gesture g)
        {
            return new Melody();
        }
        #endregion //Methods
    }
}

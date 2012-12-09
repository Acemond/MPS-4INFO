using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace popntouch.Model
{
    class MelodyFactory
    {

        #region Properties

        public static readonly MelodyFactory INSTANCE = new MelodyFactory();
        public Dictionary<Gesture, List<Note>> melodies { get;  set; }

        #endregion // Properties

        #region Constructors
        private MelodyFactory()
        {
            List<Note> corners = new List<Note>();
            corners.Add(new Note(1, NoteValue.EightNote, PitchClass.A));
            corners.Add(new Note(1, NoteValue.EightNote, PitchClass.B));
            corners.Add(new Note(1, NoteValue.EightNote, PitchClass.C));

            List<Note> infinites = new List<Note>();
            infinites.Add(new Note(1, NoteValue.EightNote, PitchClass.A));

            List<Note> squares = new List<Note>();
            squares.Add(new Note(1, NoteValue.EightNote, PitchClass.A));

            List<Note> waves = new List<Note>();
            waves.Add(new Note(1, NoteValue.EightNote, PitchClass.A));

            melodies.Add(Gesture.Corner, corners);
            melodies.Add(Gesture.Infinite, infinites);
            melodies.Add(Gesture.Square, squares);
            melodies.Add(Gesture.Wave, waves);
        }

        #endregion // Constructors

        #region Methods

        public Melody createMelody(Gesture g)
        {
                return new Melody(g, melodies[g]);
        }

        #endregion //Methods
    }
}

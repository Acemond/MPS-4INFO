using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace popntouch.Model
{
    class MelodyBubbleGenerator
    {

        #region Properties

        public List<MelodyBubble> _melodyBubbles { get; set; }

        #endregion // Properties

        #region Constructors

        public MelodyBubbleGenerator()
        {
            _melodyBubbles = new List<MelodyBubble>();
        }

        #endregion // Constructors

        #region Methods

        // Generates a MelodyBubble and add it to its _melodyBubbles
        public void createMelodyBubble()
        {
            Random r = new Random();
            // Number of gestures defined
            int total = Enum.GetValues(typeof(Gesture)).Length;
            Melody m = MelodyFactory.INSTANCE.createMelody((Gesture) r.Next(total));
            _melodyBubbles.Add(new MelodyBubble(m));
        }

        public void removeFromGenerator(MelodyBubble b)
        {
            MelodyBubble bubble = _melodyBubbles.Find(e => e == b);
            _melodyBubbles.Remove(bubble);
        }

        #endregion //Methods
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace popntouch.Model
{
    class MelodyBubbleGenerator
    {
        #region Constructors

        public MelodyBubbleGenerator()
        {
            melodyBubbles = new List<MelodyBubble>();
        }

        #endregion // Constructors

        #region Properties

        public List<MelodyBubble> melodyBubbles
        {
            get;
            set;
        }

        #endregion // Properties

        #region Methods

        public void createMelodyBubble()
        {
            //Algorithme de création en fonction de ce qu'il y a déjà dans le tableau
        }

        public void removeFromGenerator(MelodyBubble b)
        {
            MelodyBubble bubble = melodyBubbles.Find(e => e == b);
            melodyBubbles.Remove(bubble);
        }

        #endregion //Methods
    }
}

﻿using JoysOfEfficiency.Utils;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.Menus;

namespace JoysOfEfficiency.OptionsElements
{
    public abstract class OptionsElementWithLabel : OptionsElement
    {
        protected OptionsElementWithLabel(string label, int x, int y, int width, int height, int whichOption = -1)
            : base(label, x, y, width, height, whichOption) { }

        private int GetOffsetLabel()
        {
            return Util.IsAndroid() ? bounds.Width + 8 : 0;
        }

        public override void draw(SpriteBatch b, int slotX, int slotY)
        {
            base.draw(b, slotX + GetOffsetLabel(), slotY);
        }
    }
}

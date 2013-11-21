﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;

namespace GTE
{
    class Resources
    {
        // STATIC FIELDS
        public static Texture2D Player, Pikachu, Pixel;
        public static SpriteFont Font1;
        public static SoundEffect Match, Travailler;

        // LOAD CONTENT
        public static void LoadContent(ContentManager Content)
        {
            Player = Content.Load<Texture2D>("player");
            Pikachu = Content.Load<Texture2D>("Pikachu");
            Pixel = Content.Load<Texture2D>("pixel");
            Font1 = Content.Load<SpriteFont>("Font1");
            Match = Content.Load<SoundEffect>("match_ready_no_focus");
            //Travailler = Content.Load<SoundEffect>("ttc");
        }// Dans cette fonction on load les textures.
    }
}

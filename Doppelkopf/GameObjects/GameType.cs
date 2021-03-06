﻿using System;
namespace Doppelkopf.GameObjects
{
    // game types need to be ordered by dominance!
    public enum GameType
    {
        CLUB_SOLO,
        SPADE_SOLO,
        HEART_SOLO,
        DIAMOND_SOLO,
        MIXED_SOLO,
        QUEEN_SOLO,
        JACK_SOLO,
        FLEISCHLOS_SOLO,
        ARMUT,
        HOCHZEIT,
        RESHUFFLING, // very short game, then
        NORMAL // healthy/gesund
    };
}

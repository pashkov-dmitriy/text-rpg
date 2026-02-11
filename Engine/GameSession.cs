using System;
using System.Collections.Generic;
using System.Text;
using TextRPG.Domain.Entities.Actor;
using TextRPG.Domain.Entities.Dungeon;

namespace TextRPG.Engine
{
    public class GameSession
    {
        public Domain.Entities.Actor.Character Character { get; }
        public Dungeon Dungeon { get; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG2
{
    public enum MonsterType
    {
        None = 0,
        Slime = 1,
        Orc = 2,
        Skeleton = 3
    }

    class Monster : Creature
    {
        protected MonsterType type;

        protected Monster(MonsterType type) : base(CreatureType.Monster)
        {
            this.type = type;
        }

        public MonsterType GetMonsterType() { return (type); }
    }

    class Slime : Monster
    {
        public Slime() : base(MonsterType.Slime)
        {
            Setinfo(10, 10);
        }
    }

    class Orc : Monster
    {
        public Orc() : base(MonsterType.Orc)
        {
            Setinfo(20, 15);
        }
    }

    class Skeleton : Monster
    {
        public Skeleton() : base(MonsterType.Skeleton)
        {
            Setinfo(15, 25);
        }
    }
}

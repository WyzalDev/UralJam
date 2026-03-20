using System;

namespace _Project.Core.Mobs
{
    [Flags]
    public enum TargetType
    {
        None = 0,
        Enemy = 1,
        Ally = 2,
    }
}
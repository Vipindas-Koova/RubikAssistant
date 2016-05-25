using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubikHacker.Common
{
    public enum Color
    {
        Red = 1,
        Blue = 10,
        Green = 91,
        Yellow = 820,
        White = 7381,
        Orange = 66429
    }

    public enum Position
    {
        Front,
        Left,
        Right,
        Back,
        Below,
        Above
    }

    public enum TurnDirection
    {
        Clockwise,
        AntiClockwise
    }

    public enum HorizontalDirection
    {
        Right,
        Left,        
    }

    public enum VerticalDirection
    {
        Downwards,
        Upwards
    }
}

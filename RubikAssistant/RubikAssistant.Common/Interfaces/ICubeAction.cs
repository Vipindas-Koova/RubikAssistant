using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubikHacker.Common
{
    interface ICubeAction
    {
        void ChangeFace(Position NewFrontFace);
        void Rotate(TurnDirection direction);
        void RotateRow(HorizontalDirection direction, int rowNumber);        
        void RotateColumn(VerticalDirection direction, int columnNumber);
    }    
}

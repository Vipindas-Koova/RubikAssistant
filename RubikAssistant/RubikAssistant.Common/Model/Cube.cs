using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubikHacker.Common
{
    public class Cube:ICubeAction
    {
        public Cube()
        {
            this.Faces = new List<Face>(6);
        }

        public List<Face> Faces { get; set; }


        public void ChangeFace(Position NewFrontFace)
        {
            
        }

        public void Rotate(TurnDirection direction)
        {
            throw new NotImplementedException();
        }

        public void RotateRow(HorizontalDirection direction, int rowNumber)
        {
            throw new NotImplementedException();
        }

        public void RotateColumn(VerticalDirection direction, int columnNumber)
        {
            throw new NotImplementedException();
        }

        public int FindFaceInFront()
        {
            return this.Faces.Find(delegate(Face f)
            {
                if (f.FaceDirection == Position.Front)
                    return true;
                else
                    return false;
            }).FaceId;
        }
    }
}

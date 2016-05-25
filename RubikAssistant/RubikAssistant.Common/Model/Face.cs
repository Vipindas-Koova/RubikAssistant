using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubikHacker.Common
{
    public class Face
    {
        public Face()
        {
        }

        public int FaceId { get; set; }

        public Position FaceDirection   { get; set; }

        public Color X1 { get; set; }

        public Color X2 { get; set; }

        public Color X3 { get; set; }

        public Color Y1 { get; set; }

        public Color Y2 { get; set; }

        public Color Y3 { get; set; }

        public Color Z1 { get; set; }

        public Color Z2 { get; set; }

        public Color Z3 { get; set; }                
    }
}

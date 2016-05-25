using RubikHacker.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RubikSimulator
{
    public partial class Simulator : Form,ICubeActionObserverBase
    {
        CubeCommandController controller = new CubeCommandController();
        Cube cube = new Cube();

        public Simulator()
        {
            InitializeComponent();
            InitializeCubeController();
            this.controller.Execute();
        }

        public void InitializeCubeController()
        {
            this.controller.Register(this);

            this.cube.Faces.Add(
                new Face()
                {
                    FaceId = 1,
                    X1 = RubikHacker.Common.Color.Blue
                });

            this.controller.Commands.Enqueue(
                new CubeActionChangeFaceCommand(this.cube, Position.Below));
        }

        public void Notify(Cube cube)
        {
            MessageBox.Show("Render cube");
        }
    }
}

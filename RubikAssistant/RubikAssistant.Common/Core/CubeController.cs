using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubikHacker.Common
{
    public class CubeCommandController:CubeStateObserverBase
    {
        public CubeCommandController()
        {
            this.Commands = new Queue<CubeActionCommandBase>();
        }

        internal Cube CubeInAction { get; set; }
        public Queue<CubeActionCommandBase> Commands { get; set; }

        public void Execute()
        {
            CubeActionCommandBase cubeCommand = this.Commands.Dequeue();

            if (cubeCommand != null)
            {
                cubeCommand.Execute();
                this.CubeInAction = cubeCommand.CubeInAction;
                this.Notify();
            }
        }

        public override void Notify()
        {
            foreach (ICubeActionObserverBase observer in observers)
            {
                observer.Notify(this.CubeInAction);
            }
        }
    }

    public abstract class CubeActionCommandBase
    {
        public Cube CubeInAction { get; set; }

        public CubeActionCommandBase(Cube cube)
        {
            this.CubeInAction = cube;
        }

        public abstract void Execute();

        //public abstract void Undo();
    }

    public class CubeActionChangeFaceCommand : CubeActionCommandBase
    {
        public CubeActionChangeFaceCommand(Cube cube) : base(cube) { }
        public CubeActionChangeFaceCommand(Cube cube, Position newPosition) : base(cube) { this.NewPosition = newPosition; }

        public Position NewPosition { get; set; }


        public override void Execute()
        {
            this.CubeInAction.ChangeFace(this.NewPosition);
        }
    }

    public class CubeActionRotateCommand : CubeActionCommandBase
    {
        public CubeActionRotateCommand(Cube cube) : base(cube) { }
        public CubeActionRotateCommand(Cube cube, TurnDirection direction) : base(cube) { this.RotateDirection = direction; }

        public TurnDirection RotateDirection { get; set; }

        public override void Execute()
        {
            this.CubeInAction.Rotate(this.RotateDirection);
        }        
    }

    public class CubeActionRotateHorizontalCommand : CubeActionCommandBase
    {
        public CubeActionRotateHorizontalCommand(Cube cube) : base(cube) { }
        public CubeActionRotateHorizontalCommand(Cube cube, HorizontalDirection direction, int rowNumber)
            : base(cube)
        { this.RotateDirection = direction; }

        public HorizontalDirection RotateDirection { get; set; }
        public int Row { get; set; }

        public override void Execute()
        {
            this.CubeInAction.RotateRow(this.RotateDirection, this.Row);
        }
    }

    public class CubeActionRotateVerticalCommand : CubeActionCommandBase
    {
        public CubeActionRotateVerticalCommand(Cube cube) : base(cube) { }
        public CubeActionRotateVerticalCommand(Cube cube, VerticalDirection direction, int rowNumber)
            : base(cube)
        { this.RotateDirection = direction; }

        public VerticalDirection RotateDirection { get; set; }
        public int Row { get; set; }

        public override void Execute()
        {
            this.CubeInAction.RotateColumn(this.RotateDirection, this.Row);
        }
    }
}

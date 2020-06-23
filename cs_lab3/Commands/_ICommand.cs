namespace cs_lab3.Commands
{
    public interface ICommand
    {
        void Move();
        void ReSize();
        void Paint();
        void Undo();
    }
}

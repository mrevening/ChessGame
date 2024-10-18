namespace ChessStateMachine.Domain
{
    public interface IState
    {
        public void HandleCheckmate(GameStateMachine game);
        public void HandleMove(GameStateMachine game);
    }
}

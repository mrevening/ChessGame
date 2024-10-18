namespace ChessStateMachine.Domain.States
{
    public class GameOver : IState
    {
        public void HandleCheckmate(GameStateMachine game)
        {
            throw new InvalidStateException();
        }

        public void HandleMove(GameStateMachine game)
        {
            throw new InvalidStateException();
        }
    }
}

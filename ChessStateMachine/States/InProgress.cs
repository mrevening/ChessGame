namespace ChessStateMachine.Domain.States
{
    public class InProgress : IState
    {
        public void HandleCheckmate(GameStateMachine game)
        {
            game.ChangeState(GameStateMachine.GameOver);
        }

        public void HandleMove(GameStateMachine game)
        {
            game.SwitchPlayer();
        }
    }
}

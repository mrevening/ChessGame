using ChessStateMachine.Domain.States;

namespace ChessStateMachine.Domain
{
    public class GameStateMachine
    {
        internal static readonly IState InProgress = new InProgress();
        internal static readonly IState GameOver = new GameOver();

        public IState CurrentState { get; private set; }
        public Player CurrentPlayer { get; private set; }

        public GameStateMachine()
        {
            CurrentPlayer = Player.White;
            CurrentState = InProgress;
        }

        public void RequestMove()
        {
            CurrentState.HandleMove(this);
        }

        public void RequestCheckmate()
        {
            CurrentState.HandleCheckmate(this);
        }

        internal void SwitchPlayer()
        {
            CurrentPlayer = CurrentPlayer == Player.Black ? Player.White : Player.Black;
        }
        internal void ChangeState(IState state)
        {
            CurrentState = state;
        }
    }
}

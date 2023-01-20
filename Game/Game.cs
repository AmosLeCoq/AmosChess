namespace Game
{
    public class Game
    {
        #region private
        private bool _gameOver = false;

        private bool _player1Turn;
        private bool _player2Turn;

        //True = White
        //False = Black
        private bool _player1Color;
        private bool _player2Color;
        #endregion private

        #region public
        public Game(bool player1Color = true, bool player2Color = false, bool player1Turn = true, bool player2Turn = false)
        {
            _player1Color = player1Color;
            _player2Color = player2Color;

            _player1Turn = player1Turn;
            _player2Turn = player2Turn;
        }

        public void PlayGame()
        {
            do
            {

            } while (_gameOver != true);
        }
        #endregion public
    }
}
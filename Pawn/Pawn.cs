namespace Pawn
{
    public class Pawn
    {
        #region private
        private int _posX;
        private int _posY;
        private bool _color;
        #endregion private

        #region public
        public Pawn(int posX, int posY, bool color)
        {
            _posX = posX;
            _posY = posY;
            _color = color;
        }

        public int PosY
        {
            get
            {
                return _posX;
            }

            set
            {
                _posX = value;
            }
        }

        public int PosX
        {
            get
            {
                return _posY;
            }

            set
            {
                _posY = value;
            }
        }

        public bool color
        {
            get
            {
                return _color;
            }
        }
        #endregion public
    }
}
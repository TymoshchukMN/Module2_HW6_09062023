namespace Module2_HW6_09062023
{
    using Module2_HW6_09062023.Enums;

    public class TV : Multimedia
    {
        private MatrixType _matrixType;

        public MatrixType MatrixType
        {
            get { return _matrixType; }
            set { _matrixType = value; }
        }

    }
}
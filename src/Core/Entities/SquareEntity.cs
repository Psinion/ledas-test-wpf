namespace Core
{
    public class SquareEntity : BaseViewModel
    {
        #region Fields

        private string a;
        private string b;
        private string c;

        private bool isValid;

        #endregion

        #region Properties

        public string A
        {
            get { return a; }
            set
            {
                a = value;
                IsValid = CheckSquareCondition();
                OnPropertyChanged();
            }
        }

        public string B
        {
            get { return b; }
            set
            {
                b = value;
                IsValid = CheckSquareCondition();
                OnPropertyChanged();
            }
        }

        public string C
        {
            get { return c; }
            set
            {
                c = value;
                IsValid = CheckSquareCondition();
                OnPropertyChanged();
            }
        }

        public bool IsValid
        {
            get { return isValid; }
            set
            {
                isValid = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Constructor

        public SquareEntity()
        {

        }

        public SquareEntity(string a, string b, string c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            isValid = CheckSquareCondition();
        }

        #endregion

        #region Public Methods 

        public bool CheckSquareCondition()
        {
            float numberA, numberB, numberC;

            if (!float.TryParse(a, out numberA) ||
                !float.TryParse(b, out numberB) ||
                !float.TryParse(c, out numberC) ||
                !float.IsNormal(numberA) ||
                !float.IsNormal(numberB) ||
                !float.IsNormal(numberC)
                )
            {
                return false;
            }

            float sqA = numberA * numberA;
            float sqB = numberB * numberB;
            float sqC = numberC * numberC;
            float sumAB = sqA + sqB;
            float sumAC = sqA + sqC;
            float sumBC = sqB + sqC;

            if (!float.IsNormal(sqA) ||
               !float.IsNormal(sqB) ||
               !float.IsNormal(sqC) ||
               !float.IsNormal(sumAB) ||
               !float.IsNormal(sumAC) ||
               !float.IsNormal(sumBC)
                )
            {
                return false;
            }

            if (sumAB == sqC ||
                sumAC == sqB ||
                sumBC == sqA)
            {
                return true;
            }

            return false;
        }

        #endregion
    }
}

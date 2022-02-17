namespace Core.ViewModels
{
    public class MainViewModel : BaseViewModel
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

        #region Private Methods

        private bool CheckSquareCondition()
        {
            float numberA, numberB, numberC;
            if (!float.TryParse(a, out numberA) || 
                !float.TryParse(b, out numberB) || 
                !float.TryParse(c, out numberC)
                )
            {
                return false;
            }

            if(numberA * numberA + numberB * numberB == numberC * numberC
                || numberA * numberA + numberC * numberC == numberB * numberB
                || numberC * numberC + numberB * numberB == numberA * numberA)
            {
                return true;
            }

            return false;
        }

        #endregion


    }
}

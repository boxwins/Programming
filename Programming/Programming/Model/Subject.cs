namespace Programming.Model
{
    public class Subject
    {
        private int _passingScore = 0;
        private string _name = string.Empty;
        private string _teacher = string.Empty;

        public int PassingScore
        {
            get { return _passingScore; }
            set
            {
                Validator.OnlyPositive(value, nameof(PassingScore));
                _passingScore = value;
            }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Teacher
        {
            get { return _teacher; }
            set { _teacher = value; }
        }

        public Subject() { }

        public Subject(string name, string teacher, int passingScore)
        {
            Name = name;
            Teacher = teacher;
            PassingScore = passingScore;
        }
    }
}

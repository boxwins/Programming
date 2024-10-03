namespace Programming.Model
{
    /// <summary>
    /// Учебная дисциплина.
    /// </summary>
    public class Subject
    {
        private int _passingScore = 0;
        private string _name = string.Empty;
        private string _teacher = string.Empty;

        /// <summary>
        /// [GET / SET] Количество очков, необходимых для получения зачета.
        /// </summary>
        public int PassingScore
        {
            get { return _passingScore; }
            set
            {
                Validator.OnlyPositive(value, nameof(PassingScore));
                _passingScore = value;
            }
        }

        /// <summary>
        /// [GET / SET] Название дисциплины.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// [GET / SET] Учитель.
        /// </summary>
        public string Teacher
        {
            get { return _teacher; }
            set { _teacher = value; }
        }

        public Subject() { }

        /// <param name="name"><see cref="Name">.</param>
        /// <param name="teacher"><see cref="Teacher">.</param>
        /// <param name="passingScore"><see cref="PassingScore">.</param>
        public Subject(string name, string teacher, int passingScore)
        {
            Name = name;
            Teacher = teacher;
            PassingScore = passingScore;
        }
    }
}

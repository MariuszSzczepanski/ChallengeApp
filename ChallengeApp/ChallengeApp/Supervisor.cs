namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {

        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public void AddGrade(float grade)
        
            {
                int valueInInt = (int)grade;
                float f = valueInInt;

                if (grade >= 0 && grade <= 100)
                {
                    this.grades.Add(grade);
                }
                else
                {
                    throw new Exception("invalid grade value");
                }
            }

            public void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(int grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.grades.Add(100);
                break;

                case "-6":
                case "6-":
                    this.grades.Add(95);
                    break;

                case "5":
                    this.grades.Add(80);
                    break;

                case "-5":
                case "5-":
                    this.grades.Add(75);
                    break;

                case "4":
                    this.grades.Add(60);
                    break;

                case "-4":
                case "4-":
                    this.grades.Add(55);
                    break;

                case "3":
                    this.grades.Add(40);
                    break;

                case "-3":
                case "3-":
                    this.grades.Add(35);
                    break;

                case "2":
                    this.grades.Add(20);
                    break;

                case "-2":
                case "2-":
                    this.grades.Add(15);
                    break;
                case "1":
                    this.grades.Add(0);
                    break;

                case "-1":
                case "1-":
                    this.grades.Add(5);
                    break;
                default:
                    throw new Exception("Do oceny występują następujące oceny: 6, -6, 6-, 5, -5, 4, -4, 4-, 3, -3, 3-, 2, -2, 2-, 1 ");
            }
        }

        public Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}

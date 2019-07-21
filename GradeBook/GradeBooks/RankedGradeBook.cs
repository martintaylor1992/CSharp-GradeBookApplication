using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if(Students.Count < 5)
            {
                throw new InvalidOperationException();
            }

            switch(averageGrade)
            {
                case var grade when grade > 80:
                    return 'A';

                case var grade when grade > 60:
                    return 'B';

                case var grade when grade > 40:
                    return 'C';

                case var grade when grade > 20:
                    return 'D';
            }

            return 'F';
        }
    }
}

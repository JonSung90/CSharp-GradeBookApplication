using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook:BaseGradeBook
    {
        RankedGradeBook(string name):base(name)
        {
            Type = GradeBookType.Ranked;
        }
    }
}

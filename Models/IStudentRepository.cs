using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentModel.Models
{
    
    public interface IStudentRepository
    {
        //Inserting a student to database.
        public bool Insert(Student s);

    }
}

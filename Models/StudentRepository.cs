using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentModel.Models
{
    //Implementing repository pattern.
    public class StudentRepository:IStudentRepository
    {
        private StudentContext context;

        public StudentRepository(StudentContext context)
        {
            
            this.context = context;
        }


        
        public bool Insert(Student s)
        {
            var query = from st in context.Students
                        where st.Name == s.Name
                        && st.Roll == s.Roll
                        select st;

            
            if (query.Count() >= 1)
                return false;
            else
            {
                
                context.Students.Add(s);
                context.SaveChanges();
                return true;
            }
        }
    }
}

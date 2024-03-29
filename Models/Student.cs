﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentModel.Models
{
    //Student model.
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        
        public int Class { get; set; }

        
        public int Roll { get; set; }

        
        public string School { get; set; }

        
        public string Gender { get; set; }



    }
}

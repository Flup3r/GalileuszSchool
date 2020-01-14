﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GalileuszSchool.Models
{

    public enum Days
    {
        Mondeay,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday

    }
    public class LessonPlan
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "--")]
        public int classroom { get; set; }

        [Required(ErrorMessage = "--")]
        public Days day { get; set; }

        [Required(ErrorMessage = "--")]
        public int startTime { get; set; }

        [Required(ErrorMessage = "--")]
        public int stopTime { get; set; }

        //[Required(ErrorMessage = "--")]
        //[ForeignKey("CourseId")]
        //public virtual Course Course { get; set; }
        public virtual int course { get; set; }

    }
}

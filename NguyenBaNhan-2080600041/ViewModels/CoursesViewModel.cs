using NguyenBaNhan_2080600041.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NguyenBaNhan_2080600041.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpCommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Item30.Models;

namespace Item30.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstMidName="Shelley",LastName="Tennison",EnrollmentDate=DateTime.Parse("2017-05-06")},
            new Student{FirstMidName="John",LastName="Doe",EnrollmentDate=DateTime.Parse("2017-04-01")},
            new Student{FirstMidName="Jane",LastName="Doe",EnrollmentDate=DateTime.Parse("2017-21-07")},
            new Student{FirstMidName="Bob",LastName="Foo",EnrollmentDate=DateTime.Parse("2017-19-02")},
            new Student{FirstMidName="Ann",LastName="Baz",EnrollmentDate=DateTime.Parse("2017-10-10")},
            new Student{FirstMidName="Sarah",LastName="Quirk",EnrollmentDate=DateTime.Parse("2017-27-08")},
            new Student{FirstMidName="Sean",LastName="Bar",EnrollmentDate=DateTime.Parse("2017-03-05")},
            new Student{FirstMidName="Chuck",LastName="Smith",EnrollmentDate=DateTime.Parse("2017-20-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{CourseID=0001,Title="Computer Basics"},
            new Course{CourseID=0002,Title="Overview of Software Development"},
            new Course{CourseID=0003,Title="Version Control"},
            new Course{CourseID=0004,Title="HTML and CSS"},
            new Course{CourseID=0005,Title="Database and SQL"},
            new Course{CourseID=0006,Title="Basic Javascript"},
            new Course{CourseID=0007,Title="Python"},
            new Course{CourseID=0008,Title="Visual Studio"},
            new Course{CourseID=0009,Title="C# and ASP.Net"},
            new Course{CourseID=0010,Title="Project Managment"}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=0010},
            new Enrollment{StudentID=1,CourseID=0002},
            new Enrollment{StudentID=1,CourseID=0001},
            new Enrollment{StudentID=2,CourseID=0005},
            new Enrollment{StudentID=2,CourseID=0001},
            new Enrollment{StudentID=2,CourseID=0009},
            new Enrollment{StudentID=3,CourseID=0007},
            new Enrollment{StudentID=4,CourseID=0008},
            new Enrollment{StudentID=4,CourseID=0006},
            new Enrollment{StudentID=5,CourseID=0003},
            new Enrollment{StudentID=6,CourseID=0008},
            new Enrollment{StudentID=7,CourseID=0010},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}
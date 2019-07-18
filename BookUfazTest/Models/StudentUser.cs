using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookUfazTest.Models
{
    public class StudentUser : IdentityUser
    {
        
        public string StudentNameSurname { get; set; }
        public string UnistraCardId{ get; set; }
        public int YearId { get; set; }
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }
        public Year Year { get; set; }




    }
}/*
table students
{
    id int [pk]
    cardId int [not null, unique]
    password string
  yearId int [ref: > years.id]
    facultyId int [ref: > faculties.id]
    gradesId int [ref: > grades.id]
}


table years
{
    id int [pk]
    name string
  
}


table grades
{
    id int [pk]
    subjectId int [ref: > subjects.id]
    facultyId int [ref: > faculties.id]
    yearId int [ref: > years.id]
    semesterId int [ref: > semesters.id]

    mark double
  
}

table faculties
{
    id int [pk]
    name string
}

table subjects
{
    id int [pk]
    name string
}


table semesters
{
    id int [pk]
    name string
}






*/
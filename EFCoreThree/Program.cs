// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using ConsoleTables;
using System.Reflection;

Console.WriteLine("Hello, World!");




// عشان ارجع داتا من الداتا بيز باستخدم السطر ده 
// scaffold - dbContext 'Data Source=(localdb)\ProjectsV13;Initial Catalog=EFCore' Microsoft.EntityFrameworkCore.SqlServer - OutputDir Models - Context ApplicationDbContext - DataAnnotat




#region ways to select item from table 
var subject = Database.SampleSubjects.SingleOrDefault(s => s.SubjectId == 5 && s.SubjectName.StartsWith("m"));
//you can use (> , < , >= , <=) and its select first item of it
var subject2 = Database.SampleSubjects.FirstOrDefault(s => s.SubjectId > 5);
var subject3 = Database.SampleSubjects.OrderBy(s=>s.SubjectId).LastOrDefault(s => s.SubjectId > 5);
Console.WriteLine(subject3 == null ? "is not Exist" : subject3.SubjectName);

var instr = Database.SampleInstructors.Where(m=>m.InstructorId > 5 || m.FirstName.StartsWith("m")).ToList();
ConsoleTable.From<Instructor>(instr).Write();

#endregion

var instrAny = Database.SampleInstructors.Any(m=>m.InstructorId > 5); // return true or false // with first elemnt maching the expression return true
var instrAll = Database.SampleInstructors.All(m=>m.InstructorId > 5); // return true or false // if all elemnt maching the expression return true 

//adding item to the selected list in start of the table or in the end
var instrAddItemInStart = Database.SampleInstructors.Prepend(new Instructor { FirstName = "test", LastName = "test", Email = "test", InstructorId=555 });
var instrAddItemInEnd = Database.SampleInstructors.Append(new Instructor { FirstName = "test", LastName = "test", Email = "test", InstructorId = 555 });


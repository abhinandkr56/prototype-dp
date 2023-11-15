// See https://aka.ms/new-console-template for more information

using PrototypePatternPlayPen.Shapes;
using PrototypePatternPlayPen.Students;

var student = new UniversityStudent();
student.Name = "Abhi";
student.Age = 12;
student.CGPA = 8;

var shallowClone = student.ShalloCopy() as UniversityStudent;

var anotherStudent = student.Clone();
Console.WriteLine(student.GetHashCode() == shallowClone.GetHashCode());
Console.WriteLine(student.GetHashCode() == anotherStudent.GetHashCode());
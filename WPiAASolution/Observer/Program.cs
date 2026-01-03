using Observer;

var lecturer = new Lecturer("Jerzy Król");

var student1 = new Student("Jacek");
var student2 = new Student("Marysia");
var student3 = new Student("Zosia");


lecturer.RegisterStudent(student1);
lecturer.RegisterStudent(student2);
lecturer.RegisterStudent(student3);

lecturer.AssignGrade("Jacek", 2);
lecturer.AssignGrade("Marysia", 4);
lecturer.AssignGrade("Zosia", 5);

lecturer.NotifyStudents();

lecturer.UnregisterStudent(student2);
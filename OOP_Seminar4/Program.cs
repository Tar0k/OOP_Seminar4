﻿using OOP_Seminar4;

var someStudents = new List<Student>();
var random = new Random();

for (var i = 0; i < 5; i++)
{
    var student = new Student(id: i,
        firstName: Faker.Name.First(),
        middleName: Faker.Name.Middle(),
        lastName: Faker.Name.Last(),
        studentNumber: random.Next(1, 1000),
        birthDate: DateOnly.FromDateTime(Faker.Identification.DateOfBirth()));
    someStudents.Add(student);
}

var testGroup = new Group("testGroup", someStudents);

var controller = new StudentController(new List<Group>() { testGroup });

Console.WriteLine("===========================");
Console.WriteLine(testGroup);


Console.WriteLine("=======Удаление по имени========");
Console.Write("Введите Id на удаление: ");
int deleteId;
while (!int.TryParse(Console.ReadLine(), out deleteId)) { }
controller.RemoveStudent(deleteId);

Console.WriteLine(testGroup);


Console.WriteLine("=======Сортировка========");
controller.Sort();
Console.WriteLine(testGroup);

Console.WriteLine("=======Домашняя работа========");

var stream1 = new LearningStream("Поток1", new List<Group>());
stream1.GenerateRandomGroup(random.Next(1,10));
var stream2 = new LearningStream("Поток2", new List<Group>());
stream2.GenerateRandomGroup(random.Next(1,10));
var stream3 = new LearningStream("Поток3", new List<Group>());
stream3.GenerateRandomGroup(random.Next(1,10));
var stream4 = new LearningStream("Поток4", new List<Group>());
stream4.GenerateRandomGroup(random.Next(1,10));

var streamService = new StreamService();
streamService.Add(stream1);
streamService.Add(stream2);
streamService.Add(stream3);
streamService.Add(stream4);

Console.WriteLine("=======До сортировки========");
Console.WriteLine(streamService);

streamService.Sort();

Console.WriteLine("=======После сортировки========");
Console.WriteLine(streamService);
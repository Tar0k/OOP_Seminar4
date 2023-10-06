using OOP_Seminar4.Controller;

var controller = new TeacherController();
for (var i = 0; i < 10; i++)
{
    controller.Create(firstName: Faker.Name.First(),
        secondName: Faker.Name.Last(),
        patronymic: Faker.Name.Middle(),
        dateOfBirth: DateOnly.FromDateTime(Faker.Identification.DateOfBirth()));
}
controller.Print();
Console.WriteLine("==============================================================");
var input = Console.ReadLine();
var teacher = controller.Find(secondName: input);
Console.WriteLine(teacher);
controller.Edit(teacher, "name", "lastName");
Console.WriteLine("==============================================================");
controller.Print();
using knowledgecheck2;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Student>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var student = new Student();

    Console.Write("Enter the value for Name: ");
    student.Name = Console.ReadLine();

    Console.Write("Enter the value for Age: ");
    student.Age = int.Parse(Console.ReadLine());

    Console.Write("Enter the value for StudentID: ");
    student.StudentID = int.Parse(Console.ReadLine());

    recordList.Add(student);
}

//Print out the list of records using Console.WriteLine()
foreach (var Student in recordList)
{
    Console.WriteLine("=================================");
    Console.WriteLine($"Name:      {Student.Name}");
    Console.WriteLine($"Age:       {Student.Age}");
    Console.WriteLine($"StudentID: {Student.StudentID}");
    Console.WriteLine();
}
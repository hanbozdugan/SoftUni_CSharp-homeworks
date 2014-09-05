using System;
class EmployeeData
{
    static void Main()
    {
        string firstName, familyName;
        byte age;
        char gender;
        int idNumber;
        ushort uniqueEmpNumber;
        firstName = "Иван";
        familyName = "Иванов";
        age = 41;
        gender = 'М';
        idNumber = 345;
        uniqueEmpNumber = 213;
        Console.WriteLine("Персонална информация за {0} {1}:\n\nИме: {0}\nФамилия: {1}\nВъзраст: {2}\nПол: {3}\nЕГН: {4}\nУникален номер на служителя : {5}", firstName, familyName, age, gender, idNumber, 27560000 + uniqueEmpNumber);
    }
}

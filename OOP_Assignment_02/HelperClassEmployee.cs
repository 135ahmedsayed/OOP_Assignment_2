using System.Globalization;

namespace OOP_Assignment_02;

#region With Q1
//public class Employees
//{
//    private int ID;
//    private string Name;
//    private security_privileges security_level;
//    private double salary;
//    private DateTime hire_date ;
//    private Gender Gender;

//    //Constructor
//    public Employees(int id, string name, security_privileges security_level, double salary, DateTime hire_date, Gender gender)
//    {
//        ID = id;
//        Name = name;
//        this.security_level = security_level;
//        this.salary = salary;
//        this.hire_date = hire_date;
//        Gender = gender;
//    }
//    public override string ToString()
//    {
//        return $"ID : {ID} \n" +
//               $"Name : {Name}\n" +
//               $"Security Level: {security_level}\n" +
//               $"Salary: {String.Format(CultureInfo.CurrentCulture, "{0:C}", salary)}\n" +
//               $"Hire date : {hire_date}\n" +
//               $"Gender: {Gender}\n" 
//               ;
//    }
//}
//// Gender
//public enum Gender
//{
//    Male,
//    Female,
//    M = 0,
//    F = 1,
//};
////security privileges
//public enum security_privileges
//{
//    guest,
//    Developer,
//    secretary,
//    DBA,
//};

#endregion

#region With Q2

//public class Employees
//{
//    private int ID;
//    private string Name;
//    private security_privileges security_level;
//    private double salary;
//    private HireDate Hire_date;
//    private Gender Gender;

//    // Hire Date

//    public Employees(int id, string name, security_privileges security_level, double salary, HireDate hire_date, Gender gender)
//    {
//        ID = id;
//        Name = name;
//        this.security_level = security_level;
//        this.salary = salary;
//        this.Hire_date = hire_date;
//        Gender = gender;
//    }
//    public override string ToString()
//    {
//        return $"ID : {ID} \n" +
//               $"Name : {Name}\n" +
//               $"Security Level: {security_level}\n" +
//               $"Salary: {String.Format(CultureInfo.CurrentCulture, "{0:C}", salary)}\n" +
//               $"{Hire_date}" +
//               $"Hire Date : {Hire_date.Day}/{Hire_date.Month}/{Hire_date.Year}\n" +
//               $"Gender: {Gender}\n"
//               ;
//    }
//}
//// Gender
//public enum Gender
//{
//    Male,
//    Female,
//    M = 0,
//    F = 1,
//};
////security privileges
//public enum security_privileges
//{
//    guest,
//    Developer,
//    secretary,
//    DBA,
//};
//// class HireDate
//public class HireDate
//{
//    public int Day;
//    public int Month;
//    public int Year;

//    public HireDate(int day, int month, int year)
//    {
//        Day = day;
//        Month = month;
//        Year = year;
//    }
//    public override string ToString()
//    {
//        return $"Day   : {Day}\n" +
//               $"Month : {Month}\n"  + 
//               $"Year  : {Year}\n"
//               ;
//    }
//}

#endregion

#region With Q3

//public class Employees
//{
//    private int ID;
//    private string Name;
//    private security_privileges security_level;
//    private double salary;
//    private HireDate Hire_date;
//    private Gender Gender;

//    // Hire Date

//    public Employees(int id, string name, security_privileges security_level, double salary, HireDate hire_date, Gender gender)
//    {
//        ID = id;
//        Name = name;
//        this.security_level = security_level;
//        this.salary = salary;
//        this.Hire_date = hire_date;
//        Gender = gender;
//    }
//    public override string ToString()
//    {
//        return $"ID : {ID} \n" +
//               $"Name : {Name}\n" +
//               $"Security Level: {security_level}\n" +
//               $"Salary: {String.Format(CultureInfo.CurrentCulture, "{0:C}", salary)}\n" +
//               $"{Hire_date}" +
//               $"Hire Date : {Hire_date.Day}/{Hire_date.Month}/{Hire_date.Year}\n" +
//               $"Gender: {Gender}\n"
//               ;
//    }
//}
//// Gender
//public enum Gender
//{
//    Male,
//    Female,
//    M = 0,
//    F = 1,
//};
////security privileges
//public enum security_privileges
//{
//    guest,
//    Developer,
//    secretary,
//    SecurityOfficer,
//    DBA,
//};
//// class HireDate
//public class HireDate
//{
//    public int Day;
//    public int Month;
//    public int Year;

//    public HireDate(int day, int month, int year)
//    {
//        if (year < 1900 || year > DateTime.Now.Year)
//            throw new ArgumentOutOfRangeException(nameof(year), "Year out of range");
//        if (month < 1 || month > 12)
//            throw new ArgumentOutOfRangeException(nameof(month), "Month must be 1–12");
//        if (day < 1 || day > DateTime.DaysInMonth(year, month))
//            throw new ArgumentOutOfRangeException(nameof(day), "Invalid day for that month/year");

//        Day = day;
//        Month = month;
//        Year = year;
//    }
//    public override string ToString()
//    {
//        return $"Day   : {Day}\n" +
//               $"Month : {Month}\n" +
//               $"Year  : {Year}\n"
//               ;
//    }
//}

#endregion


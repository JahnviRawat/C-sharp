using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practiceDemo.day2;
using practiceDemo.day3;
using practiceDemo.day4;
using practiceDemo.day5;
using practiceDemo.day6;
using practiceDemo.day7;
using practiceDemo.dayFile;
namespace practiceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 
            //SecondDay.commonArrayValues();
            //SecondDay.multiDimensionalArray();
            //SecondDay.getData();
            //SecondDay.stringMethods();
            //SecondDay.countEvenAndOdd(10,20,1,3,45,65,67,89,26,76);
            //SecondDay.duplicateNumber(2, 2, 34, 56, 34, 78, 98, 34, 56, 65, 89);
            //SecondDay.mergeTwoArrays();
            //int[] arr = { 1, 12, 3, 4, 5, 16, 7, 18, 9 };


            //Console.WriteLine("Enter reverse value true or false");
            //bool rev = bool.Parse(Console.ReadLine());
            //SecondDay.displayArray(arr,rev);

            //SecondDay.addMatrix();
            //SecondDay.sumOfEachRow();
            //SecondDay.printDiagonal();
            //SecondDay.avgOfRowJagged();

            //String[] str1 = { "Apple", "Banana", "WaterMelon", "Kiwi" };
            //String str = SecondDay.longestString(str1);
            //Console.WriteLine(str); 

            //SecondDay.joinStrings();
            //SecondDay.replaceWord();

            //car car = new car() { id = 1 };
            //car.displaycardetails();

            //MyTeam team = new MyTeam() { id = 1, teamName = new string[]{"Math","cs"}};
            //team.printTeamDetails();

            //Student student = new Student() { sId=100,sName="morvi",sMarks=300};
            //student.getGrade();

            //classC obC = new classC();
            //obC.AFun();
            //obC.BFun();
            //obC.CFun();



            //EmployeeInfo[] empob = {
            //    new EmployeeInfo() { Name="Morvi",yearOfJoining=2024,salary=20,address="bangalore" },
            //    new EmployeeInfo() { Name="Mansi",yearOfJoining=2024,salary=20,address="bangalore" },
            //    new EmployeeInfo() { Name="Manu",yearOfJoining=2024,salary=20,address="bangalore" }
            //};
            //for (int i = 0; i < empob.Length; i++)
            //{
            //    empob[i].displayDetails();
            //}

            //Console.WriteLine("Enter First Name");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("Enter Second Name");
            //string lastName = Console.ReadLine();
            //Console.WriteLine("Enter Dob");
            //string dob = Console.ReadLine();


            //PersonCls ob = new PersonCls(firstName, lastName, dob) ;
            //ob.printDetails();

            //DerivedCls ob = new DerivedCls(100);

            //Animal ob = new Dog();
            //ob.makeSound();

            //ob = new Cat(); 
            //ob.makeSound();

            //Manager manager = new Manager() {Name="Morvi",Age=22,salary=90,Bonus=20 };
            //manager.displayDetails();

            //Vehicle vehicle = new Vehicle();
            //vehicle.drive();

            //vehicle = new Car();
            //vehicle.drive();

            //vehicle = new Bike();
            //vehicle.drive();

            //Circle circle = new Circle() { radius=20};
            //circle.calculateArea();

            //Rectangle rectangle = new Rectangle() { length=10,width=20};
            //rectangle.calculateArea();

            //PartTimeEmp partTimeEmp = new PartTimeEmp() { empId=1,fName="Morvi",lName="Rawat",dept="It",totalHoursWorked=20,RatePerHour=7 };
            //partTimeEmp.displayDetails();
            //partTimeEmp.calcSalary();

            //FullTimeEmp fullTimeEmp = new FullTimeEmp() { empId = 1, fName = "Mansi", lName = "Srivastav", dept = "Admin", MonthlySalary= 30000};
            //fullTimeEmp.displayDetails();
            //fullTimeEmp.calcSalary();

            //ShapeClass shapeClass = new CircleClass() { radius=20};
            //shapeClass.calculateArea();
            //shapeClass = new RectangleClass() { length=20 , width = 30};
            //shapeClass.calculateArea();
            //shapeClass = new TriangleClass() { base1 = 20, heigth = 34 };
            //shapeClass.calculateArea();

            //Iplayable iplayable = new MusicPlayer();
            //iplayable.play();

            //iplayable = new VideoPlayer();
            //iplayable.play();

            //EmployeeClass emp = new EmployeeClass() { empId="e1",dept="HR", salary = 30,designation="Manager"};
            //emp.printEmpDetails();

            #endregion

            #region // day6
            //tuples ob = new tuples();
            //var t = ob.splitFullName("Jahnvi Rawat");
            //Console.WriteLine(t.Item1);
            //Console.WriteLine(t.Item2);


            //ManagerDetails manager = new ManagerDetails("Morvi", "It", 65324);
            //manager.getDtails();
            //manager.getDtails1();
            //manager.getManagerDetails();

            //string str = "hello";
            //char ch = 'l';
            //Console.WriteLine(str.countOccurence(ch));


            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Console.WriteLine(arr.checkEvenCount());
            #endregion

            #region //collections

            //collectionsAssgn cOb = new collectionsAssgn();
            //Console.WriteLine("Enter key");
            //int key = int.Parse(Console.ReadLine());
            //cOb.HashCountry(key);

            //custDetails custDetails = new custDetails();
            //custDetails.displayDetails();

            //custDetails.getReport(new DateTime(year: 2025, month: 05, day: 03), new DateTime(year: 2025, month: 05, day: 29));

            //custDetails.customerDetId(100);
            #endregion

            #region // exception, string

            //exceptionDemo exceptionDemo = new exceptionDemo();
            //exceptionDemo.excpDemo();


            //StringClass stringClass = new StringClass();
            //stringClass.stringDemo("Hello");
            //var res = stringClass.countChar("hello", 'l');
            //Console.WriteLine(res);

            //stringClass.formatString();
            //stringClass.compareStrings();

            //stringClass.stringBuilderDemo();
            //stringClass.stringBuilderDemo2();
            //stringClass.removeOccStringBuilder();

            //carDemo basic = new Builder_Demo()

            //.CarName("Alto")

            //.CarColor("Black")

            //.Price(1000000)

            //.buildcar();

            //basic.display();



            //carDemo lux = new Builder_Demo()

            //    .CarName("Ertiga")

            //    .CarColor("White")

            //    .Price(1200000)

            //    .WithAC(true)

            //    .buildcar();

            //lux.display();
            #endregion

            #region  // file and directory

            dirClass dir = new dirClass();
            dir.addDir();
            #endregion
        }
    }

   
}

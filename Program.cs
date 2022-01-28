using ConsoleApp1;
// See https://aka.ms/new-console-template for more information
/*
string Name = "Muhammad Rameez";
int Semester = 4;
double GPA = 3.2;
string University = "GCU Lahore ";

Console.WriteLine($"My name is {Name}. I am doing BSCS from {University}. Currently, I am in {Semester} semester and my current CGPA is {GPA} ");

*/

/*Create a string story using variables Name, Semester, GPA, and University.
*/


//----------------------------------------------------------------------------------

/*Create a class named Calculator and create a function "Subtract" with 2 parameters (double) 
 * and return the result value.Print it in the main function. (Take input from user)
*/

//Question 2
/*
Calculator calculator = new Calculator();
Console.WriteLine( "Enter the first number : ");
double first = Convert.ToDouble(Console.ReadLine());
Console.WriteLine( "Enter the second number : ");
double second = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(calculator.Subtract(first, second)); 

*/


//----------------------------------------------------------------------------------

//Question 3
/*Create class named Course with properties Title, Duration (Number of Months),
 * Cost, & Description. Create its 3 objects and use foreach loops to print them.
*/
/*

Course course1 = new Course();
Course course2 = new Course();
Course course3 = new Course();

course1.Cost = 10000;
course1.Duration = 4.5;
course1.Description = "This is the course of Web Developement ";
course1.Title = "Web Developement ";

course2.Cost = 20000;
course2.Duration = 2.5;
course2.Description = "This is the course of Blockchain Developement ";
course2.Title = "Blockchain Developement ";

course3.Cost = 30000;
course3.Duration = 3.5;
course3.Description = "This is the course of App Developement ";
course3.Title = "App Developement ";

List<Course> courses = new List<Course>()
{
    course1 , course2, course3
};


foreach (var item in courses)
{
    Console.WriteLine($" The title of this course is {item.Title}.\n The cost of this course is {item.Cost}.\n the Duration ofm this vcoiurse is {item.Duration}.\n Course Description :\n {item.Duration}");
}
*/
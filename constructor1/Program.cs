// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
class Course{
int courseCode;
string courseName;
int coursecredit;

Course(int Coursecode1, String CourseName1, int Coursecredit1){
	courseCode = Coursecode1;
	courseName = CourseName1;
	coursecredit = Coursecredit1;

}

public static void  Main(string[] args){

Course course1 = new Course(123, "Scripting", 456);
Console.WriteLine( "Course : " +course1.courseName);
Console.WriteLine( "Course code : " +course1.courseCode);
Console.WriteLine( "Course credit : " +course1.coursecredit);
Console.ReadLine();


}


}


class Course{
int courseCode;
string courseName;
int courseCredit;
int codeMatkul;
int creditsMatkul;
//constructor
Course(int theCourseCode, String theCourseName, int theCourseCredit, int theCodeMatkul, int theCreditsMatkul){
	courseCode = theCourseCode;
	courseName = theCourseName;
	courseCredit = theCourseCredit;
	codeMatkul = theCodeMatkul;
	creditsMatkul = theCreditsMatkul;

}
//copy constructor
Course(Course c1){
	courseCode = c1.courseCode;
	courseName = c1.courseName;
	creditsMatkul = c1.creditsMatkul;

}

static void  Main(string[] args){
//call constructor
Course course1 = new Course(123, "GameArtDesign", 60, 50, 6);
Console.WriteLine("Course 1");
Console.WriteLine( "Course Code : " +course1.courseCode);
Console.WriteLine( "Course Name: " + course1.courseName);
Console.WriteLine( "Course Credit : " + course1.courseCredit);
Console.WriteLine( "Code Matkul : " + course1.codeMatkul);
Console.WriteLine( "Credits Matkul : " + course1.creditsMatkul);
//call the copy constructor
Course course2 = new Course(course1);
Console.WriteLine ("" );
Console.WriteLine ("Course2" );
Console.WriteLine ("Course Code for course 2: " + course2.courseCode);
Console.WriteLine ("Course Name for course 2: " + course2.courseName);
Console.WriteLine ("Credits Matkul: " + course2.creditsMatkul);
Console.ReadLine();

}


}

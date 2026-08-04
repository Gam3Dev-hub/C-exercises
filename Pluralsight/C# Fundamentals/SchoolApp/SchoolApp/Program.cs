global using static System.Console;

namespace SchoolApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School school = new School("Greenwood High", "123 Main St");

            //Teacher mathTeacher = new Teacher("John", "Smith", new DateTime(1980, 5, 15));
            //Teacher historyTeacher = new Teacher("Emily", "Johnson", new DateTime(1975, 3, 20));
            //Teacher scienceTeacher = new Teacher("Michael", "Brown", new DateTime(1990, 8, 10));

            //AddTeacher(school, mathTeacher);
            //AddTeacher(school, historyTeacher);
            //AddTeacher(school, scienceTeacher);


           

            
            //Student student = new Student("daniel", "turunen", new DateTime(2008, 1, 1));
            //student.Courses.Add(new Course("Mathematics", "MATH101", mathTeacher));
            //student.Courses.Add(new Course("History", "HIST101", historyTeacher));
            //student.Courses.Add(new Course("Science", "SCI101", scienceTeacher));

            //student.Assignments.Add(new Assignment("Math Homework 1", new DateTime(2024, 10, 1)));
            //student.Assignments.Add(new Assignment("History Essay", new DateTime(2024, 10, 5)));
            //student.Assignments.Add(new Assignment("Science Project", new DateTime(2024, 10, 10)));

            //WriteLine($"Student: {student.FirstName} {student.LastName}");
            //WriteLine($"Date of Birth: {student.DateOfBirth.ToShortDateString()}");
            //WriteLine("Courses:");
            //foreach (var course in student.Courses)
            //{
            //    WriteLine($"- {course.CourseDescription} ({course.CourseName})");
            //}
            //WriteLine("Assignments:");
            //foreach (var assignment in student.Assignments)
            //{
            //    WriteLine($"- {assignment.AssignmentName} (Due: {assignment.DueDate.ToShortDateString()})");
            //}

            try
            {
                bool isRunning = true;
                while (isRunning)
                {
                    WriteLine("Welcome to the School App! type 'help' for available commands.");
                    //var test = DateTime.TryParse(ReadLine(), out var date);
                    //WriteLine("Parsed date: " + test + ", Value: " + date);
                    var userInput = ReadLine();
                   
                    //if(userInput == "help")
                    //{
                    //    DisplayCommands();
                    //}
                    //else if (userInput == "exit")
                    //{
                    //    isRunning = false;
                    //}
                    //else
                    //{
                    //    WriteLine("Command not recognized. Type 'help' for available commands.");
                    //}

                    switch (userInput) 
                    {
                        case "help":
                            DisplayCommands();
                            break;
                        case "exit":
                            isRunning = false;
                            break;
                        case "1":
                            WriteLine("Enter student details: firstName lastName dateOfBirth(yyyy-MM-dd)");
                            var studentDetails = ReadLine().Split(' ');
                            var newStudent = new Student(studentDetails[0], studentDetails[1], DateTime.Parse(studentDetails[2]));
                            
                           
                            AddStudent(school, newStudent);
                            WriteLine($"Student added successfully: {newStudent.FirstName} {newStudent.LastName}, Date of Birth: {newStudent.DateOfBirth.ToShortDateString()}");
                            break;
                        case "2":
                            WriteLine("Enter teacher details: firstName lastName dateOfEmployment(yyyy-MM-dd)");
                            var teacherDetails = ReadLine().Split(' ');
                            var newTeacher = new Teacher(teacherDetails[0], teacherDetails[1], DateTime.Parse(teacherDetails[2]));
                            AddTeacher(school, newTeacher);
                            WriteLine($"Teacher added successfully: {newTeacher.FirstName} {newTeacher.LastName}, Date of Employment: {newTeacher.DateOfEmployment.ToShortDateString()}");
                            break;
                        case "3":
                            WriteLine("Enter course details: courseName courseDescription teacherFirstName teacherLastName");
                            var courseDetails = ReadLine().Split(' ');
                            var teacher = school.teachers.FirstOrDefault(t => t.FirstName == courseDetails[2] && t.LastName == courseDetails[3]);
                            if (teacher != null)
                            {
                                var newCourse = new Course(courseDetails[0], courseDetails[1], teacher);
                                AddCourse(school, newCourse);
                                WriteLine($"Course added successfully: {newCourse.CourseName}, Description: {newCourse.CourseDescription}");
                                AssignCourseToTeacher(teacher, newCourse);
                                WriteLine($"Course {newCourse.CourseName} assigned to teacher {teacher.FirstName} {teacher.LastName} successfully.");
                            }
                            else
                            {
                                WriteLine("Teacher not found. Please add the teacher before creating the course.");
                            }
                            break;
                        case "4":
                            WriteLine("Enter assignment details: assignmentName dueDate(yyyy-MM-dd) courseName");
                            var assignmentDetails = ReadLine().Split(' ');
                            var courseForAssignment = school.courses.FirstOrDefault(c => c.CourseName == assignmentDetails[2]);
                            if (courseForAssignment != null)
                            {
                                var newAssignment = new Assignment(assignmentDetails[0], DateTime.Parse(assignmentDetails[1]));
                                AddAssignment(school, newAssignment);
                                AddAssignmentToCourse(courseForAssignment, newAssignment);
                                WriteLine($"Assignment added successfully: {newAssignment.AssignmentName}, Due Date: {newAssignment.DueDate.ToShortDateString()} to course {courseForAssignment.CourseName}");
                            }
                            else
                            {
                                WriteLine("Course not found. Please add the course before creating the assignment.");
                            }
                            break;
                        case "5":
                            DisplayAllStudents(school);
                            displayassignments(school);
                            WriteLine("Select an assignment to add to the student:");
                            var assignmentToAdd = int.TryParse(ReadLine(), out var assignment);
                            //while(assignment >= school.assignments.Count)
                            //{
                            //    WriteLine("Incorrect index selected! Select a valid assignment index");
                            //    assignmentToAdd = int.TryParse(ReadLine(), out assignment);
                            //}
                            WriteLine("Select a student to assign the assignment to:");
                            var studentToAssign = int.TryParse(ReadLine(), out var studentIndex);
                            //while(studentIndex >= school.students.Count)
                            //{
                            //    WriteLine("Incorrect index selected! Select a valid assignment index");
                            //    studentToAssign = int.TryParse(ReadLine(), out studentIndex);
                            //}
                            if (assignmentToAdd && studentToAssign)
                            {
                                AddAssignmentToStudent(school.students[studentIndex], school.assignments[assignment]);
                                WriteLine($"Assignment {school.assignments[assignment]} added to student {school.students[studentIndex]} successfully");
                            }
                            break;
                        case "6":
                            DisplayAllCourses(school);
                            WriteLine("Select a course to assign to the student:");
                            var courseToAssign = int.TryParse(ReadLine(), out var courseIndex);
                            DisplayAllStudents(school);
                            WriteLine("Select a student to assign the course to:");
                            var stud = int.TryParse(ReadLine(), out var s);
                            if (courseToAssign && stud)
                            {
                                AddStudentToCourse(school.students[s], school.courses[courseIndex]);
                            }
                            break;
                        case "7":
                            displayassignments(school);
                            WriteLine("Select an assignment to assign to the course:");
                            var assignToCourse = int.TryParse(ReadLine(), out var assignmentIndex);
                            DisplayAllCourses(school);
                            WriteLine("Select a course to assign the assignment to:");
                            var courseForAssign = int.TryParse(ReadLine(), out var courseForAssignIndex);
                            if (assignToCourse && courseForAssign)
                            {
                                AddAssignmentToCourse(school.courses[courseForAssignIndex], school.assignments[assignmentIndex]);
                                WriteLine($"Added assignment: {school.assignments[assignmentIndex]} to course: {school.courses[courseForAssignIndex]}");
                            }
                            break;
                        case "8":
                            WriteLine("Select a course to display info:");
                            DisplayAllCourses(school);
                            var courseToDisplay = int.TryParse(ReadLine(), out var courseInfoIndex);
                            if (courseToDisplay)
                            {
                                DisplayCourseInfo(school.courses[courseInfoIndex]);
                            }
                            break;
                        case "9":
                            DisplayAllStudents(school);
                            WriteLine("Select a student to display info:");
                            var studentToDisplay = int.TryParse(ReadLine(), out var studentInfoIndex);
                            if (studentToDisplay)
                            {
                                DisplayStudentInfo(school.students[studentInfoIndex]);
                            }
                            break;
                        case "10":
                            DisplayAllTeachers(school);
                            WriteLine("Select a teacher to display info:");
                            var teacherToDisplay = int.TryParse(ReadLine(), out var teacherInfoIndex);
                            if (teacherToDisplay)
                            {
                                DisplayTeacherInSchool(school);
                            }
                            break;
                        case "11":
                            
                            WriteLine("Select an assignment to assign a grade:");
                            var assignmentToGrade = int.TryParse(ReadLine(), out var assignmentGradeIndex);
                            WriteLine("Enter the grade (A, B, C, D, F):");
                            var gradeInput = ReadLine().ToUpper();
                            if (assignmentToGrade && Enum.TryParse(gradeInput, out Assignment.Grade assignmentGrade))
                            {
                                AssignGradetoAssignment(school.assignments[assignmentGradeIndex], assignmentGrade);
                            }
                            break;
                        case "12":
                            WriteLine("Select a course to assign a grade:");
                            var courseToGrade = int.TryParse(ReadLine(), out var courseGradeIndex);
                            WriteLine("Enter the grade (A, B, C, D, F):");
                            var courseGradeInput = ReadLine().ToUpper();
                            if (courseToGrade && Enum.TryParse(courseGradeInput, out Course.Grade courseGrade))
                            {
                                AssignGradeToCourse(school.courses[courseGradeIndex], courseGrade);

                            }
                            break;

                        case "13":
                            DisplayAllStudents(school);
                            break;
                        case "14":
                            DisplayAllCourses(school);
                            break;
                        case "15":
                            displayassignments(school);
                            break;
                        case "16":
                            DisplayTeacherInSchool(school);
                            break;
                        
                    }
                    }
            }
            catch (Exception e)
            {

                WriteLine($"Exception encountered: {e.Message}");
            }
        }
        public static void AddStudent(School school, Student student)
        {
            school.students.Add(student);
        }

       public static void AddTeacher(School school, Teacher teacher)
        {
            school.teachers.Add(teacher);
        }


        public static void AddCourse(School school, Course course)
        {
            school.courses.Add(course);
        }

        public static void AddAssignment(School school, Assignment assignment)
        {
            school.assignments.Add(assignment);
        }

        public static void AddAssignmentToStudent(Student student, Assignment assignment)
        {
            student.Assignments.Add(assignment);
        }

        public static void AssignCourseToTeacher(Teacher teacher, Course course)
        {
            teacher.CoursesTaught.Add(course);
           
        }

        public static void AddStudentToCourse(Student student, Course course)
        {
            student.Courses.Add(course);
            course.CurrentStudents.Add(student);
        }

        public static void AddAssignmentToCourse(Course course, Assignment assignment)
        {
            course.assignments.Add(assignment);
        }

        public static void DisplayCourseInfo(Course course)
        {
            WriteLine($"Course: {course.CourseDescription} ({course.CourseName})");
            WriteLine($"Teacher: {course.CurrentTeacher.FirstName} {course.CurrentTeacher.LastName}");
            WriteLine("Students:");
            foreach (var student in course.CurrentStudents)
            {
                WriteLine($"- {student.FirstName} {student.LastName}");
            }
            WriteLine("Assignments:");
            foreach (var assignment in course.assignments)
            {
                WriteLine($"- {assignment.AssignmentName} (Due: {assignment.DueDate.ToShortDateString()})");
            }
        }

        public static void DisplayStudentInfo(Student student)
        {
            WriteLine($"Student: {student.FirstName} {student.LastName}");
            WriteLine($"Date of Birth: {student.DateOfBirth.ToShortDateString()}");
            WriteLine("Courses:");
            foreach (var course in student.Courses)
            {
                WriteLine($"- {course.CourseDescription} ({course.CourseName}) courseGrade: {course.CourseGrade}");
            }
            WriteLine("Assignments:");
            foreach (var assignment in student.Assignments)
            {
                WriteLine($"- {assignment.AssignmentName} (Due: {assignment.DueDate.ToShortDateString()})");
            }
        }

        public static void DisplayTeacherInSchool(School school)
        {
            WriteLine("Teachers:");
            foreach (var teacher in school.teachers)
            {
                WriteLine("--------------------------------------------------");
                WriteLine($"First Name: {teacher.FirstName}");
                WriteLine($"Last Name: {teacher.LastName}");    
                WriteLine($"Date of Employment: {teacher.DateOfEmployment.ToShortDateString()}");
                
           
                
                
            }
            WriteLine("Courses Taught:");
            foreach (var course in school.teachers.SelectMany(t => t.CoursesTaught))
            {
                WriteLine($"- {course.CourseDescription} ({course.CourseName})");
            }
        }

        public static void DisplayCouseGrade(Course course, Course.Grade grade)
        {
            course.CourseGrade = grade;
        }

        public static void DisplayAllStudents(School school)
        {
            WriteLine("Students:");
            foreach (var student in school.students)
            {
                WriteLine($"- {school.students.IndexOf(student)} {student.FirstName} {student.LastName} (DOB: {student.DateOfBirth.ToShortDateString()})");
            }
        }

        public static void DisplayAllCourses(School school)
        {
            WriteLine("Courses:");
            foreach (var course in school.courses)
            {
                WriteLine($"- {school.courses.IndexOf(course)}  ({course.CourseName}) {course.CourseDescription} ");
            }
        }

        public static void DisplayAllTeachers(School school)
        {
            WriteLine("Teachers: ");
            foreach(var teacher in school.teachers)
            {
                WriteLine($"- {school.teachers.IndexOf(teacher)} {teacher.FirstName} {teacher.LastName}");
            }
        }

        public static void DisplayAllAssignments(School school)
        {
            WriteLine("Assignments: ");
            foreach (var assignment in school.assignments)
            {
                WriteLine($"- {school.assignments.IndexOf(assignment)} {assignment.AssignmentName} {assignment.AssignmentDescription}");
            }
        }
        

        public static void AssignGradetoAssignment(Assignment assignment, Assignment.Grade grade)
        {
           assignment.AssignmentGrade = grade;
           WriteLine($"Grade assigned successfully: {assignment.AssignmentName}, Grade: {grade}");
        }

        public static void AssignGradeToCourse(Course course, Course.Grade grade)
        {
            course.CourseGrade = grade;
            WriteLine($"Grade assigned successfully: {course.CourseName}, Grade: {grade}");
        }

        

        public static void displayassignments(School school)
        {
            WriteLine("Assignments:");
            foreach (var assignment in school.assignments)
            {
                WriteLine($"- Assignment index: {school.assignments.IndexOf(assignment)} {assignment.AssignmentName} (Due: {assignment.DueDate.ToShortDateString()})");
            }
        }

        public static void DisplayCommands()
        {
            WriteLine("Available commands:");
            WriteLine("1. add student [firstName] [lastName] [dateOfBirth]");
            WriteLine("2. add teacher [firstName] [lastName] [dateOfEmployment]");
            WriteLine("3. add course [courseName] [courseDescription] [teacherFirstName] [teacherLastName]");
            WriteLine("4. add assignment [assignmentName] [dueDate] [courseName]");
            WriteLine("5. assign course to teacher [courseName] [teacherFirstName] [teacherLastName]");
            WriteLine("6. assign student to course [studentFirstName] [studentLastName] [courseName]");
            WriteLine("7. assign assignment to course [assignmentName] [courseName]");
            WriteLine("8. display course info [courseName]");
            WriteLine("9. display student info [studentFirstName] [studentLastName]");
            WriteLine("10. display teacher info [teacherFirstName] [teacherLastName]");
            WriteLine("11. assign grade to assignment [assignmentName] [grade]");
            WriteLine("12. assign grade to course [courseName] [grade]");
            WriteLine("13. display all students");
            WriteLine("14. display all courses");
            WriteLine("15. display all assignments");
            WriteLine("16. display all teachers");
           

        }
    }

    
}

using System;
using System.IO;

namespace Assignment_FileStream
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] courseTitle =
            {
                "programming_II", "math185", "English_171", "methodology", 
                "database", "Unix_Linux", "Javascript"
            };
            string fileName = "Courses";
            //Console.WriteLine("Enter the file name: ");
            //fileName = Console.ReadLine();

            #region Q1 Write a program to create a file Courses.txt.
            File.CreateText(fileName);
            FileStream courseFile;
            #endregion
            #region Q2&Q3
            //Q2: The program checks if the file exists or not. 
            //Q3: If it does not exist it will create it, if exist, it will override it.
            if (File.Exists(fileName))
            {
                Console.WriteLine("File [{0}] exists", fileName);
                courseFile = new FileStream
                    (fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            }
            else
            {
                Console.WriteLine("File does not exist. Created now");
                courseFile = new FileStream
                    (fileName, FileMode.CreateNew, FileAccess.ReadWrite);
            }

            #endregion
            #region Q4&Q5
            //Q4: The titles of the courses you are currently enrolled in this semester should be written to the file.
            //Q5: You should read the courses titles from another file called mycourses.txt

            string myCourseFile = "mycourse";
            uint counter=0;

            FileStream mycourseFile;
            mycourseFile = new FileStream
                (myCourseFile, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter mycourseWriter = new StreamWriter(mycourseFile);
            foreach (string name in courseTitle)
            {
                mycourseWriter.WriteLine(name);
                counter++;
            }
            mycourseWriter.Close();
            mycourseFile.Close();

            mycourseFile = new FileStream(myCourseFile, FileMode.Open);
            StreamReader mycourseReader = new StreamReader(mycourseFile);

            courseFile = new FileStream(fileName, FileMode.Open);
            StreamWriter courseWriter = new StreamWriter(courseFile);

            for (int i = 0; i < counter; i++)
            {
                courseWriter.WriteLine (mycourseReader.ReadLine());
            }
            mycourseReader.Close();
            mycourseFile.Close();
            courseWriter.Close();
            courseFile.Close();
            #endregion

            //Q6:Similar to courses.txt your program checks if the file exists 
            //or not. If it does not exist it will create it.
            if (File.Exists(myCourseFile))
            {
                Console.WriteLine("File [{0}] exists", myCourseFile);
            }
            else
            {
                Console.WriteLine("File [{0}] does not exist. Created now", myCourseFile);
                File.CreateText(myCourseFile);
            }



            #region delete part
            //StreamWriter courseWriter = new StreamWriter(courseFile);
            //foreach(string name in Enum.GetNames(typeof(courseTitle)))
            //{
            //    courseWriter.WriteLine(name);
            //}
            #endregion

            //courseFile = new FileStream("course", FileMode.Open);
            //StreamWriter courseWriter = new StreamWriter(courseFile);

        }
    }
}

﻿namespace DbFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            var dbContext = new PlutoDbContext();
            var courses = dbContext.Courses;
            foreach (Course course in courses)
            {
                System.Console.WriteLine(course.Description);
            }

            // Sproc
            var coursesAll = dbContext.GetCourses();

            foreach (var course in coursesAll)
            {
                System.Console.WriteLine(course.Description);
            }
        }
    }
}


// ORM: Object Relationship Mapper maps between our code Models called as "Conceptual Model" and the Database Model called as 
// Storage Models 
// ORM maps between these two.

/*
 * What is an edmx file:
 * An .edmx file is an XML file that defines a conceptual model , a storage model ,
 *  and the mapping between these models. An .edmx file also contains information that is used by the 
 * ADO.NET Entity Data Model Designer (Entity Designer) to render a model graphically
 * Add new table: SO in database you added a new table
 * IN order to get than Model ionto code. right click on an empty space in the edmx desinger file and click on Update from DB
 * there select the checkbox of stuff you want to add and then click on finish

    * In order to see how the Models are getting mapped. you can click on designer table and then click the "Table Mapping" option.
    * It wil show which Model prop is getting mapped to whicl collumn in DB
 */

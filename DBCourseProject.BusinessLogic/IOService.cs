using DBCourseProject.DataAccess;
using DBCourseProject.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCourseProject.BusinessLogic
{
    public class IOService
    {
        private readonly CourseProjectContext _context;

        public IOService(CourseProjectContext context)
        {
            _context = context;
        }

        public List<string[]> ReadDataFromFile(string filePath)
        {
            List<string[]> dataOutput = new List<string[]>();
            var separators = new string[] { ",\"", ",[" };
            using (var streamReader = new StreamReader(filePath, Encoding.GetEncoding(1251)))
            {
                bool skipHeaderLine = false;
                while(!streamReader.EndOfStream)
                {
                    var readLine = streamReader.ReadLine();
                    if (!skipHeaderLine)
                    {
                        skipHeaderLine = true;
                        continue;
                    }
                    var valuesLine = readLine.Split(separators, StringSplitOptions.None);
                    dataOutput.Add(valuesLine);
                }
            }
            return dataOutput;
        }

        public List<Department> GetAllDepartments()
        {
            return _context.Departments.ToList();
        }

    }
}

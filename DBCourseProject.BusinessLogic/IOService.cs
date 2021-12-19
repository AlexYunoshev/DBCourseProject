using DBCourseProject.DataAccess;
using DBCourseProject.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCourseProject.BusinessLogic
{
    public class IOService
    {
        public List<string[]> ReadDataFromFile(string filePath)
        {
            List<string[]> dataOutput = new List<string[]>();
            var separators = new string[] { ",\"", ",[" };
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
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

        public void SplitData(List<string[]> data,
            out List<Department> departmentsOut, 
            out List<List<FreePlate>> freePlatesOut,
            out List<List<PayablePlate>> payablePlatesOut)
        {
            departmentsOut = new List<Department>();
            freePlatesOut = new List<List<FreePlate>>();
            payablePlatesOut = new List<List<PayablePlate>>();

            for (int i = 0; i < data.Count; i++)
            {
                var departmentId = data[i][0];
                departmentId = departmentId.Replace("\"", "");

                var city = data[i][1];
                city = city.Replace("\"", "");

                var dep = data[i][2];
                dep = dep.Replace("\"", "");

                var free = data[i][4];
                free = free.Replace("]", "");
                var freeSplit = free.Split(',');

                var payable = data[i][5];
                payable = payable.Replace("]\"", "");
                var payableSplit = payable.Split(',');

                var department = new Department()
                {
                    DepartmentId = departmentId,
                    City = city,
                    DepartmentName = dep      
                };

                departmentsOut.Add(department);

                var freePlates = new List<FreePlate>();
                foreach (var number in freeSplit)
                {
                    var freePlate = new FreePlate() 
                    { 
                        PlateValue = number,
                        Department = department
                    };
                    freePlates.Add(freePlate);    
                }
                freePlatesOut.Add(freePlates);


                var paymentPlates = new List<PayablePlate>();
                foreach (var number in payableSplit)
                {
                    var payablePlate = new PayablePlate()
                    {
                        PlateValue = number,
                        Department = department
                    };
                    paymentPlates.Add(payablePlate);
                }
                payablePlatesOut.Add(paymentPlates);
            }            
        }
    }
}

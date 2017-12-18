﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ReportHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new
              ServiceHost(typeof(ReportService.ReportService)))
            {
                host.Open();
                System.Console.WriteLine("Host Started" + DateTime.Now);
                Console.ReadLine();
            }
        }
    }
}
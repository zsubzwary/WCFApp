﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AppWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select StudentService.svc or StudentService.svc.cs at the Solution Explorer and start debugging.
    public class StudentService : IStudentService
    {
        public String  DoWork( )
        {

            //System.Diagnostics.Debug.WriteLine(data);
            return "Hi";
        }

        public string register(student obj)
        {
            System.Diagnostics.Debug.WriteLine(obj);
            return "OPKAY !!";
        }
    }
}

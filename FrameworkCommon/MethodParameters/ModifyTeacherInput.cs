﻿using CoreEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkCommon.MethodParameters
{
    public class ModifyTeacherInput
    {
        public string NewName { get; set; }
        public string NewLastName { get; set; }
        public List<Subject> NewSubjects { get; set; }
        public string DocumentNumber { get; set; }
    }
}

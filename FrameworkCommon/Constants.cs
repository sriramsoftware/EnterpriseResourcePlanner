﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkCommon
{
    public static class Constants
    {
        public const string ERROR_UNEXPECTED = "Unexpected error.";
        public const string ERROR_ALL_FIELDS_REQUIRED = "You must fill all fields.";
        public const string ERROR_DOCUMENTNUMBER_REQUIRED = "Document number required.";
        public const string ERROR_NOTEACHERFOUND = "No teacher found to delete.";

        public const string SUCCESS_TEACHERREGISTRATION = "Teacher registered with success.";
        public const string SUCCESS_TEACHER_DELETED = "Teacher deleted with success.";
        public const string SUCCESS_TEACHER_MODIFICATION = "Teacher modification succcess.";

        public const string ERROR_STUDENT_INFO_REQUIRED = "Student information required.";
        public const string ERROR_FEEAMOUNT = "Fee amount must be greater than 0.";
        public const string ERROR_SUBJECTS_REQUIRED = "At least one subject required.";
        public const string ERROR_VALIDCOORDENATES_REQUIRED = "Valid coordenates are required.";
        public const string SUCCESS_STUDENT_REGISTRATION = "Student registered with success.";
        public const string SUCCESS_STUDENT_MODIFICATION = "Student succesfully modified.";
        public const string ERROR_INVALID_STUDENTNUMBER = "Invalid student number.";
        public const string ERROR_NOSTUDENTFOUND = "Student not found.";

        public const string SUCCESS_ACTIVITY_REGISTRATION = "Activity was succesfully registered.";
        public const string ACTIVITY_NAME_EMPTY = "Activity's name should be not empty.";
        public const string ACTIVITY_COST_NEGATIVE = "Activity's cost should be greater or equal than 0.";
        public const string ACTIVITY_SUCCESSFULLY_DELETED = "The activity was successfully deleted.";
        public const string ACTIVITY_SUCCESSFULLY_MODIFIED = "The activity was successfully modified.";
        public const string NOFEES_TOBEPAID = "There no fees to be paid.";
        public const string ERROR_MUST_PAY_OLDESTS_FEES_FIRST = "Oldest fees must be paid first.";
        public const string FEES_WHERE_SUCCESSFULLY_PAID = "Fees where successfuly paid.";
        public const string SUCCESS_ACTIVITY_REGISTRATION_AND_PAYMENT = "Activities where successsfuly paid and assign to the student.";
        public const string NO_AVAILABLE_ACTIVITIES = "There are no available activities to assign for this student.";
        public const string SELECT_ONE_ACTIVITY = "You must select at least one activity.";
    }
}

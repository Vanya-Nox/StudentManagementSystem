using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG272_Project_Milestone2.BusinessLogic
{
    internal class Students
    {
        public int StudentNumber { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int ModuleCodes { get; set; }

        public Students(int studentNumber, string studentName, string studentSurname,string dateOfBirth, string gender, string phone, string address, int moduleCodes)
        {
            StudentNumber = studentNumber;
            StudentName = studentName;
            StudentSurname = studentSurname;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Phone = phone;
            Address = address;
            ModuleCodes = moduleCodes;
        }

        public Students()
        {
        }
        
        public override string ToString()
        {
            return $"StudentNo: {StudentNumber} Surname: {StudentName} DOB: {DateOfBirth} Gender: {Gender} Phone: {Phone} Address: {Address} ModuleCodes: {ModuleCodes}";
        }
    }
}

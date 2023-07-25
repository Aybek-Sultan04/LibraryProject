using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Users
{
    internal class UserModel
    {
        public string? UserName { get; set; }
        public string? UserPassword { get; set; }
        public byte Age { get; set; }
        public string? UserEmail { get; set; }
        public string? Number { get; set; }
        public DateOnly DateRegistration { get; set; }
        public DateOnly DateOfBirthd { get; set; }
    }
}

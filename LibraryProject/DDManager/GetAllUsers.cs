using LibraryProject.Users;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace LibraryProject.DDManager
{
    internal class GetAllUsers
    {
        public static List<UserModel> GetUser()
        {
            using (StreamReader reader = new StreamReader("User.json", true))
            {
                try
                {
                    var users = JsonConvert.DeserializeObject<List<UserModel>>(reader.ReadToEnd());
                    return users;
                }
                catch (Exception ex)
                {

                }
            }
            return null;
        }
    }
}

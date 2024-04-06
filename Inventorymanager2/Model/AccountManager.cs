using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Inventorymanager2.Model
{
    public class AccountManager
    {
        public static string ConvertToSha256(string text)
        {
            // Check if the text is null
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(text));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static void AddAcount(String DisplayName, String Username, String Password, int roleid)
        {


            var newUser = new User();

            newUser.DisplayName = DisplayName;
            newUser.UserName = Username;
            newUser.Password = ConvertToSha256(Password);
            newUser.IdRole = roleid + 1;
            newUser.UserRole = (UserRole)DataProvider.Ins.DB.UserRoles.FirstOrDefault(p => p.Id == roleid);

            DataProvider.Ins.DB.Users.Add(newUser);
            DataProvider.Ins.DB.SaveChanges();



        }

        public static void UpdateGridView(DataGridView grid)
        {

            grid.DataSource = null;
            var context = DataProvider.Ins.DB.Users.ToList();
            foreach (var user in context)
            {
                int rowIndex = grid.Rows.Add();
                grid.Rows[rowIndex].Cells["Username"].Value = user.UserName; // Replace "UsernameColumn" with the actual column name
                grid.Rows[rowIndex].Cells["DisplayName"].Value = user.DisplayName; // Replace "FullNameColumn" with the actual column name
                grid.Rows[rowIndex].Cells["Role"].Value = user.UserRole != null ? user.UserRole.DisplayName : "";
            }

        }
    }
}

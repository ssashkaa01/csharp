using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;

namespace _19._10._2019
{
    [Serializable]
    class User
    {
        [Required(ErrorMessage = "Id not defined")]
        [Range(1000, 9999)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Login is required")]
        [RegularExpression(@"^[a-z0-9]{2,20}$", ErrorMessage = "Login a-z0-9 min length - 2, max - 20")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^[A-Za-z0-9]{8,}$", ErrorMessage = "Password A-Za-z0-9 min length - 8")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Not Confirm Password")]
        public string ConfirmPassword { get; set; }

        [EmailAddress(ErrorMessage = "Bad email")]
        public string Email { get; set; }

        [RegularExpression(@"^\d{4}\s\d{4}\s\d{4}\s\d{4}$", ErrorMessage = "Bad card")]
        public string CreditCard { get; set; }

        [RegularExpression(@"^+38-0\d{2}-\d{3}-\d{2}-\d{2}$", ErrorMessage = "Bad phone +38-0xx-xxx-xx-xx")]
        public string Phone { get; set; }



        public void SetInfo()
        {
            bool isValid = false;
            do
            {
                Console.WriteLine("Please enter id*");
                Id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter login*");
                Login = Console.ReadLine();

                Console.WriteLine("Please enter password*");
                Password = Console.ReadLine();

                Console.WriteLine("Please confirm password*");
                ConfirmPassword = Console.ReadLine();

                Console.WriteLine("Please enter Email*");
                Email = Console.ReadLine();

                Console.WriteLine("Please enter credit card");
                CreditCard = Console.ReadLine();

                Console.WriteLine("Please enter phone");
                Phone = Console.ReadLine();

                var results = new List<ValidationResult>();
                var context = new ValidationContext(this);
                isValid = Validator.TryValidateObject(this, context, results, true);

                if (!isValid)
                {
                    foreach (ValidationResult error in results)
                    {
                        Console.WriteLine(error.MemberNames.FirstOrDefault() + ": " + error.ErrorMessage);
                    }
                }
            }
            while (!isValid);
        }
    }

    class Program
    {

        public static void Menu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Add user");
            Console.WriteLine("2 - Serialize");
            Console.WriteLine("3 - Deserialize");
            Console.WriteLine("4 - Exit");
        }

        static void Main(string[] args)
        {
            Dictionary<int, User> users = new Dictionary<int, User>();
            BinaryFormatter formatter = new BinaryFormatter();

            bool exit = false;
            int action;

            while(!exit)
            {
                Menu();

                action = Convert.ToInt32(Console.ReadLine());

                switch(action)
                {
                    case 1:
                       
                        User newuser = new User();
                        newuser.SetInfo();
                        users.Add(newuser.Id, newuser);

                        break;
                    case 2:

                        using (FileStream fs = new FileStream("users.bin", FileMode.OpenOrCreate))
                        {
                            formatter.Serialize(fs, users);

                            Console.WriteLine("Serialize OK");
                        }
                        break;
                    case 3:

                        FileStream fs2 = new FileStream("users.bin", FileMode.Open);
                        try
                        {
                          
                            // Deserialize the hashtable from the file and 
                            // assign the reference to the local variable.
                            users = (Dictionary<int, User>)formatter.Deserialize(fs2);
                        }
                        catch (SerializationException e)
                        {
                            Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                            throw;
                        }
                        finally
                        {
                            fs2.Close();
                        }

                        break;
                    case 4:

                        exit = true;

                        break;
                }
            }
        }
    }
}
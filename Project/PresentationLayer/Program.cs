using BAL;
using BusninessObject.TravelDeskModel;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Transactions;

namespace PresentationLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int ch;

            Console.WriteLine("Enter the choice ");
            Console.WriteLine("1 . Add user");
            Console.WriteLine("2 . Add Request");
            ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:

                    program.user1();
                    break;
                case 2:
                    program.Request1();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

        }
        public void Request1()
        {
            int ch;

            Console.WriteLine("Enter the choice");
            Console.Write("Enter Starting Venue:::");
            string starting = Console.ReadLine();
            Console.Write("Enter the Destination :::");
            string destinaion = Console.ReadLine();
            Console.Write("Enter the Travel Reason :::");
            string reason = Console.ReadLine();
            Console.WriteLine("Enter the user name");
            string username = Console.ReadLine();
            Console.WriteLine("Taking Current DataTime :::");
            DateTime datatime = DateTime.Now;


            Bal bal = new Bal();

            User user = bal.GetUser(username);

            Request request = new Request()
            {
                Starting = starting,
                Destination = destinaion,
                TravalDate = datatime,
                Reason  = reason,
                User = user

            };

            int resonse = bal.AddReq(request);
            if(resonse == 0)
            {
                Console.WriteLine("Record Added !!!");

            }
            else
            {
                Console.WriteLine("some error !!");
            }

        }
        public void user1()
        {
            int ch;


            Console.WriteLine("Enter choice ");
            Console.WriteLine("1 . Adduser");
            Console.WriteLine("2 . Edituser ");
            Console.WriteLine("3 . Deleteuser");
            ch = int.Parse(Console.ReadLine()); 

            switch (ch)
            {

                case 1:

                    Console.WriteLine("Enter First Name ::");
                    string Fname = Console.ReadLine();
                    Console.WriteLine("Enter last Name ::");
                    string Lname = Console.ReadLine();
                    Console.WriteLine("Enter the DateCreated :::");
                    DateTime datecreated = DateTime.Now;
                    Console.WriteLine("Enter the DateUpdated :::");
                    DateTime dateupdated = DateTime.Now;
                    Console.WriteLine(" ISActive ::::");
                    bool isActive = true;
                    Console.WriteLine("Enter the RoleName ::");
                    string rolename = Console.ReadLine();   

                    Bal bal = new Bal();
                    Role role = bal.GetRole(rolename);


                    User user = new User()
                    {
                        firstname = Fname,
                        lastname = Lname,
                        DateCreated = datecreated,
                        DateUpdated = dateupdated,
                        isactive = isActive,
                        role = role

                    };

                    int response = bal.adduser(user);
                    Console.WriteLine(response);
                    if(response == 0)
                    {
                        Console.WriteLine("Recorded inserted !!");

                    }


                    




                    break;

            case 2:

              break; 
                
            case 3:

                    break;
                default: Console.WriteLine("Invalid input");
                    break;
            }
        }
        
        public void Role1()
        { 
        int ch;

            Console.WriteLine("-- For Role --");
            Console.Write("Enter the Name :::");
            string name = Console.ReadLine();   
            Console.WriteLine("Enter the DateCreated :::");
            DateTime datecreated = DateTime.Now;
            Console.WriteLine("Enter the DateUpdated :::");
            DateTime dateupdated = DateTime.Now;    
            Console.WriteLine(" ISActive ::::");
            bool isActive = true;

            Role role = new Role()
            {
                name = name,
                DateCreated = datecreated,
                DateUpdated = dateupdated,
                isactive = isActive
            };
            Bal bal = new Bal();
            int responese = bal.addrole(role);

            if(responese == 0)
            {
                Console.WriteLine("Record Added !!");
            }
            else
            {
                Console.WriteLine("Failed to add the Record !!");
            }


        }
    }
}
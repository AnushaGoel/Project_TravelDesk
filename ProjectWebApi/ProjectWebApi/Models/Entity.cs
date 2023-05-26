using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ProjectWebApi.Models
{
    public class Department
    {
        public int Id { get; set; } 

        public string DepartmentName { get; set; }
    }
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; } 
        public Department Department { get; set; }
        public string Email { get; set; }

        public enum Role
        {
            Admin,
            Employee,
            Manager,
            TravlAdmin
        }

        public Role role { get; set; }

    }

    public class Comment
    {

        public int CommentId { get; set; }
        public  User User { get; set; }
        //public Request Request { get; set; }

        public StatusCode Status { get; set; }

        public string comment { get; set; }

        public DateTime? DatePosted { get; set; }
    }

    public class Request
    {

        public int RequestId { get; set; }
        public string UserName { get; set; }
        public string ProjectName { get; set; }
        public string DepartmentName { get; set; }
        public string ReasonForTraveling { get; set; }
        public string TypeOfBooking { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;


        public Comment Comment { get; set; }

        public  User User { get; set; }



    }


    public class Document
    {

        public int DocumentId { get; set; }

        //public User User { get; set; }

        //public User User { set; get; }
        public Request Request { get; set; }

        public byte[] Aadhar { get; set; }

        public byte[] Visa { get; set; }

        public byte[] Passport { get; set; }

    }

    public class HotelBooking
    {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int DaysOfStay { get; set; }
        public bool MealRequired { get; set; }

        public Meal MealType { get; set; }

        public MealPreference MealPreferences { get; set; }

        public Request Request { get; set; }


        public enum MealPreference
        {
            Veg,
            Non_Veg


        }

        public enum Meal
        {
            Lunch,
            Dinner
        }
    }


    public class City
    {
        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; }
    }


    public class FlightBooking
    {
        [Key]
        public int FlightId { get; set; }

        public City City { get; set; }

        [ForeignKey("Request")]
        public int RequestId { get; set; }

        public Document Documents { get; set; }


    }


    public enum StatusCode
    {
        Approved,
        pending,
        Rejected

    }
}

using BusninessObject.TravelDeskModel;
using DAL.Context;

namespace DAL
{
    public class Dal
    {

        TravelDbContext db = new TravelDbContext(); 



        public int addRoles(Role role)
        {
           
                db.roles.Add(role);
                saveRecords();
           
            return 0;
        }
        public int addUser(User user)
        {
            db.users.Add(user);
            saveRecords();
            return 0;
        }

        void saveRecords()
        {
            db.SaveChanges();
        }

        public Role getRole(string rolename)
        {

            return (db.roles.FirstOrDefault(x => x.name  ==   rolename));  
        }

        public User GetUser(string username)
        {
            return (db.users.FirstOrDefault(x => x.firstname == username));
        }

        public int AddReq(Request req)
        {
            db.requests.Add(req);
            db.SaveChanges ();
            return 0;
        }
    }
}
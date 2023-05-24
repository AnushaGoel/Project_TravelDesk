using BusninessObject.TravelDeskModel;
using DAL;
using System.Reflection.Metadata;

namespace BAL
{
    public class Bal
    {
        Dal dal = new Dal();

        public int addrole(Role role)
        {
            dal.addRoles(role); 
            return 0;
        }
        public int adduser(User user)
        {
            dal.addUser(user);
            return 0;
        }

        public Role GetRole(string rolename) 
        {
            return dal.getRole(rolename);
        }

        public User GetUser(string username)
        {
            return dal.GetUser(username);
        }

        public int AddReq(Request req)
        {
            dal.AddReq(req);
            return 0;
        }

    }
}
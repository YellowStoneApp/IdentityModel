
namespace IdentityModel
{

    // Add profile data for application users by adding properties to the ShoutUser class
    public class ProtectedShoutUser
    {
        public string UserName { get; set; }
        public string Id { get; set; }
        public string ProfileUrl { get; set; } = "https://images.theconversation.com/files/350865/original/file-20200803-24-50u91u.jpg?ixlib=rb-1.1.0&q=45&auto=format&w=1200&h=675.0&fit=crop";

        public ProtectedShoutUser(ShoutUser user) 
        {
            UserName = user.UserName;
            Id = user.Id;
        }

        public ProtectedShoutUser() 
        { }
    }
}

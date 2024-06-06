using RestMan.Context.Models;

namespace RestMan.UI.StaticClasses
{
    public static class CurrentUser
    {
        public static User User { get; set; }
        public static bool IsWaiter()
        {
            return User.RoleId == 1;
        }
        public static bool IsCashier()
        {
            return User.RoleId == 2;
        }
        public static bool IsManager()
        {
            return User.RoleId == 3;
        }
        public static bool IsAdmin()
        {
            return User.RoleId == 4;
        }

    }
}

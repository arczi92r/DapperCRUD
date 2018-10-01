namespace Constans.DBRepo
{
    public static class RoleQuery
    {
        public const string GetRoleByID = @"SELECT * FROM ROLE where id=@Id";
    }
}

namespace DanaBet.DBModel
{
    public class Users
    {
        public int Id { get; set; }
        public required string Firstname { get; set; }
        public required string Lastname { get; set; }
        public required string Mobile { get; set; }
        public bool IsActive { get; set; }
    }
}

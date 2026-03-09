namespace azure_app_phani.Data
{
    public class Person
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; } 
    }
}
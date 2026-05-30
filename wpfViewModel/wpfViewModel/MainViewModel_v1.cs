namespace wpfViewModel
{
    internal class MainViewModel_v1
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? Age { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}
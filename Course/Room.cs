namespace Course
{
    internal class Room
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return $"{Id}: {Name}, {Email}";
        }
    }
}

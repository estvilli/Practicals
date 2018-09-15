namespace Domain
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            
        }
        
        public Person(string firstName, string lastName, string nickname)
        {
            FirstName = firstName;
            LastName = lastName;
            Nickname = nickname;
        }

        public string toString()
        {
            if (string.IsNullOrEmpty(Nickname))
            {
                return FirstName + " " + LastName;
            }
            return FirstName + " \"" + Nickname + "\" " + LastName;
        }
    }
}
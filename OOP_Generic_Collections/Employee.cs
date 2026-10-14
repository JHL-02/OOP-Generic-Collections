namespace OOP_Generic_Collections
{
    internal class Employee
    {
        #region PROPERTIES
        public int ID { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public double Salary { get; set; }
        #endregion

        #region CONSTRUCT
        public Employee(int id, string name, Gender gender, double salary)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return $"ID: {ID}, Name {Name}, Gender {Gender}, Salary: {Salary}";
        }
        #endregion
    }
    internal enum Gender { Male, Female} 
}

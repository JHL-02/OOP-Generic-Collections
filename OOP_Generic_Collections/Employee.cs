namespace OOP_Generic_Collections
{
    internal class Employee
    {
        #region PROPERTIES
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
        #endregion

        #region CONSTRUCT
        public Employee(int id, string name, string gender, double salary)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }
        #endregion

        #region METHODS

        #endregion
    }
}

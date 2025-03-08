namespace University.Service.Exceptions
{
    public class AmbigousNameException : Exception
    {
        public AmbigousNameException() : base("Data with same name already exists.")
        {
        }
    }
}

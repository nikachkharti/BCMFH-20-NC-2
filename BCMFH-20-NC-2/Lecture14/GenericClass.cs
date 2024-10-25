namespace Lecture14
{
    interface IInterface<T>
    {
    }

    public class GenericClass<T> /*where T : class*/
    {
        public T Id { get; set; }

        public GenericClass(T id)
        {
            Id = id;
        }
    }
}

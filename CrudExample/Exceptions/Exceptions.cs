namespace CrudExample.Exceptions
{
    public class Exceptions : IExceptions
    {
        public T Null<T>(T Data)
        {
            try
            {
                return Data;
            }
            catch (Exception ex)
            { 
                throw null;
            }
        }

    }
}

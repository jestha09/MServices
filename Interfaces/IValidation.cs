namespace Interfaces
{
    public interface IValidation<in T>
    {
        void Validate(T input);
    }
}

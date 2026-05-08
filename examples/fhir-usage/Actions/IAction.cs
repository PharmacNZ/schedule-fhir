public interface IAction<T>
{
		Task Execute(T parameter);
}
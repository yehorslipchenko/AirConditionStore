namespace AirConditionStore.DataAccess.Contracts
{
    public interface IUnitOfWorkFactory
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
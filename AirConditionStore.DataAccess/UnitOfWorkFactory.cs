using AirConditionStore.DataAccess.Contracts;

namespace AirConditionStore.DataAccess
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        private AirConditionStoreContext context;
        private IUnitOfWork currentUnitOfWork;

        public UnitOfWorkFactory()
        {
            SetNewContext();
            SetNewUnitOfWork();
        }
        
        public IUnitOfWork UnitOfWork
        {
            get
            {
                if (currentUnitOfWork.IsDisposed)
                {
                    SetNewContext();
                    SetNewUnitOfWork();
                }

                return currentUnitOfWork;
            }
        }
        
        private void SetNewContext()
        {
            context = new AirConditionStoreContext();
        }
        
        private void SetNewUnitOfWork()
        {
            currentUnitOfWork = new UnitOfWork(context);
        }
        
    }
}
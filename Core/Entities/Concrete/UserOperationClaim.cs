namespace Core.Entities.Concrete
{
    public class UserOperationClaim : IEntity
    {
        public int UserClaimID { get; set; }
        public int Id { get; set; }
        public int OperationClaimID { get; set; }

    }
}

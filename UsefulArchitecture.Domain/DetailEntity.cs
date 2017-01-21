namespace UsefulArchitecture.Domain
{
    public abstract class DetailEntity<TParent> : BaseEntity
        where TParent: BaseEntity
    {
         public virtual TParent Parent { get; set; }
    }
}
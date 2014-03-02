
namespace Humour.Model
{
    /// <summary>
    /// This interface is used to mark the owner of an object.
    /// Useful for helping when there are orphaned Votes if a Story is deleted
    /// </summary>
    public interface IHasOwner
    {
        /// <summary>
        /// The Story instance this object belongs to.
        /// </summary>
        Story Owner { get; set; }
    }
}

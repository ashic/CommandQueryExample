using System.Runtime.Serialization;

namespace SimpleImplementationModel.ViewModels
{
    [DataContract]
    public class PeopleListItem
    {
        [DataMember]
        public int Id { get; private set; }
        [DataMember]
        public string FullName { get; private set; }

        public PeopleListItem(int id, string fullName)
        {
            Id = id;
            FullName = fullName;
        }

        protected bool Equals(PeopleListItem other)
        {
            return Id == other.Id && string.Equals(FullName, other.FullName);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((PeopleListItem) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Id*397) ^ (FullName != null ? FullName.GetHashCode() : 0);
            }
        }

        public static bool operator ==(PeopleListItem left, PeopleListItem right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PeopleListItem left, PeopleListItem right)
        {
            return !Equals(left, right);
        }

        public override string ToString()
        {
            return string.Format("[{0}] {1}", Id, FullName);
        }
    }
}
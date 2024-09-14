using System;

namespace Type_conversion_implict__explict_
{
    class UserId
    {
        public UserId(Guid value)
        {
            Value = value;
        }
        public Guid Value { get; }
        public static implicit operator UserId(Guid guid)
        {
            return new UserId(guid);
        }
        /*public static implicit operator Guid(UserId userId)
        {
            return userId.Value;
        }*/
        /*public static explicit operator Guid(UserId userId)
        {
            return userId.Value;
        }*/
    }
}
namespace BlazorApp2.Models
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public readonly struct MyTypeWithCast : IEquatable<MyTypeWithCast>
    {
        private readonly Guid value;

        private MyTypeWithCast(Guid value)
        {
            this.value = value;
        }

        public static MyTypeWithCast Create()
        {
            return new MyTypeWithCast(Guid.NewGuid());
        }

        public override bool Equals(object obj)
        {
            return obj is MyTypeWithCast id && Equals(id);
        }

        public bool Equals(MyTypeWithCast other)
        {
            return this.value.Equals(other.value);
        }

        public override int GetHashCode()
        {
            return -1584136870 + this.value.GetHashCode();
        }

        public override string ToString()
        {
            return this.value.ToString("D");
        }

        // Comment the operator to make the app work again
        //public static implicit operator string(MyTypeWithCast id) => id == default ? String.Empty : id.ToString();

        public static bool operator ==(MyTypeWithCast left, MyTypeWithCast right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(MyTypeWithCast left, MyTypeWithCast right)
        {
            return !(left == right);
        }
    }
}

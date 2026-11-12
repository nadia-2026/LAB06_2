namespace LAB06_2
{
    public class CustomString
    {
        private string value;

        public string Value
        {
            get { return value; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Строка не может быть null");
                this.value = value;
            }
        }

        private int CustomStringLength()
        {
            int count = 0;
            foreach (char c in value)
            {
                count++;
            }
            return count;
        }

        public CustomString(string str)
        {
            Value = str;
        }

        public static CustomString operator +(CustomString a, CustomString b)
        {
            return new CustomString(a.Value + b.Value);
        }

        public static CustomString operator *(CustomString a, int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += a.Value;
            }
            return new CustomString(result);
        }

        public override string ToString()
        {
            return $"CustomString: {Value}, {CustomStringLength()}";
        }

        public static bool operator ==(CustomString a, CustomString b)
        {
            return a.CustomStringLength() == b.CustomStringLength();
        }

        public static bool operator !=(CustomString a, CustomString b)
        {
            return !(a == b);
        }
    }
}
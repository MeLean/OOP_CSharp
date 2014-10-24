namespace _02.StringDisperser
{
    using System;
    using System.Collections;

    public class StringDisperser : ICloneable, IComparable, IEnumerable
    {
        private string[] strings;

        public StringDisperser(params string[] strings)
        {
            this.Strings = strings;
        }

        public string[] Strings
        {
            get { return this.strings; }
            set { this.strings = value; }
        }

        public static bool operator ==(StringDisperser stringOne, StringDisperser stringTwo)
        {
            return stringOne.Equals(stringTwo);
        }

        public static bool operator !=(StringDisperser stringOne, StringDisperser stringTwo)
        {
            return !stringOne.Equals(stringTwo);
        }

        public override string ToString()
        {
            return string.Join(string.Empty, this.Strings);
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj as StringDisperser != null)
            {
                return this.ToString() == (obj as StringDisperser).ToString();
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            var newHashCode = 0;
            foreach (var str in this.Strings)
            {
                newHashCode ^= str.GetHashCode();
            }

            return newHashCode;
        }

        public object Clone()
        {
            var cloning = new StringDisperser(this.Strings.Clone() as string[]);

            return cloning;
        }

        public int CompareTo(object obj)
        {
            return this.ToString().CompareTo(obj.ToString());
        }

        public IEnumerator GetEnumerator()
        {
            var stringDispenserToString = this.ToString();
            for (var i = 0; i < stringDispenserToString.Length; i++)
            {
                yield return stringDispenserToString[i];
            }
        }
    }
}
namespace _03.Student
{
    using System;

    public class PropertyChangedEventArgs : EventArgs
    {
        private string name;
        private string oldValue;
        private string newValue;

        public PropertyChangedEventArgs(string propertyName, dynamic oldValue, dynamic newValue)
        {
            this.Name = propertyName;
            this.OldValue = oldValue.ToString();
            this.NewValue = newValue.ToString();
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string OldValue
        {
            get { return this.oldValue; }
            set { this.oldValue = value; }
        }

        public string NewValue
        {
            get { return this.newValue; }
            set { this.newValue = value; }
        }
    }
}

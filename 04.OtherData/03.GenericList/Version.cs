namespace _03.GenericList
{
    using System;

    [AttributeUsage(AttributeTargets.Class |
        AttributeTargets.Struct |
        AttributeTargets.Enum |
        AttributeTargets.Interface |
        AttributeTargets.Method)]

    public class Version : System.Attribute
    {
        private int core;
        private int versionNum;

        public Version(int core, int versionNum)
        {
            this.core = core;
            this.versionNum = versionNum;
        }

        public override string ToString()
        {
            return string.Format("Version: {0}.{1}", core, versionNum);
        }
    }
}

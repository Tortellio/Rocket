using System;
using Rocket.API;

namespace Rocket.Core.Commands
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class RocketCommandPermissionAttribute : Attribute
    {
        public RocketCommandPermissionAttribute(string Name)
        {
            this.Name = Name;
        }
        public string Name { get; set; }
    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class RocketCommandAliasAttribute : Attribute
    {
        public RocketCommandAliasAttribute(string Name)
        {
            this.Name = Name;
        }
        public string Name { get; set; }
    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class RocketCommandAttribute : Attribute
    {
        public RocketCommandAttribute(string Name,string Help,string Syntax = "", AllowedCaller AllowedCaller = AllowedCaller.Both)
        {
            this.Name = Name;
            this.Help = Help;
            this.Syntax = Syntax;
            this.AllowedCaller = AllowedCaller;
        }

        public string Name { get; }
        public string Help { get; }
        public string Syntax { get; }
        public AllowedCaller AllowedCaller { get; }
    }
}

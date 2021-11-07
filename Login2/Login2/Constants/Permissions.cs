using System.Collections.Generic;

namespace Login2.Constants
{
public static class Permissions
{
    public static List<string> GeneratePermissionsForModule(string module)
    {
        return new List<string>()
        {
            $"Permissions.{module}.Create",
            $"Permissions.{module}.View",
            $"Permissions.{module}.Edit",
            $"Permissions.{module}.Delete",
        };
    }

    public static class Students
    {
        public const string View = "Permissions.Students.View";
        public const string Create = "Permissions.Students.Create";
        public const string Edit = "Permissions.Students.Edit";
        public const string Delete = "Permissions.Students.Delete";
    }
}
}
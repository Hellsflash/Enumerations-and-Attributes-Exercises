using System;

[AttributeUsage(AttributeTargets.Enum, AllowMultiple = true)]
public class TypeAttribute : Attribute
{
    public TypeAttribute(string type, string category, string description)
    {
        Type = type;
        Category = category;
        Description = description;
    }

    public string Type { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }
}
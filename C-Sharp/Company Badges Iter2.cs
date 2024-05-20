using System;
static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string dept = (department??"owner").ToUpper();
		return id==null ? $"{name} - {dept}": $"[{id}] - {name} - {dept}";
    }
}

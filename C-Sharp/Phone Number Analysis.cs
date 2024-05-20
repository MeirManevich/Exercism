using System;
public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        return (phoneNumber.StartsWith("212"), phoneNumber.IndexOf("555",4,3)==4, phoneNumber.Substring(8));
    }
    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.Item2;
    }
}

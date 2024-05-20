using System;

public static class Bob
{
    public static string Response(string statement)
    {
            bool allcaps=true;
			Console.WriteLine(allcaps);
			bool silence=true;
			bool allnumbers=false;
			bool allletters=false;
			foreach(char a in statement)
			{
				if(!Char.IsUpper(a) && char.IsAsciiLetter(a))
				{
					allcaps=false;
					break;
				}
			}
			Console.WriteLine(allcaps);
			foreach(char b in statement)
			{
				if(!Char.IsWhiteSpace(b))
				{
					silence=false;
					break;
				}
			}
			foreach(char c in statement)
			{
				if (char.IsNumber(c))
					{
						allnumbers=true;
					}
			}
			foreach(char d in statement)
			{
				if (char.IsLetter(d))
					{
						allletters=true;
					}
			}
			if (statement.Trim().EndsWith("?") && allcaps==false)
				{
					return "Sure.";
				}
			else if (allcaps==true && !statement.Trim().EndsWith("?"))
				{
					return "Whoa, chill out!";
				}

			else if (statement.Trim().EndsWith("?") && allcaps==true)
				{
					return "Calm down, I know what I'm doing!";
				}
			else if (string.IsNullOrWhiteSpace(statement)||silence==true)
				{
					return "Fine. Be that way!";
				}
			else
				{
					return "Whatever.";
				}
    }
}

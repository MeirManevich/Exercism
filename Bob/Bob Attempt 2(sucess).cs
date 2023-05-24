using System;

public static class Bob
{
    public static string Response(string statement)
    {
		bool containsletters=false;
		bool allcaps=true;
		bool silence=true;
        
		//contains letters
		foreach(char d in statement)
		{
			if (char.IsAsciiLetter(d))
			{
				containsletters=true;
			}
		}
		//allcaps
		foreach(char a in statement)
		{
			if(containsletters==true)
                {
                    if(char.IsAsciiLetter(a) && !Char.IsUpper(a))
                    {
                        allcaps=false;
                        break;
                    }
                }
			else
			{
				allcaps = false;
			}
		}
		//silence
		foreach(char b in statement)
		{
			if(!Char.IsWhiteSpace(b))
			{
				silence=false;
				break;
			}
		}

        
			if (statement.Trim().EndsWith("?") && allcaps==false)
				{
					return "Sure.";
				}
			else if (containsletters==true && allcaps==true && !statement.Trim().EndsWith("?"))
				{
					return "Whoa, chill out!";
				}

			else if (containsletters==true && statement.Trim().EndsWith("?") && allcaps==true)
				{
					return "Calm down, I know what I'm doing!";
				}
			else if (silence==true)
				{
					return "Fine. Be that way!";
				}
			else
				{
					return "Whatever.";
				}
    }
}
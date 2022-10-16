using System.Text;

namespace ND.Recruitment.Domain;

public class Diamond
{
    private readonly int _length;
    private readonly char _character;

    public Diamond(char character)
    {
        if (character is < 'A' or > 'Z')
        {
            throw new ArgumentOutOfRangeException(null, "Character is out of range. Please use a letter from 'A' to 'Z'");
        }
        
        _character = character;
        _length = character - 65;
    }

    public override string ToString()
    {
        return Create(_character); 
    }

    private string Create(char character)
    {
        var upperBuilder = new StringBuilder();

        for (var i = 0; i <= _length; i++)
        {
            var line = new StringBuilder(new string(' ', _length + 1))
            {
                [i] = (char)(character - _length + i)
            }.ToString();
            
            upperBuilder.Append($"{new string(line[1..].Reverse().ToArray())}{line}{Environment.NewLine}");
        }

        var upper = upperBuilder.ToString().TrimEnd();

        return $"{upper}{new string(upper.Reverse().ToArray())[(_length * 2 + 1)..]}";
    }
}
// Given a real number between 0 and 1 (e.g., 0.72) that is passed in as a double, print
// the binary representation. If the number cannot be represented accurately in binary with at most 32
// characters, print "ERROR:'

decimal value = decimal.Parse(Console.ReadLine()!);
decimal resultOperation = value;
string result = resultOperation == 1 || resultOperation == 0 ? $"{resultOperation}" : "0.";
int count = 0;
HashSet<decimal> valuesAlreadMultiplied = new HashSet<decimal>();

while (resultOperation != 1 && resultOperation != 0)
{
    if (count > 32)
    {
        result = "";
        break;
    }

    resultOperation *= 2;
    result += (char)('0' | (int)resultOperation);
    count++;

    if (resultOperation > 1)
        resultOperation -= 1;

    if (valuesAlreadMultiplied.Contains(resultOperation))
        break;

    valuesAlreadMultiplied.Add(resultOperation);
}

if (result == "") Console.WriteLine("ERROR");
else Console.WriteLine(result);
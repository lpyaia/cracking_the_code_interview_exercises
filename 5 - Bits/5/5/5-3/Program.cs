// Flip Bit to Win: You have an integer and you can flip exactly one bit from a 13 to a 1. Write code to
// find the length of the longest sequence of ls you could create.
// EXAMPLE
// Input: 1775 (or: 11011101111)
// Output: 8

//int input = 1775;
int input = 2079222; // 111111011100111110110
int mask = 1;
int count = 0;
int maxLength = 0;
int startPosition = 0;
bool flipped = false;

for (int i = 0; i < 32; i++)
{
    int value = (mask << i) & input;

    if (value != 0)
    {
        count++;
    }
    else
    {
        if (!flipped)
        {
            flipped = true;
            count++;
        }
        else
        {
            maxLength = count > maxLength ? count : maxLength;
            count = 0;
            flipped = false;

            while (i > startPosition + 1)
            {
                i--;
            }
        }

        startPosition = i;
    }
}

Console.WriteLine(maxLength);
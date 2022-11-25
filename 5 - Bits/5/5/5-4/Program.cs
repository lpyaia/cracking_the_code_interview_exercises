using System.Runtime.CompilerServices;

uint input = 7;
uint max = uint.MaxValue;
uint min = input;
int qtyBitOne = GetNumOfOneBits(input);
int qtyBitOneMin = -1;
int qtyBitOneMax = -1;

do
{
    qtyBitOneMin = GetNumOfOneBits(++min);
} while (qtyBitOne != qtyBitOneMin);

uint mask = 1;

for (int i = 0; i < qtyBitOne; i++)
{
    mask = (mask << 1) | 1;
}

max = mask << (32 - qtyBitOne);

Console.WriteLine(qtyBitOne);
Console.WriteLine(min);
Console.WriteLine(max);

static int GetNumOfOneBits(uint number)
{
    uint mask = 1;
    int count = 0;

    for (int i = 0; i < 32; i++)
    {
        count += ((mask << i) & number) >= 1 ? 1 : 0;
    }

    return count;
}
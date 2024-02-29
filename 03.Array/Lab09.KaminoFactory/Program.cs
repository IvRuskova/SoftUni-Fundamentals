
using System.ComponentModel.Design;

int DNALenght = int.Parse(Console.ReadLine());
int[] DNA =new int[DNALenght];
int length = 1;
int currMaxLength = int.MaxValue;
int maxLength = int.MinValue;
int startIndex = 0;
int goodStartInd = int.MaxValue;

int maxSum = 0;
int sequenceIndex = 0;
int bestSequenceIndex = 0;

string command;

while ((command=Console.ReadLine()) != "Clone them!")
{
    int[] currDNA = command.Split('!', StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    sequenceIndex++;
    int sum = currDNA.Sum();
    for (int i = 0; i < currDNA.Length-1; i++)
    {
        if (currDNA[i] == 1 && currDNA[i+1] == 1)
        {
            length++;
            startIndex = string.Join("", currDNA).IndexOf(new string('1', length));
            if (length>currMaxLength)
            {
                bestSequenceIndex = length;
                bestSequenceIndex = startIndex;
            }
        }
        else
        {
            length = 1;
        }
    }
    if (currMaxLength >=  maxLength && startIndex<bestSequenceIndex) 
    {
        bestSequenceIndex = startIndex;
        maxSum = sum;
        DNA = currDNA;
        bestSequenceIndex = sequenceIndex;
    }
    if (currMaxLength>=maxLength && startIndex == bestSequenceIndex && sum > maxSum)
    {
        maxSum = sum;
        DNA = currDNA;
        bestSequenceIndex = sequenceIndex;
    }

}
Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {maxSum}.");
Console.WriteLine(string.Join(" ",DNA));


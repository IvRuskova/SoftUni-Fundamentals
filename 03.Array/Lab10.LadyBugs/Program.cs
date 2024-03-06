
//0->no ladybug, 1-> ladybug
int fieldSize = int.Parse(Console.ReadLine());
int[] laybugsIndexes = Console.ReadLine() // numbers of indexes with ladybugs
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

//Initialize the field
int[] field = new int[fieldSize];
for (int index = 0; index < fieldSize; index++)
{
    if (laybugsIndexes.Contains(index))
    {
        //ifindex is present in ladybugsInexes then there is a ladybug
        field[index] = 1;
    }
}

string command;
while ((command = Console.ReadLine()) != "end")
{
    string[] commandArgs = command
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    int initialIndex = int.Parse(commandArgs[0]);
    string diretion = commandArgs[1];
    int flyLength = int.Parse(commandArgs[2]);

    //First always check if index is valid
    if (initialIndex<0 || initialIndex >= field.Length)
    {
        //Nothing happens, next iteration
        //Skip the command
        continue;
    }

    //We have valid index, then we check if is a ladybug
    //If there isn't a ladybug
    if (field[initialIndex] == 0)
    {
        continue;
    }

    //Ladybug starts flying
    //Initail index set to 0, beacouse there is no ladybug anymore
    field[initialIndex] = 0;
    
    //Calculate where the next index is
    int nextIndex = initialIndex;
    while (true)
    {
        if (diretion == "right")
        {
            nextIndex += flyLength;
        }
        else if (diretion == "left")
        {
            nextIndex -= flyLength;
        }
        
        if (nextIndex < 0 || nextIndex>=field.Length)
        {
            //Outside of the field
            break;
        }
        if (field[nextIndex] == 0)
        {
            //The next index is empty and valid to land
            break;
        }
    }

    if (nextIndex>= 0 && nextIndex< field.Length)
    {
        //The next calculatedinex is valid
        field[nextIndex] = 1;
    }
}
Console.WriteLine(string.Join(" ", field));

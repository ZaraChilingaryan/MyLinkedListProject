PrintMainDiagonal(8);

void PrintMainDiagonal(int matrixSize)
{
    char[,] mtx = new char[matrixSize, matrixSize];

    for (int i = 0; i < matrixSize; i++)
    {
        for (int j = 0; j < matrixSize; j++)
        {
            mtx[i, j] = '*';

            if (i == j)
            {
                mtx[i, j] = '#';
            }

            if (i+j == matrixSize - 1)
            {
                mtx[i, j] = '~';
            }
        }
    }

    for (int i = 0; i < matrixSize; i++)
    {
        for (int j = 0; j < matrixSize; j++)
        {
            Console.Write(mtx[i, j] + " ");
        }
        Console.WriteLine();
    }

}

bool PrintShipMove(int x0, int y0, int x1, int y1)
{
    return x0 ==x1 || y0 ==y1;
}
Console.WriteLine(PrintShipMove(3,2,3,7));
Console.WriteLine(PrintShipMove(1,1,4,8));

bool PrintHorseMove(int x0, int y0, int x1, int y1)
{
    return x0 - x1 == 2 && y0 - y1 == 1 || x0 - x1 == 1 && y0 - y1 == 2;
}
Console.WriteLine(PrintHorseMove(3, 2, 3, 7));
Console.WriteLine(GetMinHorseMoves(0, 0, 7, 7));

int GetMinHorseMoves(int x0, int y0, int x1, int y1)
{
    int[,] horseMoves =
    {
        { 2, 1 }, { 2, -1 },
        { -2, 1 }, { -2, -1 },
        { 1, 2 }, { 1, -2 },
        { -1, 2 }, { -1, -2 }
    };

    int[,] steps = new int[8, 8];

    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            steps[i, j] = -1;
        }
    }

    Queue<(int x, int y)> queue = new();

    queue.Enqueue((x0, y0));
    steps[x0, y0] = 0;

    while (queue.Count > 0)
    {
        var current = queue.Dequeue();

        for (int i = 0; i < 8; i++)
        {
            int nx = current.x + horseMoves[i, 0];
            int ny = current.y + horseMoves[i, 1];

            if (nx >= 0 && nx < 8 &&
                ny >= 0 && ny < 8 &&
                steps[nx, ny] == -1)
            {
                steps[nx, ny] = steps[current.x, current.y] + 1;

                if (nx == x1 && ny == y1)
                {
                    return steps[nx, ny];
                }

                queue.Enqueue((nx, ny));
            }
        }
    }

    return -1;
}
static bool CanBishopMove(int x0, int x1, int y0, int y1)
{
    if (x0 == y0 && x1 == y1) return false;
    return Math.Abs(x0 - y0) == Math.Abs(x1 - y1);
}

Console.WriteLine(PrintHorseMove(3, 2, 3, 7));
Console.WriteLine(GetMinHorseMoves(0, 0, 7, 7));
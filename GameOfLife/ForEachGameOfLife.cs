using System.Threading.Tasks;

namespace GameOfLife
{
    class ForEachGameOfLife : GameOfLife
    {
        public ForEachGameOfLife(int gridSize) : base(gridSize)
        {

        }

        public override void Run(int step)
        {
            while (step > 0)
            {
                Parallel.For(0, _gridSize, row =>
                {
                    for (var col = 0; col < _gridSize; col++)
                    {
                        if (ShallLocationBeAlive(row, col))
                        {
                            // ++locationsAlive;
                            _newGrid[row, col] = 1;
                        }
                        else
                        {
                            _newGrid[row, col] = 0;
                        }
                    }
                    Swap(ref _curGrid, ref _newGrid);
                    // Console.WriteLine(locationsAlive);
                    step--;
                });
            }
        }
    }
}
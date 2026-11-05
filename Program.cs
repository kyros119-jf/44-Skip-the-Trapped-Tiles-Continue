
for (int tile = 1; tile <= 10; tile++)
{
    if (tile == 3 || tile == 7)
    {
        Console.WriteLine($"Tile {tile} is trapped! Skipping.");
        continue;
    }

    Console.WriteLine($"Stepping on tile {tile}");
}

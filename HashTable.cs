public class HashTable
{

    private List<string>[] table = new List<string>[5];

    public void Insert(string value)
    {
        int position = this.HashFunction(value);
        Console.WriteLine($"Adicionando \"{value}\" na posicao {position}");
        if (this.table[position] == null)
        {
            this.table[position] = new List<string>();
        }
        this.table[position].Insert(0, value);
    }

    private int HashFunction(string value)
    {
        int number = 0;
        foreach (char c in value)
            number += Convert.ToInt32(c);

        return number % 5;
    }

    public void ListAll()
    {
        for (int i = 0; i < table.Length; i++) {
            if (table[i] != null) {
                foreach (string cell in table[i])
                {
                    Console.Write(cell);
                    Console.Write(" -> ");
                }
                    Console.Write("\n");
            }
        }
    }

} 
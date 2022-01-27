string content = "1 1 5 9 8 1 3 5 8 1 1 8 7 5 6 1 2 9  1 2 5 8 0 2";

string item = "";
foreach (Char c in content.Replace(" ", ""))
{
    item += c;
    if (Convert.ToInt32(item) > 120) { Console.Write(item.Remove(item.Length - 1, 1) + " "); item = c.ToString(); }
}
const string inputfile = "C:/users/robin/downloads/input.txt";
const string outputfile = "C:/users/robin/downloads/output.txt";
File.Delete(outputfile);

string item = "";
foreach (Char c in File.ReadAllText(inputfile).Replace(" ", ""))
{
    item += c;
    if (Convert.ToInt32(item) > 120) { File.AppendAllText(outputfile, item.Remove(item.Length - 1, 1) + " "); item = c.ToString(); }
}
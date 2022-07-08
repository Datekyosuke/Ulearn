static int Decode(string a)
{
	int b = Int32.Parse(a.Replace(".", ""));
	return b % 1024;
}

private static string GetMinX(int a, int b, int c)
{
	double x;
	if (a > 0 || (a == 0 && b == 0))
	{
		x = (double)(-b) / (2 * a);
		return x.ToString();
	}
	else
		return "Impossible";
	// так можно вернуть строковое представление числа
}
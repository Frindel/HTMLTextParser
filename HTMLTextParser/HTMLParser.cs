namespace HTMLTextParser;

public class HTMLParser
{
	public string GetMaximumText(Uri uri, int reverseIndentation)
	{
		HttpClient client = new HttpClient();
		string html = client.GetStringAsync(uri).Result;

		string text = GetMaximumText(html, reverseIndentation);

		return text;
	}
	
	public string GetMaximumText(string html, int reverseIndentation)
	{
		// todo: поиск тега с максимальным текстовым содержимым

		return String.Empty;
	}
}
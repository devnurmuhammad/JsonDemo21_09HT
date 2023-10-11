using Newtonsoft.Json;

double money;
string from, to;

Console.Write("Valyutani kiriting: ");
from = Console.ReadLine();

Console.Write("Qaysi valyutaga: ");
to = Console.ReadLine();

Console.Write("Summani kiriting: ");
money = double.Parse(Console.ReadLine());

using (HttpClient client = new HttpClient())
{
    string BASE_URL = "https://nbu.uz/uz/exchange-rates/json/";

    HttpResponseMessage responce = await client.GetAsync(BASE_URL);

    string respon = await responce.Content.ReadAsStringAsync();

    //Console.WriteLine(respon);

    var data = JsonConvert.DeserializeObject<List<Data>>(respon);
    string res = data.FirstOrDefault(x => x.code) == from;
    //if ()
    //{
    //    Console.WriteLine("SA");
    //}
    //else { Console.WriteLine("MA"); }

    //foreach(var item in data)
    //{
    //    Console.WriteLine(item.cb_price);
    //}
}


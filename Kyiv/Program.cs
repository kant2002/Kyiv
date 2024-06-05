using Kyiv;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Мікрософт.АспНетЯдро.Компоненти.Веб;
using Мікрософт.АспНетЯдро.Компоненти.ВебАсемблі.Хостінг;

var будівник = БудівникХостаВебАсемблі.СтворитиЗаЗамовчанням(args);
будівник.КорневіКомпоненти.Add<Апка>("#app");
будівник.КорневіКомпоненти.Add<ВіддушинаЗаголовка>("head::after");

будівник.Сервіси.AddScoped(sp => new HttpClient { BaseAddress = new Uri(будівник.ОточенняХоста.BaseAddress) });

await будівник.Побудувати().ЗапуститиАсінх();
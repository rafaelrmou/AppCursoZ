using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Text;

namespace Model
{
	public class ApiCall
	{
		public ApiCall ()
		{
		}

		public async Task<T> GetResponse<T>(string method) where T : class
		{

			var client = new System.Net.Http.HttpClient();

			//Definide o Header de resultado para JSON, para evitar que seja retornado um HTML ou XML
			client.DefaultRequestHeaders.Accept.Add(
				new MediaTypeWithQualityHeaderValue("application/json"));

			//Formata a Url com o metodo e o parametro enviado e inicia o acesso a Api. Como o acesso será por meio
			//da Internet, pode demorar muito, para que o aplicativo não trave usamos um método assincrono
			//e colocamos a keyword AWAIT, para que a Thread principal - UI - continuo sendo executada
			//e o método so volte a ser executado quando o download das informações for finalizado
			var response = await client.GetAsync(string.Format(ApiUrl, method));

			//Lê a string retornada
			var JsonResult = response.Content.ReadAsStringAsync().Result;

			if (typeof(T) == typeof(string))
				return null;

			//Converte o resultado Json para uma Classe utilizando as Libs do Newtonsoft.Json
			var rootobject = JsonConvert.DeserializeObject<T>(JsonResult);

			return rootobject;
		}

		public async Task<bool> PostResponse<T>(string method, T Objeto){

			var client = new System.Net.Http.HttpClient();

			//Definide o Header de resultado para JSON, para evitar que seja retornado um HTML ou XML
			client.DefaultRequestHeaders.Accept.Add(
				new MediaTypeWithQualityHeaderValue("application/json"));

			var ContentPost = new System.Net.Http.StringContent(
				JsonConvert.SerializeObject (Objeto), Encoding.UTF8, "application/json");

			//Formata a Url com o metodo e o parametro enviado e inicia o acesso a Api. Como o acesso será por meio
			//da Internet, pode demorar muito, para que o aplicativo não trave usamos um método assincrono
			//e colocamos a keyword AWAIT, para que a Thread principal - UI - continuo sendo executada
			//e o método so volte a ser executado quando o download das informações for finalizado
			var response = await client.PostAsync(string.Format(ApiUrl, method),ContentPost);

			if (!response.IsSuccessStatusCode) {
				return false;
			}

			return true;
		}
		static readonly string ApiUrl = "http://servicekluh.azurewebsites.net/api/{0}";
	}
}


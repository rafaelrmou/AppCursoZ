using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Model
{
	public class AmigoModel
	{

		public AmigoModel ()
		{
			WS = new ApiCall ();
		}

		[JsonIgnore]
		public ApiCall WS {
			get;
			set;
		}

		public async Task<List<AmigoModel>> GetAllFormServer ()
		{

			return await WS.GetResponse<List<AmigoModel>> ("amigo");

		}

		public async Task<bool> Save(){

			return await WS.PostResponse<AmigoModel> ("amigo", this);

		}

		[JsonProperty ("NM_AMIGO")]
		public string Nome {
			get;
			set;
		}

		[JsonProperty("ID_AMIGO")]
		public int ID {
			get;
			set;
		}

		public string NR_TELEFONE {
			get;
			set;
		}

		public DateTime DT_NASCIMENTO {
			get;
			set;
		}

		public string DS_EMAIL {
			get;
			set;
		}
	}
}


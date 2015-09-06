using System;

namespace ListaApp
{
	public class FeedDTO
	{
		public FeedDTO ()
		{
		}

		public string Nome {
			get;
			set;
		}

		public string Quando {
			get;
			set;
		}

		public string Texto {
			get;
			set;
		}

		public bool CanLike {
			get;
			set;
		}
		public bool CanComment {
			get;
			set;
		}
		public object CanShare {
			get;
			set;
		}
	}
}


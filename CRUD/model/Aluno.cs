using System;
using SQLite.Net.Attributes;

namespace CRUD
{
	[Table ("Aluno")]
	public class Aluno
	{
		[PrimaryKey, AutoIncrement]
		public int ID {
			get;
			set;
		}

		[NotNull]
		public string Nome {
			get;
			set;
		}
	}
}


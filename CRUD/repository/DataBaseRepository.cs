using System;
using SQLite.Net;
using System.Collections.Generic;
using SQLite.Net.Interop;
using System.Collections;
using System.Linq;

namespace CRUD
{
	public class DataBaseRepository
	{
		//Conexão a base de dados
		private SQLiteConnection dbCon;

		//Mensagem que será retornada ao usuário
		public string Mensage { get; set; }

		/// <summary>
		/// Construtor da casse para a criação da conexão
		/// </summary>
		/// <param name="sqliteP">Plataforma - ios, android ou winPhone</param>
		/// <param name="dbPath">Caminho onde está o arquivo db3</param>
		public DataBaseRepository (ISQLitePlatform sqliteP, string dbPath)
		{
			if (dbCon == null) {

				dbCon = new SQLiteConnection (sqliteP, dbPath);
				dbCon.CreateTable<Aluno> ();

			}
		}

		public void Add (Aluno entidadeNova)
		{
			int res = 0;

			try {
				res = dbCon.Insert (entidadeNova);
				Mensage = string.Format ("{0} registro(s)", res);


			} catch (Exception e) {
				Mensage = string.Format ("Falha ao Inserir a entidade {0}. Erro: {1}", entidadeNova.GetType ().ToString (), e.Message);
			}
		}

		public void Add (Aluno[] entidades)
		{
			int res = 0;

			try {
				res = dbCon.InsertAll (entidades);
				Mensage = string.Format ("{0} registro(s)", res);
			} catch (Exception e) {
				Mensage = string.Format ("Falha ao Inserir a entidade {0}. Erro: {1}", entidades.GetType ().ToString (), e.Message);
			}
		}

		public void Delete (Aluno entity)
		{
			dbCon.Delete (entity);
		}

		public void Update (Aluno entity)
		{
			dbCon.Update (entity);
		}

		public IEnumerable<Aluno> List {
			get {
				return dbCon.Table<Aluno> ().ToList ();
			}
		}

	}
}


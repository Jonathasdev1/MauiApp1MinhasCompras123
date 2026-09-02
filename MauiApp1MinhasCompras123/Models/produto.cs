using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions.Task;
using SQLite;


namespace MauiApp1MinhasCompras123.Models
{
    internal class produto
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public double Quantidade { get; set; }
    }
}

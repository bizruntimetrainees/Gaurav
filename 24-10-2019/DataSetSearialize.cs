using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Data;

namespace _24_10_2019
{
    class DataSetSearialize
    {
        public static void GetDetails()
        {
            DataSet data =new DataSet("dataset"); ;
            data.Namespace = "NetFrameWork";
            DataTable table = new DataTable();
            DataColumn idcolumn = new DataColumn("id", typeof(int));
            idcolumn.AutoIncrement = true;

            DataColumn namecolumn = new DataColumn("name");
            table.Columns.Add(idcolumn);
            table.Columns.Add(namecolumn);
            data.Tables.Add(table);

            for(int i=0;i<2;i++)
            {
                DataRow newrow = table.NewRow();
                newrow["name"] = "name" + i;
                table.Rows.Add(newrow);
            }
            data.AcceptChanges();

            string serialize = JsonConvert.SerializeObject(data);
            Console.WriteLine(serialize);

        }
        static void Main(string[] args) 
        {
            DataSetSearialize.GetDetails();
        }
    }
}

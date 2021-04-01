using BBREST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBREST.DataStorage
{
    public static class DataManager
    {
        public static List<ChatModel> GetData()
        {
            var r = new Random();
            return new List<ChatModel>
            {
                new ChatModel { Data = new List<int> {r.Next(1,40)}, Label = "Data1"},
                new ChatModel { Data = new List<int> {r.Next(1,40)}, Label = "Data1"},
                new ChatModel { Data = new List<int> {r.Next(1,40)}, Label = "Data1"},
                new ChatModel { Data = new List<int> {r.Next(1,40)}, Label = "Data1"}
            };
        }
    }
}

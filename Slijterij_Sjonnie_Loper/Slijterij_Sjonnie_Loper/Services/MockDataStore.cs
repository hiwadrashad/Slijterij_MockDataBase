using Microsoft.AspNetCore.Razor.Language;
using Slijterij_Sjonnie_Loper.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Slijterij_Sjonnie_Loper.Services
{
    
    public class MockDataStoreClient : IDataStore<ModelClient>
    {
        public readonly List<ModelClient> items;

        public MockDataStoreClient()
        {
            // storedictionary.Add(SingletonData.StoreDataWhiskey.items.FirstOrDefault(),1);

            items = new List<ModelClient>()
            {
            new ModelClient { id = Guid.NewGuid().ToString(),  Name = "John Smith", Whiskeys = new List<string>{ "Jack Daniels" }, Amount = new List<int>{ 1 } }
            };
        }
        public  bool AddItem(ModelClient item)
        {
            items.Add(item);

            return true;
        }

        public bool UpdateItem(ModelClient item)
        {
            var oldItem = items.Where((ModelClient arg) => arg.id == item.id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return true;
        }

        public bool DeleteItem(string id)
        {
            var oldItem = items.Where((ModelClient arg) => arg.id == id).FirstOrDefault();
            items.Remove(oldItem);

            return true;
        }

        public ModelClient GetItem(string id)
        {
            return items.FirstOrDefault(s => s.id == id);
        }

        public List<ModelClient> ReturnList()
        {
            return items;
        }
     
    }



    public class MockDataStoreCollaborator : IDataStore<ModelCollaborator>
    {

        public readonly List<ModelCollaborator> items;

        public MockDataStoreCollaborator()
        {
            items = new List<ModelCollaborator>()
            {
            new ModelCollaborator { id = Guid.NewGuid().ToString(), Password = "password", Username = "username", LoginErrorMessage=""}
            };
        }

        public bool AddItem(ModelCollaborator item)
        {
            items.Add(item);

            return true;
        }

        public bool UpdateItem(ModelCollaborator item)
        {
            var oldItem = items.Where((ModelCollaborator arg) => arg.id == item.id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return true;
        }

        public bool DeleteItem(string id)
        {
            var oldItem = items.Where((ModelCollaborator arg) => arg.id == id).FirstOrDefault();
            items.Remove(oldItem);

            return true;
        }

        public ModelCollaborator GetItem(string id)
        {
            return items.FirstOrDefault(s => s.id == id);
        }

        public List<ModelCollaborator> ReturnList()
        {
            return items;
        }

        #nullable enable
        public ModelCollaborator? GetItemBynameAndPassword(string Username, string Password)
        {
             return items.Where(s => s.Username == Username && s.Password == Password).FirstOrDefault();
        }

        public bool UpdateErrorMessage(ModelCollaborator item)
        {
            var oldItem = items.Where((ModelCollaborator arg) => arg.id == item.id).FirstOrDefault();
            oldItem.LoginErrorMessage = "Wrong Username or Password";
            return true;
        }
    }



    public class MockDataStoreWhiskey : IDataStore<ModelWhiskey>
    {

        public readonly List<ModelWhiskey> items;

        public MockDataStoreWhiskey()
        {
            items = new List<ModelWhiskey>()
            {
            new ModelWhiskey { Id = Guid.NewGuid().ToString(), Age = "50", AlcoholPercentage = "90", AmountOfBottles =  12, Label = File.ReadAllBytes("Images/whiskey-label.png"), Name = "Jack Daniels", Price = "12.50", ProductionSite = "France", TypeWhiskey = "Single Malt" }
            };
        }

        public List<ModelWhiskey>? SearchWhiskeys(string name)
        {

            return items.Where(x => x.Name == name || name == null).ToList();
        }

        public bool AddItem(ModelWhiskey item)
        {
            items.Add(item);

            return true;
        }

        public bool UpdateItem(ModelWhiskey item)
        {
            var oldItem = items.Where((ModelWhiskey arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return true;
        }

        public bool DeleteItem(string id)
        {
            var oldItem = items.Where((ModelWhiskey arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return true;
        }

        public ModelWhiskey GetItem(string id)
        {
            return items.FirstOrDefault(s => s.Id == id);
        }

        public List<ModelWhiskey> ReturnList()
        {
            return items;
        }
    }


}

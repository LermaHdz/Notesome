using Notesome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notesome.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Titulo = "Nota 1", Descripcion="Descripcion de la nota 1." },
                new Item { Id = Guid.NewGuid().ToString(), Titulo = "Nota 2", Descripcion="Descripcion de la nota 2." },
                new Item { Id = Guid.NewGuid().ToString(), Titulo = "Nota 3", Descripcion="Descripcion de la nota 3." },
                new Item { Id = Guid.NewGuid().ToString(), Titulo = "Nota 4", Descripcion="Descripcion de la nota 4." },
                new Item { Id = Guid.NewGuid().ToString(), Titulo = "Nota 5", Descripcion="Descripcion de la nota 5." },
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}
using System;
using System.Collections.Generic;
using MyNewAPI.Models;

namespace MyNewAPI
{
    public class PartsRepository : IPartsRepository{
        private static readonly List<Part> _parts = new List<Part> {
                new Part { Name = "Part 1", Id = 1}
            };

        public List<Part> GetAllParts()
        {
            return _parts; 
        }

        public Part AddPart(Part newPart)
        {
            _parts.Add(newPart);
            return newPart;
        }
    }
}
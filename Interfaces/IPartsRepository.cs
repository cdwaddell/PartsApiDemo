using System;
using System.Collections.Generic;
using MyNewAPI.Models;

namespace MyNewAPI
{
    public interface IPartsRepository
    {
        List<Part> GetAllParts();
        Part AddPart(Part newPart);
    }
}
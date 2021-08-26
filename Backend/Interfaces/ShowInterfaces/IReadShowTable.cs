using System.Collections.Generic;
using Phish_Website.Backend.Model;

namespace Phish_Website.Backend.Interfaces.ShowInterfaces
{
    public interface IReadShowTable
    {
         public List<Shows> ReadShowTable();
    }
}